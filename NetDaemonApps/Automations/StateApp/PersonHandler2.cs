using NetDaemon.Extensions.MqttEntityManager;
using NetDaemonApps.Infrastructure.Automation;
using System.Globalization;
using System.Threading.Tasks;

namespace NetDaemonApps.Automations.StateApp;

internal class PersonHandler2 : AutomationHandler, IAsyncInitializable
{
    readonly IMqttEntityManager mqttEntityManager;
    readonly PersonEntity person;
    readonly IHaContext haContext;
    readonly IScheduler scheduler;

    SensorEntity? state;
    NumberEntity? arrivedThreshold;
    NumberEntity? leftThreshold;
    NumberEntity? awakeThreshold;
    NumberEntity? asleepThreshold;
    NumberEntity? directionThreshold;
    NumberEntity? aroundThreshold;
    NumberEntity? vacationThreshold;
    
    readonly ProximityEntity proximity;
    readonly ZoneEntity work;
    readonly ZoneEntity school;

    string? personName =>
        person.Attributes?.FriendlyName ?? personId.Prettify();

    string personId =>
        person.EntityId.Substring(person.EntityId.IndexOf('.') + 1);

    IDisposable? arrivedScheduler;
    IDisposable? leftScheduler;
    IDisposable? vacationScheduler;

    PersonHandler2(string id, string name, PersonEntity person, IHaContext haContext, IMqttEntityManager mqttEntityManager, IScheduler scheduler)
        : base(id, name)
    {
        this.person = person;
        this.mqttEntityManager = mqttEntityManager;
        this.haContext = haContext;

        proximity = new ProximityEntity(haContext, "proximity.home_" + id);

        var allEntities = haContext.GetAllEntities().Select(s => s.EntityId);
        var workZone = allEntities.FirstOrDefault(e => e.StartsWith("zone.work_" + id));
        var schoolZone = allEntities.FirstOrDefault(e => e.StartsWith("zone.school_" + id));

        if (!String.IsNullOrEmpty(workZone))
            workZone = workZone.Substring(6);
        if (!String.IsNullOrEmpty(schoolZone))
            schoolZone = schoolZone.Substring(6);

        if (!String.IsNullOrEmpty(workZone))
        {
            person.StateChanges()
                .Where(s => s.New?.State == workZone)
                .Subscribe(_ => SetState(PersonState.AwayWork));
            person.StateChanges()
                .Where(s => s.Old?.State == workZone && !s.New.IsHome())
                .Subscribe(_ => SetState(PersonState.AwaySchool));
        }
        
        if (!String.IsNullOrEmpty(schoolZone))
        {
            person.StateChanges()
                .Where(s => s.New?.State == schoolZone)
                .Subscribe(_ => SetState(PersonState.AwaySchool));
            person.StateChanges()
                .Where(s => s.Old?.State == schoolZone && !s.New.IsHome())
                .Subscribe(_ => SetState(PersonState.Away));
        }

        //proximity.StateAllChanges()
        //   .Subscribe(_ => HandleState());


    }

    private void SetState(PersonState state)
    {
        throw new NotImplementedException();
    }

    public async Task InitializeAsync(CancellationToken cancellationToken)
    {
        state = await mqttEntityManager.RequiresSensorAsync(haContext, $"sensor.{personId}_extended_state",
             new EntityCreationOptions()
             {
                 Name = $"{personName} State",
                 Persist = true,
             },
             new MqttSensorAttributes()
             {
                 Icon = "mdi:account",
             });

        arrivedThreshold = await mqttEntityManager.RequiresNumberAsync(haContext, "number.state_arrived_threshold",
             new EntityCreationOptions()
             {
                 Name = "State Arrived Threshold",
                 Persist = true,
             },
             new MqttNumberAttributes()
             {
                 Icon = "mdi:account-arrow-left",
                 Min = 1,
                 Max = 60,
                 UnitOfMeasurement = "min"
             });

        leftThreshold = await mqttEntityManager.RequiresNumberAsync(haContext, "number.state_left_threshold",
             new EntityCreationOptions()
             {
                 Name = "State Left Threshold",
                 Persist = true,
             },
             new MqttNumberAttributes()
             {
                 Icon = "mdi:account-arrow-right",
                 Min = 1,
                 Max = 60,
                 UnitOfMeasurement = "min"
             });

        awakeThreshold = await mqttEntityManager.RequiresNumberAsync(haContext, "number.state_awake_threshold",
             new EntityCreationOptions()
             {
                 Name = "State Awake Threshold",
                 Persist = true,
             },
             new MqttNumberAttributes()
             {
                 Icon = "mdi:sleep-off",
                 Min = 1,
                 Max = 60,
                 UnitOfMeasurement = "min"
             });

        asleepThreshold = await mqttEntityManager.RequiresNumberAsync(haContext, "number.state_asleep_threshold",
             new EntityCreationOptions()
             {
                 Name = "State Asleep Threshold",
                 Persist = true,
             },
             new MqttNumberAttributes()
             {
                 Icon = "mdi:sleep",
                 Min = 1,
                 Max = 60,
                 UnitOfMeasurement = "min"
             });

        directionThreshold = await mqttEntityManager.RequiresNumberAsync(haContext, "number.state_direction_threshold",
             new EntityCreationOptions()
             {
                 Name = "State Direction Threshold",
                 Persist = true,
             },
             new MqttNumberAttributes()
             {
                 Icon = "mdi:map-marker-account",
                 Min = 0,
                 Max = 100,
                 UnitOfMeasurement = "km"
             });

        aroundThreshold = await mqttEntityManager.RequiresNumberAsync(haContext, "number.state_around_threshold",
             new EntityCreationOptions()
             {
                 Name = "State Around Threshold",
                 Persist = true,
             },
             new MqttNumberAttributes()
             {
                 Icon = "mdi:account-arrow-down",
                 Min = 0,
                 Max = 100,
                 UnitOfMeasurement = "km"
             });

        aroundThreshold = await mqttEntityManager.RequiresNumberAsync(haContext, "number.state_vacation_threshold",
             new EntityCreationOptions()
             {
                 Name = "State Vacation Threshold",
                 Persist = true,
             },
             new MqttNumberAttributes()
             {
                 Icon = "mdi:account-arrow-down",
                 Min = 0,
                 Max = 100,
                 UnitOfMeasurement = "km"
             });

        person.StateChanges()
            .Where(s => s.New.IsHome())
            .Subscribe(_ =>
            {
                SetState(PersonState.JustArrived);
                arrivedScheduler?.Dispose();
                arrivedScheduler = scheduler.Schedule(TimeSpan.FromMinutes(arrivedThreshold?.State ?? 10),
                    _ => SetState(PersonState.HomeAwake));
            });

        person.StateChanges()
            .Where(s => s.Old.IsHome())
            .Subscribe(_ =>
            {
                SetState(PersonState.JustLeft);
                leftScheduler?.Dispose();
                leftScheduler = scheduler.Schedule(TimeSpan.FromMinutes(leftThreshold?.State ?? 10),
                    _ => SetState(PersonState.HomeAwake));
            });

        vacationScheduler = person.StateChanges()
            .Where(s => s.New.IsNotHome())
            .Throttle(TimeSpan.FromHours(vacationThreshold?.State ?? 48))
            .Subscribe(_ => SetState(PersonState.AwayVacation));

        

 
        

    }
}
