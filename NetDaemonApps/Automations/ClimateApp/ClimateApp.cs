
using NetDaemon.AppModel;

namespace NetDaemonApps.Automations.ClimateApp;

[NetDaemonApp]
public class ClimateApp
{
    readonly IList<ClimateHandler> handlers = new List<ClimateHandler>();

    public ClimateApp(IHaContext haContext, ILogger<ClimateApp> logger, INotificationService notificationService)
    {
        var entities = new Entities(haContext);

        handlers.Add(new ClimateHandler(
                entities.Climate.BedroomAc, logger, notificationService,
                entities.InputNumber.BedroomAcAutomationTemperature,
                entities.BinarySensor.BedroomDoorContact,
                entities.BinarySensor.BedroomOccupancy,
                entities.Sensor.Season,
                entities.InputBoolean.BedroomAcAutomation));

        handlers.Add(new ClimateHandler(
                entities.Climate.OfficeAc, logger, notificationService,
                entities.InputNumber.OfficeAcAutomationTemperature,
                entities.BinarySensor.OfficeDoorContact,
                entities.BinarySensor.OfficeOccupancy,
                entities.Sensor.Season,
                entities.InputBoolean.OfficeAcAutomation));

        handlers.Add(new ClimateHandler(
                entities.Climate.LivingRoomAc, logger, notificationService,
                entities.InputNumber.LivingRoomAcAutomationTemperature,
                entities.BinarySensor.LivingRoomDoorContact,
                entities.BinarySensor.LivingRoomOccupancy,
                entities.Sensor.Season,
                entities.InputBoolean.LivingRoomAcAutomation));

        handlers.Add(new ClimateHandler(
                entities.Climate.ChildRoomAc, logger, notificationService,
                entities.InputNumber.ChildRoomAcAutomationTemperature,
                entities.BinarySensor.ChildRoomDoorContact,
                entities.BinarySensor.ChildRoomOccupancy,
                entities.Sensor.Season,
                entities.InputBoolean.ChildRoomAcAutomation));



        logger.LogInformation("Succesfully subscribed to events");

    }
}

