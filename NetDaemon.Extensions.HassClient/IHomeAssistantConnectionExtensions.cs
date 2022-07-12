using NetDaemon.Client;
using NetDaemon.Client.HomeAssistant.Extensions;
using NetDaemon.Extensions.HassClient.Internal.Commands;
using System.Threading.Tasks;
using NetDaemon.Extensions.HassClient.Models;
using NetDaemon.Client.HomeAssistant.Model;

namespace NetDaemon.Extensions.HassClient;

public static class IHomeAssistantConnectionExtensions
{

    #region Area

    /// <summary>
    /// Gets a list of areas
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<Models.HassArea>?> GetAreasAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassAreaList, IReadOnlyCollection<Models.HassArea>>(
            new HassAreaList(), cancellationToken);


    /// <summary>
    /// Creates a new area
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name">Area name</param>
    /// <param name="picture">Associated picture</param>
    /// <param name="cancellationToken"></param>
    /// <returns>The newly created area</returns>
    public static Task<Models.HassArea?> CreateAreaAsync(this IHomeAssistantConnection connection, string name, 
        string? picture = default, CancellationToken cancellationToken = default) 
    
        => connection.SendCommandAndReturnResponseAsync<HassAreaCreate, Models.HassArea>(
            new HassAreaCreate(name, picture), cancellationToken);
    
