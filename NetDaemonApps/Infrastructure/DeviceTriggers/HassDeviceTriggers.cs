using Microsoft.Extensions.DependencyInjection;
using NetDaemon.Client;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using NetDaemon.Client.HomeAssistant.Extensions;
using NetDaemon.Client.HomeAssistant.Model;

namespace NetDaemonApps.Infrastructure.DeviceTriggers
{
    public class HassDeviceTriggers: IHassDeviceTriggers
    {
        readonly ILogger logger;
        readonly IHomeAssistantConnection connection;

        bool disposed;

        Task? constructorTask;
        private bool disposedValue;
        readonly Dictionary<int, Tuple<HassDevice, HassDeviceTrigger>> deviceTriggers = new();
        readonly Subject<DeviceTrigger> subject = new();

        public HassDeviceTriggers(IHomeAssistantConnection connection, ILogger<DeviceTriggers> logger)
        {
            
            this.logger = logger;
            this.connection = connection;

            constructorTask = InitializeAsync(CancellationToken.None);
        }

        public async Task InitializeAsync(CancellationToken cancellationToken)
        {
            var devices = await connection.GetDevicesAsync(cancellationToken);
            
           // var areas = await connection.GetAreasAsync(cancellationToken);

            foreach (var device in devices!)
            {
                var triggers = await connection
                    .SendCommandAndReturnResponseAsync<HassDeviceCommand, IReadOnlyList<HassDeviceTrigger>>(
                    new HassDeviceCommand("device_automation/trigger/list", device.Id!), cancellationToken);


                foreach (var trigger in triggers!.Where(t => t.Domain == "mqtt" && t.Platform == "device"))
                {
                    HassDeviceTriggerCommand cmd = new HassDeviceTriggerCommand(trigger);
                    await connection.SendCommandAndReturnResponseRawAsync<HassDeviceTriggerCommand>(cmd, cancellationToken);
                    deviceTriggers.Add(cmd.Id, new Tuple<HassDevice, HassDeviceTrigger>(device, trigger));
                }
            }

            var messages = connection as IHomeAssistantHassMessages;

            messages!.OnHassMessage.Where(m => deviceTriggers.ContainsKey(m.Id)).Subscribe
                (m => HandleTrigger(m.Id));

        }

        private void HandleTrigger(int id)
        {
            var t = deviceTriggers[id];
            try
            {
                subject.OnNext(new DeviceTrigger(t.Item1, t.Item2));
            }
            catch
            {
                logger.LogError("Error in subscriber");
            }
        }

        public IDisposable Subscribe(IObserver<DeviceTrigger> observer)
        {
            return subject.Subscribe(observer);
        }
     
    }

}
