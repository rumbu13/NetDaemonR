namespace NetDaemon.Extensions.HassClient.Models;

public record HassImage
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("filesize")]
    public long? FileSize { get; init; }

    [JsonPropertyName("content_type")]
    public string? Icon { get; init; }

    [JsonPropertyName("name")]
    public int? Name { get; init; }

    [JsonPropertyName("uploaded_at")]
    public DateTime? UploadedAt { get; init; }

}
