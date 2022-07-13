using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using NetDaemon.Extensions.MqttEntityManager;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.PresenceApp;

public class BleDeviceHandler
{
    
    const string GATHER_FILE = "gather.log";
    const int DATA_GATHER_SAMPLES = 120;
    const int ROGUE_LIFE = 15;

    public const int STATION_FIRST = STATION_OFFICE;
    public const int STATION_OFFICE = 0;
    public const int STATION_BEDROOM = 1;
    public const int STATION_CHILDROOM = 2;
    public const int STATION_TECHROOM = 3;
    public const int STATION_KITCHEN = 4;
    public const int STATION_LIVINGROOM = 5;
    public const int STATION_LIVINGROOM2 = 6;
    public const int STATION_SHED = 7;
    public const int STATION_LAST = STATION_SHED;
    public const int STATION_COUNT = STATION_LAST + 1;

    public const int SMARTTAG_COUNT = 4;


    IManagedMqttClient mqttClient;
    IMqttEntityManager mqttEntityManager;
    IScheduler scheduler;
    ILogger logger;
    IEntities entities;


    private static readonly Dictionary<string, string> icons = new()
    {
        { "office", "hue:room-office" },
        { "bedroom", "hue:room-bedroom" },
        { "child_room", "hue:room-games" },
        { "entry_hall", "hue:room-other" },
        { "hall", "hue:room-other" },
        { "stairs", "hue:room-stairs" },
        { "tech_room", "mdi:server" },
        { "living_room", "hue:room-living" },
        { "kitchen", "hue:room-kitchen"},
        { "bathroom", "hue:room-bathroom"},
        { "shower", "mdi:shower-head"},
        { "dressing", "hue:room-hallway" },
        { "terrace", "hue:room-terrace" },
        { "gazebo", "mdi:greenhouse" },
        { "shed", "mdi:warehouse" },
        { "garage", "mdi:car" },
        { "lawn", "mdi:grass" },
        { "entry", "mdi:gate" },
        { "home", "mdi:home" },
    };


    InputBooleanEntity gatherToggle
        => entities.InputBoolean.BleStatsToggle;
    InputTextEntity gatherText
        => entities.InputText.BleStatsName;
    CounterEntity gatherCounter
        => entities.Counter.BleStatsCounter;
    InputSelectEntity gatherBeacon
        => entities.InputSelect.BleStatsBeacon;

    bool dataGatherActive;
    TextWriter? dataGatherWriter;
    int dataGatherSamples;

    void StartDataGather()
    {
        dataGatherActive = true;
        dataGatherSamples = 0;
        gatherCounter.Reset();
        dataGatherWriter = File.AppendText(GATHER_FILE);
    }

    void StopDataGather()
    {
        dataGatherActive = false;
        dataGatherWriter?.Close();
        dataGatherWriter = null;
        gatherToggle.TurnOff();
        LoadGatherData();
    }
    

    readonly Dictionary<string, int> stationIds = new()
    {
        { "office", STATION_OFFICE },
        { "bedroom", STATION_BEDROOM },
        { "child_room", STATION_CHILDROOM },
        { "tech_room", STATION_TECHROOM },
        { "kitchen", STATION_KITCHEN },
        { "living_room", STATION_LIVINGROOM },
        { "living_room_2", STATION_LIVINGROOM2 },
        { "shed", STATION_SHED },
    };

    readonly Dictionary<string, BleDeviceSignal> Signals = new();
    readonly Dictionary<string, BleDeviceSignal> Rogues = new();
    public static IEnumerable<ZoneData>? Data = new List<ZoneData>();

