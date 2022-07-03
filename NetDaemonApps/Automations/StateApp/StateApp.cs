using System.IO;
using System.Text.Json;

namespace NetDaemonApps.Automations.StateApp;

//[Focus]
[NetDaemonApp]
public class StateApp
{
    readonly IEntities entities;
    readonly IServices services;

    readonly IList<PersonHandler> personHandlers = new List<PersonHandler>();
    readonly HouseHandler houseHandler;
 
    public StateApp(IHaContext haContext, ILogger<StateApp> logger, IScheduler scheduler, INotificationService notificationService)
    {
        this.entities = new Entities(haContext);
        this.services = new Services(haContext);

        personHandlers.Add(new PersonHandler(entities.Person.Razvan, haContext, entities, services, notificationService, logger, scheduler));
        personHandlers.Add(new PersonHandler(entities.Person.Nico, haContext, entities, services, notificationService, logger, scheduler));
        personHandlers.Add(new PersonHandler(entities.Person.Rares, haContext, entities, services, notificationService, logger, scheduler));


        houseHandler = new HouseHandler(haContext, entities, services, notificationService, logger, scheduler);

        logger.LogInformation("Succesfully subscribed to events");

    }

        

      





}

