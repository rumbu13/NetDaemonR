using NetDaemon.Extensions.HassClient.Models;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassEntityList : HassCommand
{
    public HassEntityList() :
        base("config/entity_registry/list")
    {
    }
}

internal record HassEntityGet : HassCommand
{
    public HassEntityGet(string id) : 
        base("config/entity_registry/get")
    {            
        this.EntidtyId = id;
    }

    [JsonPropertyName("entity_id")]
    public string EntidtyId { get; init; }
}

internal record HassEntityDelete : HassCommand
{
    public HassEntityDelete(string id) :
        base("config/entity_registry/remove")
    {
        this.EntidtyId = id;
    }

    [JsonPropertyName("entity_id")]
    public string EntidtyId { get; init; }
}

internal record HassEntityUpdate : HassCommand
{
    public HassEntityUpdate(string id, string? name, string? icon, string? deviceClass, string? areaId, 
        string? disabledBy, string? hiddenBy, string? newEntityId, string? optionsDomain) :
        base("config/entity_registry/update")
    {
        this.EntidtyId = id;
    }

    [JsonPropertyName("entity_id")]
    public string EntidtyId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("device_class")]
    public string? DeviceClass { get; init; }

    [JsonPropertyName("area_id")]
    public string? AreaId { get; init; }

    [JsonPropertyName("disabled_by")]
    public string? DisabledBy { get; init; }

    [JsonPropertyName("hidden_by")]
    public string? HiddenBy { get; init; }

    [JsonPropertyName("new_entity_id")]
    public string? NewEntidtyId { get; init; }
  
    [JsonPropertyName("options_domain")]
    public string? OptionsDomain { get; init; }
}

internal record HassEntityUpdateSensor : HassEntityUpdate
{
    public HassEntityUpdateSensor(string id, string? name, string? icon, string? deviceClass, string? areaId,
        string? disabledBy, string? hiddenBy, string? newEntityId, string? optionsDomain, string? unitOfMeasurement) :
        base(id, name, icon, deviceClass, areaId, disabledBy, hiddenBy, newEntityId, optionsDomain)
    {
        if (unitOfMeasurement != null)
            Options = new HassEntitySensorOptions() { UnitOfMeasurement = unitOfMeasurement };
    }

    [JsonPropertyName("options")]
    public HassEntitySensorOptions? Options { get; init; }
}

internal record HassEntityUpdateWeather : HassEntityUpdate
{
    public HassEntityUpdateWeather(string id, string? name, string? icon, string? deviceClass, string? areaId,
        string? disabledBy, string? hiddenBy, string? newEntityId, string? optionsDomain, string? precipitationUnit, 
        string? pressureUnit, string? temperatureUnit, string? visibilityUnit, string? windSpeedUnit) :
        base(id, name, icon, deviceClass, areaId, disabledBy, hiddenBy, newEntityId, optionsDomain)
    {
        if (precipitationUnit != null || 
            pressureUnit != null || 
            temperatureUnit != null || 
            visibilityUnit != null || 
            windSpeedUnit != null)
            Options = new HassEntityWeatherOptions() 
            { 
                PrecipitationUnit = precipitationUnit,
                PressureUnitUnit = pressureUnit,
                TemperatureUnit = temperatureUnit,
                VisibilityUnit = visibilityUnit,
                WindSpeedUnit = windSpeedUnit
            };
    }

    [JsonPropertyName("options")]
    public HassEntityWeatherOptions? Options { get; init; }
}