    public BleDeviceHandler(IHaContext haContext, IMqttEntityManager mqttEntityManager, IManagedMqttClient mqttClient, IScheduler scheduler, ILogger logger)
    {
        this.scheduler = scheduler;
        this.mqttClient = mqttClient;
        this.mqttEntityManager = mqttEntityManager;
        this.logger = logger;
        this.entities = new Entities(haContext);

        var entities = haContext.GetAllEntities().Where(e => e.EntityId.StartsWith("sensor.smart_tag_beacon_"));

        foreach (var entity in entities)
        {
            string uniqueId = entity.EntityId;
            BleDeviceSignal signal = new BleDeviceSignal(scheduler, entity);
            signal.StateChanged += SignalStateChanged;
            signal.AttributesChanged += SignalAttributesChanged;
            Signals.Add(signal.MacAddress, signal);
            SignalStateChanged(signal, EventArgs.Empty);
            SignalAttributesChanged(signal, EventArgs.Empty);          
        }

        for (int i = Signals.Count; i < SMARTTAG_COUNT; i++)
        {
            var id = $"sensor.smart_tag_beacon_{i + 1}";
            var name = $"Smart Tag Beacon {i + 1}";

            BleDeviceSignal signal = new BleDeviceSignal(scheduler, id, i.ToString(), name);
            Signals.Add(signal.MacAddress, signal);
            var task = mqttEntityManager.CreateAsync(id,
                new EntityCreationOptions()
                {
                    Name = name,
                    Persist = true,
                },
                new MqttSensorAttributes()
                {
                    Icon = "mdi:home-export-outline",                    
                });
            task.Wait();
        }

        LoadGatherData();

        mqttClient.ApplicationMessageReceivedAsync += OnMqttMessage;

        mqttClient.SubscribeAsync("espresense/devices/smarttag:20/+");

        gatherToggle.StateChanges()
            .Where(s => s.New.IsOn())
            .Subscribe(_ => StartDataGather());



    }

