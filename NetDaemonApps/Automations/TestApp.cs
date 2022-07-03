using NetDaemon.Client;
using System.Threading.Tasks;
using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Client.Internal.HomeAssistant.Commands;

namespace NetDaemonApps
{

    public record SimpleCommand : CommandMessage
    {
        public SimpleCommand(string type)
        {
            Type = type;
        }
    }

    public record DeviceCommand : CommandMessage
    {
        [JsonPropertyName("device_id")]
        public string DeviceId { get; init; }

        public DeviceCommand(string type, string deviceId)
        {
            Type = type;
            DeviceId = deviceId;
        }
    }



    public record StateTrigger
    {
        [JsonPropertyName("entity_id")]
        public string? EntityId { get; init; }

        [JsonPropertyName("platform")]
        public string? Platform { get; init; }

        [JsonPropertyName("from")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? From { get; init; }

        [JsonPropertyName("to")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? To { get; init; }

    }

    public record DeviceTrigger
    {
        [JsonPropertyName("device_id")]
        public string? DeviceId { get; init; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("domain")]
        public string? Domain { get; init; }

        [JsonPropertyName("platform")]
        public string? Platform { get; init; }

        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; init; }

        [JsonPropertyName("subtype")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubType { get; init; }

        [JsonPropertyName("discovery_id")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DiscoveryId { get; init; }


    }

    public record SubscribeTriggerCommand : CommandMessage
    {
        [JsonPropertyName("trigger")]
        public StateTrigger Trigger { get; init; }

        public SubscribeTriggerCommand(string entityId, string? from, string? to)
        {
            Type = "subscribe_trigger";
            Trigger = new StateTrigger()
            {
                Platform = "state",
                EntityId = entityId,
                From = from,
                To = to
            };
        }
    }

    public record SubscribeDeviceTriggerCommand : CommandMessage
    {
        [JsonPropertyName("trigger")]
        public DeviceTrigger Trigger { get; init; }

        public SubscribeDeviceTriggerCommand(string deviceId, string? domain, string? type, string? subtype, string discoveryId)
        {
            Type = "subscribe_trigger";
            Trigger = new DeviceTrigger()
            {
                Platform = "device",
                Domain = domain,
                DeviceId = deviceId,
                Type = type,
                DiscoveryId = discoveryId,
                SubType = subtype
            };
        }
    }





    //[Focus]
    //[NetDaemonApp]
    public class TestApp : IAsyncInitializable, IAsyncDisposable
    {
        private readonly IHomeAssistantConnection connection;

        public TestApp(IHomeAssistantConnection connection)
        {
            this.connection = connection;
        }

        public async Task InitializeAsync(CancellationToken cancellationToken)
        {
            var cmd = new SubscribeDeviceTriggerCommand("bb478a4241e01f54a0d753c23cce3737", "mqtt", "action", "on", "0x2c1165fffea5dd3f action_on");

            var result = await connection.SendCommandAndReturnResponseAsync<SubscribeDeviceTriggerCommand, Object>(
                cmd, cancellationToken);

            var messages = connection as IHomeAssistantHassMessages;

            messages!.OnHassMessage.Where(m => m.Id == cmd.Id).Subscribe
                (m => DoSomething(m));


            //var devices = await runner!.CurrentConnection!
            //    .SendCommandAndReturnResponseAsync<SimpleCommand,
            //    IEnumerable<HassDevice>>(new SimpleCommand("config/device_registry/list"), cancellationToken);

            //var mydevice = devices!.FirstOrDefault(d => d.NameByUser == "Bedroom Dimmer");

            //var triggers = await runner!.CurrentConnection!
            //    .SendCommandAndReturnResponseAsync<DeviceCommand,
            //    IEnumerable<Object>>(new DeviceCommand("device_automation/trigger/list", mydevice!.Id!), cancellationToken);

            //StateTrigger.For(new string[] { "binary_sensor.somesensor" })
            //    .When("on")
            //    .From("off")
            //    .For(TimeSpan.FromMinutes(20))
            //    .Execute(() => { });
        }

        private void DoSomething(HassMessage m)
        {
            string mx = m.Message;
        }

        public ValueTask DisposeAsync() { return ValueTask.CompletedTask; }


        public class DeviceTriggers
        {

        }
    }

   
}


