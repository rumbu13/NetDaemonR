using Microsoft.Extensions.Options;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using NetDaemon.Extensions.MqttEntityManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.PresenceApp;

//[Focus]
[NetDaemonApp]
public class PresenceApp : IAsyncInitializable, IAsyncDisposable
{
    MqttFactory mqttFactory;
    IManagedMqttClient? mqttClient;
    IMqttEntityManager mqttEntityManager;
    IScheduler scheduler;
    ILogger logger;
    MqttConfiguration mqttConfiguration;
    BleDeviceHandler? bleDeviceHandler;
    IHaContext haContext;
    IEntities entities;

    


    public PresenceApp(IHaContext haContext, IOptions<MqttConfiguration> options, IMqttEntityManager mqttEntityManager,
        MqttFactory mqttFactory, IScheduler scheduler, ILogger<PresenceApp> logger)
    {
        this.haContext = haContext;
        this.mqttFactory = mqttFactory;
        this.mqttConfiguration = options.Value;
        this.mqttClient = null;
        this.scheduler = scheduler;
        this.logger = logger;
        this.mqttEntityManager = mqttEntityManager;
        this.entities = new Entities(haContext);


    }

    public async ValueTask DisposeAsync()
    {
        if (mqttClient != null)
            await mqttClient.StopAsync();
    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        var clientOptions = new ManagedMqttClientOptionsBuilder()
         .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
         .WithClientOptions(new MqttClientOptionsBuilder()
             .WithTcpServer(mqttConfiguration.Host, mqttConfiguration.Port)
             .WithCredentials(mqttConfiguration.UserName, mqttConfiguration.Password))
         .Build();

        mqttClient = mqttFactory.CreateManagedMqttClient();
        await mqttClient.StartAsync(clientOptions);


        bleDeviceHandler = new BleDeviceHandler(haContext, mqttEntityManager, mqttClient, scheduler, logger);

    }

}