    private Task MqttClient_ApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs arg)
    {
        throw new NotImplementedException();
    }

    private async void SignalAttributesChanged(object? sender, EventArgs e)
    {
        var signal = sender as BleDeviceSignal;
        await mqttEntityManager.SetAttributesAsync(signal!.UniqueId, signal!.Attributes);
        if (dataGatherActive && signal.FriendlyName == gatherBeacon.State)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{DateTime.Now:s},{gatherText.State}");
            int count = 0;
            for (int i = STATION_FIRST; i <= STATION_LAST; i++)
            {
                if (signal[i] != null)
                    ++count;
                sb.AppendFormat(",{0}", signal[i]);
            }

            await dataGatherWriter!.WriteLineAsync(sb.ToString());

            dataGatherSamples += count;
            for (int i = 0; i < count; i++)
                gatherCounter.Increment();
            if (dataGatherSamples >= DATA_GATHER_SAMPLES)
                StopDataGather();
        }
    
    }

    private async void SignalStateChanged(object? sender, EventArgs e)
    {
        var signal = sender as BleDeviceSignal;
        await mqttEntityManager.CreateAsync(signal!.UniqueId,
            new EntityCreationOptions() { Name = signal.FriendlyName, Persist = true },
            new
            {
                icon = signal.Room != null && icons.ContainsKey(signal.Room) ? icons[signal.Room] : "mdi:home-export-outline"
            });

        await mqttEntityManager.SetStateAsync(signal.UniqueId, signal.Room ?? "not_home");
       
    }

    Task OnMqttMessage(MqttApplicationMessageReceivedEventArgs arg)
    {
        var topic = arg.ApplicationMessage.Topic;
        var stationString = topic.Substring(topic.LastIndexOf('/') + 1);

        int station = stationIds[stationString];


        string? mac = null;
        int? rssi = null;

        try
        {
            Utf8JsonReader reader = new Utf8JsonReader(arg.ApplicationMessage.Payload);

            while ((mac == null || rssi == null) && reader.Read())
            {
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? prop = reader.GetString();
                    if (prop == "mac")
                    {
                        reader.Read();
                        mac = reader.GetString();
                    }
                    else if (prop == "rssi")
                    {
                        reader.Read();
                        rssi = reader.GetInt32();
                    }
                }
            }
        }
        catch
        {
            logger.LogWarning($"Unreadable payload received on mqtt topic {topic}");
        }

        if (mac != null && rssi != null)
        {
            if (Signals.ContainsKey(mac))            
                Signals[mac][station] = rssi;  
            else if (Rogues.ContainsKey(mac))
                Rogues[mac][station] = rssi;
            else
            {
                var rogue = new BleDeviceSignal(scheduler, mac, mac, null);
                Rogues.Add(mac, rogue);
                scheduler.Schedule(TimeSpan.FromSeconds(ROGUE_LIFE), () => HandleRogue(rogue));
            }
        }
        else
        {
            logger.LogWarning($"Invalid payload received on mqtt topic {topic}");
        }

        

        return Task.CompletedTask;
    }


    void HandleRogue(BleDeviceSignal rogue)
    {
        var losers = Signals.Values.Where(s => s.SecondsFromLastUpdate > BleDeviceSignal.MAX_AGE && s.SecondsFromLastUpdate <= ROGUE_LIFE + 1 && s.IsDead);
        if (!losers.Any())
            losers = Signals.Values.Where(s => s.SecondsFromLastUpdate > BleDeviceSignal.MAX_AGE);
        if (!losers.Any())
            losers = Signals.Values;

        var loser = losers.OrderBy(l => l.SecondsFromLastUpdate).First();

        

        Rogues.Remove(rogue.MacAddress);
        rogue.UniqueId = loser.UniqueId;
        rogue.FriendlyName = loser.FriendlyName;
        Signals.Remove(loser.MacAddress);
        Signals.Add(rogue.MacAddress, rogue);

        loser.Dispose();

        rogue.StateChanged += SignalStateChanged;
        rogue.AttributesChanged += SignalAttributesChanged;
        SignalStateChanged(rogue, EventArgs.Empty);
        SignalAttributesChanged(rogue, EventArgs.Empty);
    }


    record GatherData(string Zone, int[] Rssi);
    public record ZoneData(string Station, double[] Average, int[] Min, int[] Max);

    private static void LoadGatherData()
    {

        List<GatherData> stats = new();
        using (var reader = new StreamReader(GATHER_FILE))
        {
            while (!reader.EndOfStream)
            {
                var data = reader!.ReadLine()!.Split(',');
                stats.Add(new GatherData(data[1],
                    new int[]
                    {
                        String.IsNullOrEmpty(data[2]) ? BleDeviceSignal.MIN_SIGNAL  :  int.Parse(data[2]),
                        String.IsNullOrEmpty(data[3]) ? BleDeviceSignal.MIN_SIGNAL  :  int.Parse(data[3]),
                        String.IsNullOrEmpty(data[4]) ? BleDeviceSignal.MIN_SIGNAL  :  int.Parse(data[4]),
                        String.IsNullOrEmpty(data[5]) ? BleDeviceSignal.MIN_SIGNAL  :  int.Parse(data[5]),
                        String.IsNullOrEmpty(data[6]) ? BleDeviceSignal.MIN_SIGNAL  :  int.Parse(data[6]),
                        String.IsNullOrEmpty(data[7]) ? BleDeviceSignal.MIN_SIGNAL  :  int.Parse(data[7]),
                        String.IsNullOrEmpty(data[8]) ? BleDeviceSignal.MIN_SIGNAL  :  int.Parse(data[8]),
                        String.IsNullOrEmpty(data[9]) ? BleDeviceSignal.MIN_SIGNAL  :  int.Parse(data[9]),
                    }));
            }
        }

        Data = from s in stats
               group s by s.Zone into g
               select new ZoneData(
                   g.Key,
                   new double[]
                   {
                                      g.Average(i => (double)i.Rssi[0]),
                                      g.Average(i => (double)i.Rssi[1]),
                                      g.Average(i => (double)i.Rssi[2]),
                                      g.Average(i => (double)i.Rssi[3]),
                                      g.Average(i => (double)i.Rssi[4]),
                                      g.Average(i => (double)i.Rssi[5]),
                                      g.Average(i => (double)i.Rssi[6]),
                                      g.Average(i => (double)i.Rssi[7]),
                   },
                   new int[]
                   {
                                      g.Min(i => i.Rssi[0]),
                                      g.Min(i => i.Rssi[1]),
                                      g.Min(i => i.Rssi[2]),
                                      g.Min(i => i.Rssi[3]),
                                      g.Min(i => i.Rssi[4]),
                                      g.Min(i => i.Rssi[5]),
                                      g.Min(i => i.Rssi[6]),
                                      g.Min(i => i.Rssi[7]),
                   },
                   new int[]
                   {
                                      g.Max(i => i.Rssi[0]),
                                      g.Max(i => i.Rssi[1]),
                                      g.Max(i => i.Rssi[2]),
                                      g.Max(i => i.Rssi[3]),
                                      g.Max(i => i.Rssi[4]),
                                      g.Max(i => i.Rssi[5]),
                                      g.Max(i => i.Rssi[6]),
                                      g.Max(i => i.Rssi[7]),
                   }

               );
    }

}