    /// <summary>
    /// Deletes the specified area
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>always null</returns>
    public static Task DeleteAreaAsync(this IHomeAssistantConnection connection, string id, 
        CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassAreaDelete, Object>(
            new HassAreaDelete(id), cancellationToken);
    

    /// <summary>
    /// Updates the specified area
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="picture"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Models.HassArea?> UpdateAreaAsync(this IHomeAssistantConnection connection, string id, string? name, 
        string? picture = default, CancellationToken cancellationToken = default)
   
        => connection.SendCommandAndReturnResponseAsync<HassAreaUpdate, Models.HassArea>(
            new HassAreaUpdate(id, name, picture), cancellationToken);

    #endregion

    #region Counter

    /// <summary>
    /// Gets a list of counter helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassCounter>?> GetCountersAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)
        
        => connection.SendCommandAndReturnResponseAsync<HassCounterList, IReadOnlyCollection<HassCounter>>(
            new HassCounterList(), cancellationToken);
    
    /// <summary>
    /// reates a new counter helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="initialValue"></param>
    /// <param name="minimum"></param>
    /// <param name="maximum"></param>
    /// <param name="restore">defaults to true if not specified</param>
    /// <param name="step">defaults to 1 if not specified</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassCounter?> CreateCounterAsync(this IHomeAssistantConnection connection, string name, 
        string? icon = default, int? initialValue = default, int? step = default, int? minimum = default,
        int? maximum = default, bool? restore = default, CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCounterCreate, HassCounter>(
            new HassCounterCreate(name, icon, initialValue, step, minimum, maximum, restore), cancellationToken);

    /// <summary>
    /// Updates the specified counter helper.
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="initialValue"></param>
    /// <param name="minimum"></param>
    /// <param name="maximum"></param>
    /// <param name="restore"></param>
    /// <param name="step"></param>
    /// <returns></returns>
    public static Task<HassCounter?> UpdateCounterAsync(this IHomeAssistantConnection connection, string id, string? name, 
        string? icon = default, int? initialValue = default, int? step = default, int? minimum = default, 
        int? maximum = default, bool? restore = default, CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCounterUpdate, HassCounter>(
             new HassCounterUpdate(id, name, icon, initialValue, step, minimum, maximum, restore), cancellationToken);

    /// <summary>
    /// Deletes the specified counter helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteCounterAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)
    
        => connection.SendCommandAndReturnResponseAsync<HassCounterDelete, Object>(
            new HassCounterDelete(id), cancellationToken);

    #endregion
    
    #region Device

    /// <summary>
    /// Gets a list of devices
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<Models.HassDevice>?> GetDevicesAsync(this IHomeAssistantConnection connection,
       CancellationToken cancellationToken = default)

       => connection.SendCommandAndReturnResponseAsync<HassDeviceList, IReadOnlyCollection<Models.HassDevice>>(
           new HassDeviceList(), cancellationToken);

    /// <summary>
    /// Updates the specified device
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="areaId"></param>
    /// <param name="nameByUser"></param>
    /// <param name="disabledBy"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Models.HassDevice?> UpdateDeviceAsync(this IHomeAssistantConnection connection, string id, 
        string? areaId = default, string? nameByUser = default, string? disabledBy = default,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDeviceUpdate, Models.HassDevice>(
            new HassDeviceUpdate(id, areaId, nameByUser, disabledBy), cancellationToken);

    /// <summary>
    /// Removes a configuration entry from the specified device
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="configEntryId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<Models.HassDevice?> DeleteDeviceConfigurationAsync(this IHomeAssistantConnection connection, string id,
        string configEntryId, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDeviceRemoveConfig, Models.HassDevice>(
            new HassDeviceRemoveConfig(id, configEntryId), cancellationToken);

    /// <summary>
    /// Gets a list of actions available for the specified device
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyList<HassDeviceAutomationAction>?> GetDeviceActionsAsync(this IHomeAssistantConnection connection, string id,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDeviceAutomationActionList, IReadOnlyList<HassDeviceAutomationAction>>(
            new HassDeviceAutomationActionList(id), cancellationToken);

    /// <summary>
    /// Gets a list of conditions available for the specified device
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyList<HassDeviceAutomationCondition>?> GetDeviceConditionsAsync(this IHomeAssistantConnection connection, string id,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDeviceAutomationConditionList, IReadOnlyList<HassDeviceAutomationCondition>>(
            new HassDeviceAutomationConditionList(id), cancellationToken);

    /// <summary>
    /// Gets a list of triggers available for the specified device
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyList<HassDeviceAutomationTrigger>?> GetDeviceTriggersAsync(this IHomeAssistantConnection connection, string id,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassDeviceAutomationTriggerList, IReadOnlyList<HassDeviceAutomationTrigger>>(
            new HassDeviceAutomationTriggerList(id), cancellationToken);

    /// <summary>
    /// Subscribes to receive notifications for the specified trigger
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="trigger"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static async Task<int> SubscribeDeviceTriggerAsync(this IHomeAssistantConnection connection, HassDeviceAutomationTrigger trigger,
       CancellationToken cancellationToken = default)
    {
        var cmd = new HassDeviceAutomationTriggerSubscribe(trigger);
        await connection.SendCommandAndReturnResponseAsync<HassDeviceAutomationTriggerSubscribe, Object>(
            cmd, cancellationToken).ConfigureAwait(false);
        return cmd.Id;
    }

    /// <summary>
    /// Unsubscribe from the specified subscription
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="subcriptionId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task UnsubscribeDeviceTriggerAsync(this IHomeAssistantConnection connection, int subcriptionId,
       CancellationToken cancellationToken = default)
     
       => connection.SendCommandAndReturnResponseAsync<HassDeviceAutomationTriggerUnsubscribe, Object>(
            new HassDeviceAutomationTriggerUnsubscribe(subcriptionId), cancellationToken);


    #endregion

    #region Entity

    /// <summary>
    /// Gets a list of entities
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<Models.HassEntity>?> GetEntitiesAsync(this IHomeAssistantConnection connection,
      CancellationToken cancellationToken = default)

      => connection.SendCommandAndReturnResponseAsync<HassEntityList, IReadOnlyCollection<Models.HassEntity>>(
          new HassEntityList(), cancellationToken);

    /// <summary>
    /// Gets extended information about the specified entity
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassEntityExtended?> GetEntityAsync(this IHomeAssistantConnection connection, string id,
      CancellationToken cancellationToken = default)

      => connection.SendCommandAndReturnResponseAsync<HassEntityGet, HassEntityExtended>(
          new HassEntityGet(id), cancellationToken);

    /// <summary>
    /// Deletes the specified entity
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task DeleteEntityAsync(this IHomeAssistantConnection connection, string id,
      CancellationToken cancellationToken = default)

      => connection.SendCommandAndReturnResponseAsync<HassEntityDelete, Object>(
          new HassEntityDelete(id), cancellationToken);

    /// <summary>
    /// Updates the specified sensor entity
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="deviceClass"></param>
    /// <param name="areaId"></param>
    /// <param name="disabledBy"></param>
    /// <param name="hiddenBy"></param>
    /// <param name="newEntityId"></param>
    /// <param name="optionsDomain"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassEntityExtended?> UpdateSensorEntityAsync(this IHomeAssistantConnection connection, 
        string id, string? name = default, string? icon = default, string? deviceClass = default, string? areaId = default,
        string? disabledBy = default, string? hiddenBy = default, string? newEntityId = default, 
        string? optionsDomain = default, string? unitOfMeasurement = default,
        CancellationToken cancellationToken = default)

      => connection.SendCommandAndReturnResponseAsync<HassEntityUpdateSensor, HassEntityExtended>(
          new HassEntityUpdateSensor(id, name, icon, deviceClass, areaId, disabledBy, hiddenBy, newEntityId, 
              optionsDomain, unitOfMeasurement), cancellationToken);

    /// <summary>
    /// Updates the specified weather entity
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="deviceClass"></param>
    /// <param name="areaId"></param>
    /// <param name="disabledBy"></param>
    /// <param name="hiddenBy"></param>
    /// <param name="newEntityId"></param>
    /// <param name="optionsDomain"></param>
    /// <param name="precipitationUnit"></param>
    /// <param name="pressureUnit"></param>
    /// <param name="temperatureUnit"></param>
    /// <param name="visibilityUnit"></param>
    /// <param name="windSpeedUnit"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassEntityExtended?> UpdateWeatherEntityAsync(this IHomeAssistantConnection connection,
        string id, string? name = default, string? icon = default, string? deviceClass = default, string? areaId = default,
        string? disabledBy = default, string? hiddenBy = default, string? newEntityId = default,
        string? optionsDomain = default, string? precipitationUnit = default, string? pressureUnit = default, 
        string? temperatureUnit = default, string? visibilityUnit = default, string? windSpeedUnit = default,
        CancellationToken cancellationToken = default)

      => connection.SendCommandAndReturnResponseAsync<HassEntityUpdateWeather, HassEntityExtended>(
          new HassEntityUpdateWeather(id, name, icon, deviceClass, areaId, disabledBy, hiddenBy, newEntityId,
              optionsDomain, precipitationUnit, pressureUnit, temperatureUnit, visibilityUnit, windSpeedUnit), 
          cancellationToken);

    #endregion

    #region Image

    /// <summary>
    /// Gets a list of image helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassImage>?> GetImagesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassImageList, IReadOnlyCollection<HassImage>>(
            new HassImageList(), cancellationToken);

    /// <summary>
    /// Creates a new image helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="file"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassImage?> CreateImageAsync(this IHomeAssistantConnection connection, string file,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassImageCreate, HassImage>(
            new HassImageCreate(file), cancellationToken);

