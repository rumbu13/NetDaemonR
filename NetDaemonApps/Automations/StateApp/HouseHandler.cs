
using System.IO;
using System.Text.Json;

namespace NetDaemonApps.Automations.StateApp;

public class HouseHandler
{

    readonly IEntities entities;
    readonly ILogger logger;
    readonly IServices services;
    readonly List<PersonEntity> persons = new();
    readonly List<PersonEntity> guests = new();
    readonly List<InputSelectEntity> personStates = new();
    

    InputSelectEntity house
        => entities.InputSelect.HouseState;
    InputBooleanEntity guestMode
        => entities.InputBoolean.GuestMode;
    BinarySensorEntity allOccupancy
        => entities.BinarySensor.HouseOccupancy;

    INotificationService notify;

    public HouseHandler(IHaContext context, IEntities entities, IServices services, INotificationService notificationService,
        ILogger logger, IScheduler scheduler)

    {
        this.services = services;
        this.logger = logger;
        this.entities = entities;

        this.notify = notificationService;

        persons.Add(entities.Person.Razvan);
        persons.Add(entities.Person.Nico);
        persons.Add(entities.Person.Rares);

        personStates.Add(entities.InputSelect.RazvanState);
        personStates.Add(entities.InputSelect.NicoState);
        personStates.Add(entities.InputSelect.RaresState);

        guests.Add(entities.Person.GuestLuca);


        persons.ForEach(p =>
        {
            p.StateChanges()
               .Where(p => p.New.IsHome())
               .Subscribe(_ => SetState("awake"));

            p.StateChanges()
                .Where(p => !p.New.IsHome())
                .Subscribe(_ =>
                {
                    if (persons.Any(p => p.IsHome()) || guestMode.IsOn())
                        SetState("awake");
                    else
                        SetState("away");
                });
        });

        guests.ForEach(g =>
        {
            g.StateChanges()
            .Where(g => g.New.IsHome())
            .Subscribe(_ => SetGuestMode(guests.Any(h => h.IsHome())));                
        });

      
        allOccupancy.StateChanges()
            .Where(h => h.New.IsDetected())
            .Subscribe(_ =>
            {
                scheduler.Schedule(TimeSpan.FromMinutes(entities.InputNumber.StateAwakeThreshold.State ?? 10), () =>
                {
                    if (house.State == "asleep" && allOccupancy.IsDetected())
                        SetState("awake");
                });
            });

        allOccupancy.StateChanges()
            .Where(h => h.New.IsCleared())
            .Subscribe(_ =>
            {
                scheduler.Schedule(TimeSpan.FromMinutes(entities.InputNumber.StateSleepThreshold.State ?? 10), () =>
                {
                    if (house.State == "awake" && allOccupancy.IsCleared())
                        SetState("asleep");
                });
            });

        guestMode.StateChanges()
            .Where(h => h.New.IsOn())
            .Subscribe(_ => SetState(allOccupancy.IsDetected() ? "awake": "asleep"));
        guestMode.StateChanges()
            .Where(h => h.New.IsOff())
            .Subscribe(_ => DetectState());

        foreach (var person in personStates)
        {
            person.StateChanges()
                .Where(p => p.New?.State == "vacation")
                .Subscribe(_ => DetectState());            
        }

        DetectState();
    }

    private void SetGuestMode(bool value)
    {
        if (value != guestMode.IsOn())
        {
            logger.LogInformation(value ? $"Guest mode auto enabled" : $"Guest mode auto disabled");
            if (value)
                guestMode.TurnOn();
            else
                guestMode.TurnOff();
            //services.Notify.Homeassistant(messages["guest_" + (value ? "on" : "off")].Random()!, target: new[] { Discord.State });
        }
    }

    void SetState(string s)
    {
        if (house.State != s)
        {
            logger.LogInformation($"House state changed from {house.State} to {s}");
            house.SelectOption(s);
            notify.Send(ChannelTarget.State, notify.GetMessage("house_" + s)!);
        }
    }

    void DetectState()
    {
        if (persons.Any(p => p.IsHome() || guestMode.IsOn()))
            SetState(allOccupancy.IsDetected() ? "awake" : "asleep");
        else if (personStates.All(p => p.State == "vacation") && guestMode.IsOff())
            SetState("vacation");
        else 
            SetState("away");


    }

}
