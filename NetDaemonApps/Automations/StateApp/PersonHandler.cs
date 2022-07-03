
using NetDaemonApps.PersonState;

namespace NetDaemonApps.Automations.StateApp;

public class PersonHandler
{

    readonly ILogger logger;
    readonly IEntities entities;
    readonly IServices services;
    readonly InputSelectEntity personState;
    readonly ProximityEntity proximity;
    readonly PersonEntity person;
    readonly string? workZone;
    readonly string? schoolZone;

    IDisposable? vacationScheduler;

    InputNumberEntity proximityThreshold
        => entities.InputNumber.StateComingThreshold;
    InputNumberEntity arrivedThreshold
        => entities.InputNumber.StateArrivedThreshold;
    InputNumberEntity leftThreshold
        => entities.InputNumber.StateLeftThreshold;
    InputNumberEntity vacationThreshold
        => entities.InputNumber.StateVacationThreshold;

    INotificationService notify;

    public PersonHandler(PersonEntity person, IHaContext context, IEntities entities, IServices services, INotificationService notificationService,
        ILogger logger, IScheduler scheduler)
    {

        this.logger = logger;
        this.services = services;
        this.person = person;
        this.entities = entities;
        this.notify = notificationService;

        var id = person.EntityId.Substring(person.EntityId.IndexOf('.') + 1);
        personState = new InputSelectEntity(context, "input_select." + id + "_state");
        proximity = new ProximityEntity(context, "proximity.home_" + id);
        var allEntities = context.GetAllEntities().Select(s => s.EntityId);
        workZone = allEntities.FirstOrDefault(e => e.StartsWith("zone.work_" + id));
        schoolZone = allEntities.FirstOrDefault(e => e.StartsWith("zone.school_" + id));

        if (!String.IsNullOrEmpty(workZone))
            workZone = workZone.Substring(6);
        if (!String.IsNullOrEmpty(schoolZone))
            schoolZone = schoolZone.Substring(6);

        //handle work zone;
        if (!String.IsNullOrEmpty(workZone))
        {
            person.StateChanges()
                .Where(s => s.New?.State == workZone)
                .Subscribe(_ => SetState("at_work"));
            person.StateChanges()
                .Where(s => s.Old?.State == workZone && !s.New.IsHome())
                .Subscribe(_ => SetState("away"));
        }

        //handle school zone
        if (!String.IsNullOrEmpty(schoolZone))
        {
            person.StateChanges()
                .Where(s => s.New?.State == schoolZone)
                .Subscribe(_ => SetState("at_school"));
            person.StateChanges()
                .Where(s => s.Old?.State == schoolZone && !s.New.IsHome())
                .Subscribe(_ => SetState("away"));
        }


        // Handle left/arrived
        person.StateChanges()
            .Where(s => s.New.IsHome())
            .Subscribe(_ =>
            {
                SetState("just_arrived");
                scheduler.Schedule(TimeSpan.FromMinutes(arrivedThreshold.State ?? 15), _ =>
                {
                    if (personState.IsJustArrived())
                        DetectState();
                });
            });

        person.StateChanges()
            .Where(s => s.Old.IsHome())
            .Subscribe(_ =>
            {
                SetState("just_left");
                scheduler.Schedule(TimeSpan.FromMinutes(leftThreshold.State ?? 15), _ =>
                {
                    if (personState.IsJustLeft())
                        DetectState();
                });
            });


        //Handle vacation
        vacationScheduler = person.StateChanges()
            .Where(s => s.New.IsNotHome())
            .Throttle(TimeSpan.FromHours(vacationThreshold.State ?? 48))
            .Subscribe(_ => SetState("on_vacation"));

        vacationThreshold.StateChanges()
            .Subscribe(_ =>
            {
                vacationScheduler?.Dispose();
                if (person.IsNotHome())
                {
                    if ((DateTime.Now - (person.EntityState?.LastChanged ?? DateTime.Now)).TotalHours >= vacationThreshold.State)
                        SetState("on_vacation");
                }    
                vacationScheduler = person.StateChanges()
                    .Where(s => s.New.IsNotHome())
                    .Throttle(TimeSpan.FromHours(vacationThreshold.State ?? 48))
                    .Subscribe(_ => SetState("on_vacation"));
            });

        //handle leaving/coming
        proximity.StateAllChanges()
            .Where(p => p.New.IsTowards())
            .Throttle(TimeSpan.FromMinutes(1))
            .Subscribe(_ =>
            {
                if (proximity.AsNumeric().State <= proximityThreshold.State && !person.IsHome())
                    SetState("coming");
            });
        proximity.StateAllChanges()
            .Where(p => p.New.IsAwayFrom())
            .Throttle(TimeSpan.FromMinutes(1))
            .Subscribe(_ =>
            {
                if (proximity.AsNumeric().State <= proximityThreshold.State && !person.IsHome() && !personState.IsJustLeft())
                    SetState("leaving");
            });

        proximityThreshold.StateChanges()
           .Subscribe(_ =>
           {
               
               if (!person.IsHome())
               {
                   if (proximity.IsTowards() && proximity.AsNumeric().State <= proximityThreshold.State)
                       SetState("coming");
                   else if (proximity.IsAwayFrom() && proximity.AsNumeric().State <= proximityThreshold.State && !personState.IsJustLeft())
                       SetState("leaving");
               }
           });

        DetectState();
    }


    void DetectState()
    {
        if (person.IsHome())
            SetState("home");
        else if (!String.IsNullOrEmpty(workZone) && person.State == workZone)
            SetState("work");
        else if (!String.IsNullOrEmpty(schoolZone) && person.State == schoolZone)
            SetState("school");
        else
        {
            if (proximity.IsTowards() && proximity.AsNumeric().State <= proximityThreshold.State)
                SetState("coming");
            else if (proximity.IsAwayFrom() && proximity.AsNumeric().State <= proximityThreshold.State)
                SetState("leaving");
        }


    }

    void SetState(string s)
    {
        if (personState.State != s)
        {
            logger.LogInformation($"{ person.Attributes?.FriendlyName } state changed from {personState.State} to {s}");
            notify.Send(ChannelTarget.State, String.Format(notify.GetMessage(s)!, person.Attributes?.FriendlyName));            
            personState.SelectOption(s);
        }
    }

   
}