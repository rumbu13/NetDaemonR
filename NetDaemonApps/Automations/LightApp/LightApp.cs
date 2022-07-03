
using NetDaemon.AppModel;

namespace NetDaemonApps.Automations.LightApp;

[NetDaemonApp]
public class LightApp
{
    private readonly IEntities entities;

    IList<LightSwitchHandler> lightSwitches = new List<LightSwitchHandler>();
    IList<RGBHandler> rgbLights = new List<RGBHandler>();

    public LightApp(IHaContext haContext, ILogger<LightApp> logger, IScheduler scheduler, INotificationService notificationService)
    {
        this.entities = new Entities(haContext);

        lightSwitches.Add(new LightSwitchHandler(entities.Light.OfficeSwitch, haContext, scheduler,
            notificationService, entities.InputBoolean.OfficeLightAutomation));

        lightSwitches.Add(new LightSwitchHandler(entities.Light.KitchenSwitch, haContext, scheduler,
            notificationService, entities.InputBoolean.KitchenLightAutomation));

        rgbLights.Add(new RGBHandler(entities.Light.BedroomRgb, haContext, entities, logger, notificationService, entities.InputBoolean.BedroomRgbAutomation));

        rgbLights.Add(new RGBHandler(entities.Light.LivingRoomRgb, haContext, entities, logger, notificationService, entities.InputBoolean.LivingRoomRgbAutomation));

        rgbLights.Add(new RGBHandler(entities.Light.ChildRoomRgb, haContext, entities, logger, notificationService, entities.InputBoolean.ChildRoomRgbAutomation));


        logger.LogInformation("Succesfully subscribed to events");

    }

        

}

