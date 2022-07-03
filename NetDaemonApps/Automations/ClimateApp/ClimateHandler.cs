using System.Threading.Tasks;

namespace NetDaemonApps.Automations.ClimateApp;

public class ClimateHandler : AvailableEnabledHandler, IAsyncInitializable
{

    private ClimateEntity climate;
    private InputNumberEntity target;
    private ILogger logger;
    private INotificationService notify;


    public ClimateHandler(ClimateEntity entity, ILogger logger, INotificationService notify, 
        InputNumberEntity target, BinarySensorEntity door, BinarySensorEntity occupancy,
        SensorEntity season, InputBooleanEntity enabledToggle)
        : base(entity, enabledToggle)
    {
        this.climate = entity;
        this.target = target;
        this.logger = logger;
        this.notify = notify;



        climate.StateAllChanges()
            .WhenStateIsFor(ac => ac.GetCurrentTemperature() > target.State, TimeSpan.FromMinutes(5))
            .SubscribeAsync(async _ => { tooHot = true; await HandleAsync(); });

        climate.StateAllChanges()
            .WhenStateIsFor(ac => ac.GetCurrentTemperature() < target.State, TimeSpan.FromMinutes(5))
            .SubscribeAsync(async _ => { tooHot = false; await HandleAsync(); });

        target.StateChanges()
            .SubscribeAsync(async _ => { tooHot = climate.GetCurrentTemperature() > target.State; await HandleAsync(); }) ;

        door.StateChanges()
            .WhenStateIsFor(door => door.IsOpen(), TimeSpan.FromSeconds(30))
            .SubscribeAsync(async _ => { doorClosed = false; await HandleAsync(); });

        door.StateChanges()
            .WhenStateIsFor(door => door.IsClosed(), TimeSpan.FromSeconds(30))
            .SubscribeAsync(async _ => { doorClosed = true; await HandleAsync(); });

        occupancy.StateChanges()
            .WhenStateIsFor(occ => occ.IsDetected(), TimeSpan.FromSeconds(30))
            .SubscribeAsync(async _ => { occupied = true; await HandleAsync(); });

        occupancy.StateChanges()
            .WhenStateIsFor(occ => occ.IsCleared(), TimeSpan.FromSeconds(30))
            .SubscribeAsync(async _ => { occupied = false; await HandleAsync(); });

        season.StateChanges()
            .Where(s => s.New.IsSummer() || s.New.IsSpring() || s.New.IsAutumn())
            .SubscribeAsync(async _ => { summer = true; await HandleAsync(); });

        season.StateChanges()
            .Where(s => s.New.IsWinter())
            .SubscribeAsync(async _ => { summer = false; await HandleAsync(); });


        doorClosed = door.IsClosed();
        tooHot = climate.GetCurrentTemperature() > target.State;
        summer = season.IsSummer() || season.IsSpring() || season.IsAutumn();
        occupied = occupancy.IsDetected();


    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        await HandleAsync();
    }

    bool doorClosed;
    bool tooHot;
    bool summer;
    bool occupied;


    async Task HandleAsync()
    {

        logger.LogDebug($"{ climate.Attributes?.FriendlyName } - on: {!climate.IsOff()}, avail: {IsAvailable}, enabled: {IsEnabled}, door: {doorClosed}, occ: {occupied}, hot: {tooHot}");

        if (IsAvailable && IsEnabled)
        {
            if (!doorClosed || !tooHot || !summer || !occupied)
                Stop();
            else if (doorClosed && tooHot && summer && occupied)
                await StartAsync();
        }
    }

    async Task StartAsync()
    {
        if (climate.IsOff())
        {
            logger.LogInformation($"{climate.Attributes?.FriendlyName} - turning on");
            climate.TurnOn();
            notify.Send(ChannelTarget.State, String.Format(notify.GetMessage("climate_on")!, climate.Attributes?.FriendlyName));
            await Task.Delay(500);
        }

        if (!climate.IsOnAuto() && !climate.IsOnCool())
        {
            logger.LogInformation($"{climate.Attributes?.FriendlyName} - setting on 'auto' because it was set on '{ climate.State }'");
            climate.SetHvacMode("auto");
            await Task.Delay(500);
        }

        if (climate.GetTemperature() != target.State)
        {
            logger.LogInformation($"{climate.Attributes?.FriendlyName} - setting on { target.State }°C because it was set on { climate.GetTemperature() }°C");
            climate.SetTemperature(target.State);
        }

    }

    void Stop()
    {
        if (!climate.IsOff())
        {
            logger.LogInformation($"{climate.Area} - {climate.Attributes?.FriendlyName} -  turning off");
            climate.TurnOff();
            notify.Send(ChannelTarget.State, String.Format(notify.GetMessage("climate_off")!, climate.Attributes?.FriendlyName));
        }
    }

    protected override async void OnAvailable(bool value)
    {
        if (value)
           await HandleAsync();
    }

    protected override async void OnEnabled(bool value)
    {
        if (value)
            await HandleAsync();
    }

    
}

