using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using NetDaemon.Extensions.MqttEntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetDaemonApps.Infrastructure.DeviceTriggers
{
    public class DeviceTriggers: IDeviceTriggers
    {
        readonly IOptions<MqttConfiguration> options;
        readonly IMqttFactory mqttFactory;
        readonly ILogger logger;

        

        bool disposed;

        IManagedMqttClient? mqttClient;


        Task? constructorTask;

        readonly Dictionary<string, DeviceConfig> deviceTriggers = new();
        readonly Subject<DeviceTrigger> subject = new();

        public DeviceTriggers(IServiceProvider provider)
        {
            var scope = provider.CreateScope();
            options = scope.ServiceProvider.GetService<IOptions<MqttConfiguration>>()!;
            ArgumentNullException.ThrowIfNull(options);
            mqttFactory = scope.ServiceProvider.GetService<IMqttFactory>()!;
            ArgumentNullException.ThrowIfNull(mqttFactory);
            logger = scope.ServiceProvider.GetService<ILogger<DeviceTriggers>>()!;
            ArgumentNullException.ThrowIfNull(logger);

            constructorTask = InitializeAsync();
        }

        async Task InitializeAsync()
        {
            var clientOptions = new ManagedMqttClientOptionsBuilder()
                .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
                .WithClientOptions(new MqttClientOptionsBuilder()
                    .WithTcpServer(options.Value.Host, options.Value.Port)
                    .WithCredentials(options.Value.UserName, options.Value.Password))
                .Build();

            mqttClient = mqttFactory.CreateManagedMqttClient();
            await mqttClient.StartAsync(clientOptions);

            mqttClient.UseApplicationMessageReceivedHandler(OnMqttMessage);
            await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic($"{options.Value.DiscoveryPrefix}/device_automation/+/+/config").Build());
        }

        static string? TranslatePayload(in byte[] payload)
        {
            if (payload.Length == 0)
                return String.Empty;

            string? result = null;
            try
            {
                result = Encoding.UTF8.GetString(payload);
            }
            catch { }

            return result;
        }



        async Task OnMqttMessage(MqttApplicationMessageReceivedEventArgs arg)
        {

            var topic = arg.ApplicationMessage.Topic;
            if (topic.StartsWith($"{options.Value.DiscoveryPrefix}/device_automation/") && topic.EndsWith("/config"))
            {

                if (arg.ApplicationMessage.Payload.Length == 0)
                {
                    //empty payload, config deleted
                    if (deviceTriggers.TryGetValue(topic, out var trigger))
                    {
                        await mqttClient.UnsubscribeAsync(trigger.Topic);
                        deviceTriggers.Remove(topic);
                    }
                }
                else
                {
                    //update or new
                    DeviceConfig? config = null;
                    try
                    {
                        config = JsonSerializer.Deserialize<DeviceConfig>(arg.ApplicationMessage.Payload);
                    }
                    catch { }

                    bool valid = config != null
                        && config.AutomationType == "trigger"
                        && config.Type != null
                        && config.Topic != null
                        && config.SubType != null
                        && config.Device?.Identifiers?.Any() != false;

                    if (valid)
                    {
                        //update -> remove existing
                        if (deviceTriggers.TryGetValue(topic, out var registeredConfig))
                        {
                            await mqttClient.UnsubscribeAsync(registeredConfig.Topic);
                            deviceTriggers.Remove(topic);
                        }
                        //add
                        deviceTriggers.Add(topic, config!);
                        await mqttClient.SubscribeAsync(config!.Topic);
                    }
                    else
                        logger.LogWarning($"Invalid or unknown device trigger type received on {topic}");
                }
            }
            else
            {
                try
                {
                    var payload = TranslatePayload(arg.ApplicationMessage.Payload);
                    var configs = deviceTriggers.Values.Where(v => v.Topic == topic && (v.Payload == null || v.Payload == payload));

                    //should be one trigger but you never know
                    foreach (var config in configs)
                    {
                        try
                        {
                            subject.OnNext(new DeviceTrigger(config));
                        }
                        catch
                        {
                            logger.LogError("Error in subscriber");
                        }
                    }
                }
                catch
                {
                    logger.LogWarning($"Invalid device event received on ${topic}");
                }



            }

        }

        public IDisposable Subscribe(IObserver<DeviceTrigger> observer)
        {
            return subject.Subscribe(observer);
        }


        public void Dispose()
        {
            if (!disposed)
            {
                subject.Dispose();
                mqttClient?.Dispose();
                disposed = true;                
            }
        }
    }
}
