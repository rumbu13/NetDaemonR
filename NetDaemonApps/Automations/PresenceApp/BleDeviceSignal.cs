using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.PresenceApp;

public class BleDeviceSignal : IDisposable
{

    public event EventHandler? StateChanged;
    public event EventHandler? AttributesChanged;
    public string UniqueId { get; set; }
    public string? FriendlyName { get; set; }
    public string MacAddress { get; private set; }

    public const int MIN_SIGNAL = -103;
    public const int MAX_AGE = 10;
    const int ROOM_AGE = 30;
    const int THRESHOLD_LIMIT = 10;
    const double THRESHOLD_ROOM = 20.0;


    IScheduler scheduler;
    bool disposed;
    int?[] rssiData;
    BleSensorAttributes attributes = new BleSensorAttributes();

    string room;
    string? nearest;
    double? distance;

    IDisposable?[] positionUpdaters;
    IDisposable? roomUpdater;

    bool scheduledForNotHome;
    bool scheduledForHome;

    public bool IsDead
        => rssiData.All(r => r == null);

    DateTime lastUpdated;

    public double SecondsFromLastUpdate
        => (DateTime.UtcNow - lastUpdated).TotalSeconds;

    public BleDeviceSignal(IScheduler scheduler, string uniqueId, string macAddress, string? friendlyName)
    {
        this.scheduler = scheduler;

        this.UniqueId = uniqueId;
        this.MacAddress = macAddress;
        this.FriendlyName = friendlyName;
        rssiData = new int?[BleDeviceHandler.STATION_COUNT];
        positionUpdaters = new IDisposable?[BleDeviceHandler.STATION_COUNT];
        this.room = "not_home";
        this.nearest = null;

    }

    public BleDeviceSignal(IScheduler scheduler, Entity e)
    {
        this.scheduler = scheduler;

        this.UniqueId = e.EntityId;
        var ae = e.WithAttributesAs<BleSensorAttributes>();
        this.FriendlyName = ae?.Attributes?.FriendlyName;
        this.MacAddress = ae?.Attributes?.MacAddress ?? e.EntityId;
        this.room = String.IsNullOrEmpty(e.State) ? "not_home" : e.State;
        this.nearest = ae?.Attributes?.Nearest;
        this.distance = ae?.Attributes?.Distance;
        

        rssiData = new int?[BleDeviceHandler.STATION_COUNT];
        positionUpdaters = new IDisposable?[BleDeviceHandler.STATION_COUNT];

        this.rssiData[BleDeviceHandler.STATION_OFFICE] = ae?.Attributes?.RSSIOffice;
        this.rssiData[BleDeviceHandler.STATION_BEDROOM] = ae?.Attributes?.RSSIBedroom;
        this.rssiData[BleDeviceHandler.STATION_CHILDROOM] = ae?.Attributes?.RSSIChildRoom;
        this.rssiData[BleDeviceHandler.STATION_TECHROOM] = ae?.Attributes?.RSSITechRoom;
        this.rssiData[BleDeviceHandler.STATION_KITCHEN] = ae?.Attributes?.RSSIKitchen;
        this.rssiData[BleDeviceHandler.STATION_LIVINGROOM] = ae?.Attributes?.RSSILivingRoom;
        this.rssiData[BleDeviceHandler.STATION_LIVINGROOM2] = ae?.Attributes?.RSSILivingRoom2;
        this.rssiData[BleDeviceHandler.STATION_SHED] = ae?.Attributes?.RSSIShed;

        for (int i = BleDeviceHandler.STATION_FIRST; i <= BleDeviceHandler.STATION_LAST; i++)
        {
            int j = i;
            positionUpdaters[i] = scheduler.Schedule(TimeSpan.FromSeconds(MAX_AGE), () => this[j] = null);
        }
    }

    public int? this[int station]
    {
        get => rssiData[station];
        set
        {
            if (value != null)
                lastUpdated = DateTime.UtcNow;

            if (rssiData[station] != value)
            {
                rssiData[station] = value;
                positionUpdaters[station]?.Dispose();
                positionUpdaters[station] = null;
                if (value != null)
                    positionUpdaters[station] = scheduler.Schedule(TimeSpan.FromSeconds(MAX_AGE), () => { this[station] = null; });
                AttributesChanged?.Invoke(this, EventArgs.Empty);
                UpdateRoom();                     
            }            
        }        
    }

