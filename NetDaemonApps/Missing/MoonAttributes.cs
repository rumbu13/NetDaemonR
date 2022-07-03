namespace NetDaemonApps;

public record MoonAttributes
{
	[JsonPropertyName("device_class")]
	public string? DeviceClass { get; init; }

	[JsonPropertyName("icon")]
	public string? Icon { get; init; }

	[JsonPropertyName("friendly_name")]
	public string? FriendlyName { get; init; }

}