    /// <summary>
    /// Updates the specified image helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassImage?> UpdateImageAsync(this IHomeAssistantConnection connection, string id, string? name,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassImageUpdate, HassImage>(
             new HassImageUpdate(id, name), cancellationToken);

    /// <summary>
    /// Deletes the specified image helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteImageAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassImageDelete, Object>(
            new HassImageDelete(id), cancellationToken);

    #endregion

    #region InputBoolean

    /// <summary>
    /// Gets a list of input_boolean helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputBoolean>?> GetInputBooleansAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputBooleanList, IReadOnlyCollection<HassInputBoolean>>(
            new HassInputBooleanList(), cancellationToken);

    /// <summary>
    /// Creates a new input_boolean helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputBoolean?> CreateInputBooleanAsync(this IHomeAssistantConnection connection, string name, 
        bool? initialValue = default, string ? icon = default, 
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputBooleanCreate, HassInputBoolean>(
            new HassInputBooleanCreate(name, initialValue, icon), cancellationToken);

    /// <summary>
    /// Updates the specified input_boolean helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputBoolean?> UpdateInputBooleanAsync(this IHomeAssistantConnection connection, string id, 
        string? name, bool ? initialValue = default, string? icon = default,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputBooleanUpdate, HassInputBoolean>(
             new HassInputBooleanUpdate(id, name, initialValue, icon), cancellationToken);

    /// <summary>
    /// Deletes the specified input_boolean helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputBooleanAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputBooleanDelete, Object>(
            new HassInputBooleanDelete(id), cancellationToken);

    #endregion

    #region InputButton

    /// <summary>
    /// Gets a list of input_button helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputButton>?> GetInputButtonsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputButtonList, IReadOnlyCollection<HassInputButton>>(
            new HassInputButtonList(), cancellationToken);

    /// <summary>
    /// Creates a new input_button helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputButton?> CreateInputButtonAsync(this IHomeAssistantConnection connection, string name,
       string? icon = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputButtonCreate, HassInputButton>(
            new HassInputButtonCreate(name, icon), cancellationToken);

    /// <summary>
    /// Updates the specified input_button helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputButton?> UpdateInputButtonAsync(this IHomeAssistantConnection connection, string id,
        string? name, string? icon = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputButtonUpdate, HassInputButton>(
             new HassInputButtonUpdate(id, name, icon), cancellationToken);

    /// <summary>
    /// Deletes the specified input_button helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputButtonAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputButtonDelete, Object>(
            new HassInputButtonDelete(id), cancellationToken);

    #endregion

    #region InputDateTime

    /// <summary>
    /// Gets a list of input_datetime helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputDateTime>?> GetInputDateTimesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputDateTimeList, IReadOnlyCollection<HassInputDateTime>>(
            new HassInputDateTimeList(), cancellationToken);

    /// <summary>
    /// Creates a new input_datetime helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="hasDate"></param>
    /// <param name="hasTime"></param>
    /// <param name="icon"></param>
    /// <param name="initialValue"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputDateTime?> CreateInputDateTimeAsync(this IHomeAssistantConnection connection, string name,
       bool? hasDate = default, bool? hasTime = default, string? icon = default, DateTime? initialValue = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputDateTimeCreate, HassInputDateTime>(
            new HassInputDateTimeCreate(name, hasDate, hasTime, icon, initialValue), cancellationToken);

    /// <summary>
    /// Updates the specified input_datetime helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="hasDate"></param>
    /// <param name="hasTime"></param>
    /// <param name="icon"></param>
    /// <param name="initialValue"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputDateTime?> UpdateInputDateTimeAsync(this IHomeAssistantConnection connection, string id,
       string? name, bool? hasDate = default, bool? hasTime = default, string? icon = default, DateTime? initialValue = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputDateTimeUpdate, HassInputDateTime>(
             new HassInputDateTimeUpdate(id, name, hasDate, hasTime, icon, initialValue), cancellationToken);

    /// <summary>
    /// Deletes the specified input_datetime helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputDateTimeAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputDateTimeDelete, Object>(
            new HassInputDateTimeDelete(id), cancellationToken);

    #endregion

    #region InputNumber

    /// <summary>
    /// Gets a list of input_number helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputNumber>?> GetInputNumbersAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputNumberList, IReadOnlyCollection<HassInputNumber>>(
            new HassInputNumberList(), cancellationToken);

    /// <summary>
    /// Creates a new input_number helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="initialValue"></param>
    /// <param name="step"></param>
    /// <param name="icon"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputNumber?> CreateInputNumberAsync(this IHomeAssistantConnection connection, string name,
        double min, double max, double? initialValue = default, double? step = default, string? icon = default, 
        string? unitOfMeasurement = default, HassInputNumberMode? mode = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputNumberCreate, HassInputNumber>(
            new HassInputNumberCreate(name, min, max, initialValue, step, icon, unitOfMeasurement, mode), cancellationToken);

    /// <summary>
    /// Updates the specified input_number helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <param name="initialValue"></param>
    /// <param name="step"></param>
    /// <param name="icon"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputNumber?> UpdateInputNumberAsync(this IHomeAssistantConnection connection, string id,
        string? name = default, double? min = default, double? max = default, double? initialValue = default, 
        double? step = default, string? icon = default, string? unitOfMeasurement = default, 
        HassInputNumberMode? mode = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputNumberUpdate, HassInputNumber>(
            new HassInputNumberUpdate(id, name, min, max, initialValue, step, icon, unitOfMeasurement, mode), cancellationToken);

    /// <summary>
    /// Deletes the specified input_number helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputNumberAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputNumberDelete, Object>(
            new HassInputNumberDelete(id), cancellationToken);

    #endregion

    #region InputSelect

    /// <summary>
    /// Gets a list of input_select helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputSelect>?> GetInputSelectsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputSelectList, IReadOnlyCollection<HassInputSelect>>(
            new HassInputSelectList(), cancellationToken);

    /// <summary>
    /// Creates a new input_select helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="options"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputSelect?> CreateInputSelectAsync(this IHomeAssistantConnection connection, string name,
       IEnumerable<string> options, string? initialValue = default, string? icon = default, 
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputSelectCreate, HassInputSelect>(
            new HassInputSelectCreate(name, options, initialValue, icon), cancellationToken);

    /// <summary>
    /// Updates the specified input_select helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="options"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputSelect?> UpdateInputSelectAsync(this IHomeAssistantConnection connection, string id,
         string? name, IEnumerable<string> options, string? initialValue = default, string? icon = default,
         CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputSelectUpdate, HassInputSelect>(
             new HassInputSelectUpdate(id, name, options, initialValue, icon), cancellationToken);

    /// <summary>
    /// Deletes the specified input_select helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputSelectAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputSelectDelete, Object>(
            new HassInputSelectDelete(id), cancellationToken);

    #endregion

    #region InputText

    /// <summary>
    /// Gets a list of input_text helpers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassInputText>?> GetInputTextsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputTextList, IReadOnlyCollection<HassInputText>>(
            new HassInputTextList(), cancellationToken);

    /// <summary>
    /// Creates a new input_text helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="minLength"></param>
    /// <param name="maxLength"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="pattern"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputText?> CreateInputTextAsync(this IHomeAssistantConnection connection, string name, 
        int? minLength = default, int? maxLength = default, string? initialValue = default, string? icon = default, 
        string? unitOfMeasurement = default, string? pattern = default, HassInputTextMode? mode = default, 
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputTextCreate, HassInputText>(
            new HassInputTextCreate(name, minLength, maxLength, initialValue, icon, unitOfMeasurement, pattern, mode),
            cancellationToken);

    /// <summary>
    /// Updates the specified input_text helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="minLength"></param>
    /// <param name="maxLength"></param>
    /// <param name="initialValue"></param>
    /// <param name="icon"></param>
    /// <param name="unitOfMeasurement"></param>
    /// <param name="pattern"></param>
    /// <param name="mode"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassInputText?> UpdateInputTextAsync(this IHomeAssistantConnection connection, string id, 
       string? name = default, int? minLength = default, int? maxLength = default, string? initialValue = default, 
       string? icon = default, string? unitOfMeasurement = default, string? pattern = default, 
       HassInputTextMode? mode = default, CancellationToken cancellationToken = default)

       => connection.SendCommandAndReturnResponseAsync<HassInputTextUpdate, HassInputText>(
           new HassInputTextUpdate(id, name, minLength, maxLength, initialValue, icon, unitOfMeasurement, pattern, mode),
           cancellationToken);

    /// <summary>
    /// Deletes the specified input_text helper
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteInputTextAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassInputTextDelete, Object>(
            new HassInputTextDelete(id), cancellationToken);

    #endregion

    #region Person

    /// <summary>
    /// Gets a list of persons
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassPerson>?> GetPersonsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassPersonList, IReadOnlyCollection<HassPerson>>(
            new HassPersonList(), cancellationToken);

   /// <summary>
   /// Creates a new person
   /// </summary>
   /// <param name="connection"></param>
   /// <param name="name"></param>
   /// <param name="userId"></param>
   /// <param name="deviceTrackers"></param>
   /// <param name="picture"></param>
   /// <param name="cancellationToken"></param>
   /// <returns></returns>
    public static Task<HassPerson?> CreatePersonAsync(this IHomeAssistantConnection connection,
       string name, string? userId = default, IEnumerable<string>? deviceTrackers = default, string? picture = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassPersonCreate, HassPerson>(
            new HassPersonCreate(name, userId, deviceTrackers, picture), cancellationToken);

    /// <summary>
    /// Updates the specified person
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="userId"></param>
    /// <param name="deviceTrackers"></param>
    /// <param name="picture"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassPerson?> UpdatePersonAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, string? userId = default, IEnumerable<string>? deviceTrackers = default, 
       string? picture = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassPersonUpdate, HassPerson>(
             new HassPersonUpdate(id, name, userId, deviceTrackers, picture), cancellationToken);

    /// <summary>
    /// Deletes the specified lovelace person
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeletePersonAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassPersonDelete, Object>(
            new HassPersonDelete(id), cancellationToken);

    #endregion

    #region ShoppingList

    /// <summary>
    /// Gets the content of the shopping list
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassShoppingListItem>?> GetShoppingListAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassShoppingItemsList, IReadOnlyCollection<HassShoppingListItem>>(
            new HassShoppingItemsList(), cancellationToken);

    /// <summary>
    /// Clears the shopping list
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task ClearShoppingListAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassShoppingItemsClear, Object>(
            new HassShoppingItemsClear(), cancellationToken);

    /// <summary>
    /// Adds a new item to the shopping list
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassShoppingListItem?> CreateShoppingListItemAsync(this IHomeAssistantConnection connection,
        string name, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassShoppingItemCreate, HassShoppingListItem>(
            new HassShoppingItemCreate(name), cancellationToken);

    /// <summary>
    /// Updates the specified item from the shopping list
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="complete"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassShoppingListItem?> UpdateShoppingListItemAsync(this IHomeAssistantConnection connection, 
        string id, string? name = default, bool? complete = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassShoppingItemUpdate, HassShoppingListItem>(
             new HassShoppingItemUpdate(id, name, complete), cancellationToken);

    /// <summary>
    /// Reorders items in the shopping list
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="ids"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task ReorderShoppingListAsync(this IHomeAssistantConnection connection,
        IEnumerable<string> ids, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassShoppingItemsReorder, Object>(
             new HassShoppingItemsReorder(ids), cancellationToken);

    #endregion

    #region Tag

    /// <summary>
    /// Gets a list of tags
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassTag>?> GetTagsAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTagList, IReadOnlyCollection<HassTag>>(
            new HassTagList(), cancellationToken);

    /// <summary>
    /// Creates a new tag
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="lastScanned"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassTag?> CreateTagAsync(this IHomeAssistantConnection connection,
       string? id = default, string? name = default, string? description = default, DateTime? lastScanned = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTagCreate, HassTag>(
            new HassTagCreate(id, name, description, lastScanned), cancellationToken);

    /// <summary>
    /// Updates the specified tag
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="description"></param>
    /// <param name="lastScanned"></param>
    /// <param name="picture"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassTag?> UpdateTagAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, string? description = default, DateTime? lastScanned = default,
       string? picture = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTagUpdate, HassTag>(
             new HassTagUpdate(id, name, description, lastScanned), cancellationToken);

    /// <summary>
    /// Deletes the specified ag
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteTagAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTagDelete, Object>(
            new HassTagDelete(id), cancellationToken);

    #endregion

    #region Timer

    /// <summary>
    /// Gets a list of timers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassTimer>?> GetTimersAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTimerList, IReadOnlyCollection<HassTimer>>(
            new HassTimerList(), cancellationToken);

    /// <summary>
    /// Creates a new timer
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="duration"></param>
    /// <param name="restore"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassTimer?> CreateTimerAsync(this IHomeAssistantConnection connection,
       string name, string? icon = default, TimeSpan? duration = default, bool? restore = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTimerCreate, HassTimer>(
            new HassTimerCreate(name, icon, duration, restore), cancellationToken);

    /// <summary>
    /// Updates the specified timer
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="icon"></param>
    /// <param name="duration"></param>
    /// <param name="restore"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassTimer?> UpdateTimerAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, string? icon = default, TimeSpan? duration = default, bool? restore = default,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTimerUpdate, HassTimer>(
             new HassTimerUpdate(id, name, icon, duration, restore), cancellationToken);

    /// <summary>
    /// Deletes the specified timer
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteTimerAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassTimerDelete, Object>(
            new HassTimerDelete(id), cancellationToken);

    #endregion

    #region User

    /// <summary>
    /// Gets a list of users
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassUser>?> GetUsersAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassUserList, IReadOnlyCollection<HassUser>>(
            new HassUserList(), cancellationToken);

    /// <summary>
    /// Creates a new user
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="groups"></param>
    /// <param name="localOnly"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassUser?> CreateUserAsync(this IHomeAssistantConnection connection,
       string name, IEnumerable<string> groups, bool localOnly,
       CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassUserCreate, HassUser>(
            new HassUserCreate(name, groups, localOnly), cancellationToken);

    /// <summary>
    /// Updates the specified user
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="isActive"></param>
    /// <param name="groups"></param>
    /// <param name="localOnly"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassUser?> UpdateUserAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, bool? isActive = default, IEnumerable<string>? groups = default,
       bool? localOnly = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassUserUpdate, HassUser>(
             new HassUserUpdate(id, name, isActive, groups, localOnly), cancellationToken);

    /// <summary>
    /// Deletes the specified lovelace user
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteUserAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassUserDelete, Object>(
            new HassUserDelete(id), cancellationToken);

    #endregion

    #region Zone

    /// <summary>
    /// Gets a list of zones
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<IReadOnlyCollection<HassZone>?> GetZonesAsync(this IHomeAssistantConnection connection,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassZoneList, IReadOnlyCollection<HassZone>>(
            new HassZoneList(), cancellationToken);

    /// <summary>
    /// Creates a new zone
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="name"></param>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="radius"></param>
    /// <param name="passive"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassZone?> CreateZoneAsync(this IHomeAssistantConnection connection,
       string name, double latitude, double longitude, double? radius = default, bool? passive = default, 
       string? icon = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassZoneCreate, HassZone>(
            new HassZoneCreate(name, latitude, longitude, radius, passive, icon), cancellationToken);

    /// <summary>
    /// Updates the specified zone
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="latitude"></param>
    /// <param name="longitude"></param>
    /// <param name="radius"></param>
    /// <param name="passive"></param>
    /// <param name="icon"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public static Task<HassZone?> UpdateZoneAsync(this IHomeAssistantConnection connection, string id,
       string? name = default, double? latitude = default, double? longitude = default, double? radius = default, 
       bool? passive = default, string? icon = default, CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassZoneUpdate, HassZone>(
             new HassZoneUpdate(id, name, latitude, longitude, radius, passive, icon), cancellationToken);

    /// <summary>
    /// Deletes the specified zone
    /// </summary>
    /// <param name="connection"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public static Task DeleteZoneAsync(this IHomeAssistantConnection connection, string id,
        CancellationToken cancellationToken = default)

        => connection.SendCommandAndReturnResponseAsync<HassZoneDelete, Object>(
            new HassZoneDelete(id), cancellationToken);

    #endregion

}