    public string Room
    {
        get => room;
        private set
        {
            if (value == "home")
            {
                if (scheduledForNotHome || room == "not_home")
                {
                    roomUpdater?.Dispose();
                    roomUpdater = null;
                    room = value;
                    StateChanged?.Invoke(this, EventArgs.Empty);
                }
                else if (!scheduledForHome && room != "home")
                {
                    roomUpdater?.Dispose();
                    scheduledForHome = true;
                    roomUpdater = scheduler.Schedule(TimeSpan.FromSeconds(ROOM_AGE), () =>
                    {
                        scheduledForHome = false;
                        room = IsDead ? "not_home" : "home";
                        StateChanged?.Invoke(this, EventArgs.Empty);
                    });
                }
            }
            else if (value == "not_home")
            {
                if (scheduledForHome)
                {
                    scheduledForHome = false;
                    roomUpdater?.Dispose();
                    roomUpdater = null;
                }

                if (!scheduledForNotHome)
                {
                    scheduledForNotHome = true;
                    roomUpdater = scheduler.Schedule(TimeSpan.FromSeconds(ROOM_AGE), () =>
                    {
                        scheduledForNotHome = false;
                        room = IsDead ? "not_home" : "home";
                        StateChanged?.Invoke(this, EventArgs.Empty);
                    });
                }
            }
            else if (scheduledForHome || scheduledForNotHome)
            {
                roomUpdater?.Dispose();
                roomUpdater = null;
                scheduledForHome = false;
                scheduledForNotHome = false;
                room = value;
                StateChanged?.Invoke(this, EventArgs.Empty);
            }
            else if (value != room)
            {
                roomUpdater?.Dispose();
                roomUpdater = null;
                scheduledForHome = false;
                scheduledForNotHome = false;
                room = value;
                StateChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }

    public string? Nearest
    {
        get => nearest;
        private set
        {
            if (nearest != value)
            {
                nearest = value;
                AttributesChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }


    public BleSensorAttributes Attributes
    {
        get
        {
            var room = Room;
            attributes.RSSIOffice = this[BleDeviceHandler.STATION_OFFICE];
            attributes.RSSIBedroom = this[BleDeviceHandler.STATION_BEDROOM];
            attributes.RSSIChildRoom = this[BleDeviceHandler.STATION_CHILDROOM];
            attributes.RSSITechRoom = this[BleDeviceHandler.STATION_TECHROOM];
            attributes.RSSIKitchen = this[BleDeviceHandler.STATION_KITCHEN];
            attributes.RSSILivingRoom = this[BleDeviceHandler.STATION_LIVINGROOM];
            attributes.RSSILivingRoom2 = this[BleDeviceHandler.STATION_LIVINGROOM2];
            attributes.RSSIShed = this[BleDeviceHandler.STATION_SHED];
            attributes.Nearest = Nearest;
            attributes.FriendlyName = FriendlyName;
            attributes.MacAddress = MacAddress;
            attributes.Distance = distance;
            return attributes;
        }
    }

    void UpdateRoom()
    {
        double minDistance = double.PositiveInfinity;
        
        string? detectedRoom = null;
        string? detectedNearest = null;

        if (IsDead)
        {
            Room = "not_home";
            distance = null;
            Nearest = null;            
            return;
        }

        foreach (var stat in BleDeviceHandler.Data!)
        {
            double sum = 0;
            bool outsideRange = false;
            for (int station = BleDeviceHandler.STATION_FIRST; station <= BleDeviceHandler.STATION_LAST; station++)
            {
                var rssi = rssiData[station];
                var min = stat.Min[station];
                var  max = stat.Max[station];
                if (rssi < min - THRESHOLD_LIMIT || rssi > max + THRESHOLD_LIMIT)
                {
                    outsideRange = true;
                    break;
                }
                sum += Math.Pow((rssi ?? MIN_SIGNAL) - stat.Average[station], 2);
            }
            double distance = Math.Sqrt(sum);
            if (distance < minDistance && !outsideRange)
            {
                minDistance = distance;
                detectedRoom = stat.Station.Substring(0, stat.Station.LastIndexOf("_"));
                detectedNearest = stat.Station;
            }
        }

        distance = minDistance == double.PositiveInfinity ? null : minDistance;
        Room = minDistance < THRESHOLD_ROOM ? (detectedRoom ?? "home"): "home";
        Nearest = detectedNearest;
    }

    public void Dispose()
    {
        if (!disposed)
        {
            for (int i = BleDeviceHandler.STATION_FIRST; i <= BleDeviceHandler.STATION_LAST; i++)            
                positionUpdaters[i]?.Dispose();
            roomUpdater?.Dispose();
            AttributesChanged = null;
            StateChanged = null;
            GC.SuppressFinalize(this);
            disposed = true;
        }
    }

    

    
}
