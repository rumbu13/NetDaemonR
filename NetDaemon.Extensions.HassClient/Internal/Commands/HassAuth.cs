using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Extensions.HassClient.Internal.Json;
using NetDaemon.Extensions.HassClient.Models;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;


internal record HassCurrentUser : HassCommand
{
    public HassCurrentUser() : 
        base("auth/current_user")
    {
    }
}

internal record HassTokenCreate: HassCommand
{
    public HassTokenCreate(TimeSpan lifeSpan, string clientName, string? clientIcon) :
        base("auth/long_lived_access_token")
    {
        this.LifeSpan = lifeSpan;
        this.ClientName = clientName;
        this.ClientIcon = clientIcon;
    }

    [JsonPropertyName("lifespan")]
    [JsonConverter(typeof(JsonTimeSpanDaysConverter))]
    public TimeSpan LifeSpan { get; init; }

    [JsonPropertyName("client_name")]
    public string ClientName { get; init; }

    [JsonPropertyName("client_icon")]
    public string? ClientIcon { get; init; }
}

internal record HassTokenList : HassCommand
{
    public HassTokenList() : 
        base("auth/refresh_tokens")
    {
    }
}

internal record HassTokenDelete : HassCommand
{
    public HassTokenDelete(string id) : 
        base("auth/delete_refresh_token")
    {
        this.TokenId = id;
    }

    [JsonPropertyName("refresh_token_id")]
    public string TokenId { get; init; }
}

internal record HassSignPath : HassCommand
{
    public HassSignPath(string path, TimeSpan? expires) : 
        base("auth/sign_path")
    {
        this.Path = path;
        this.Expires = expires;
    }

    [JsonPropertyName("path")]
    public string? Path { get; init; }

    [JsonPropertyName("expires")]
    [JsonConverter(typeof(JsonTimeSpanSecondsConverter))]
    public TimeSpan? Expires { get; init; }
}

internal record HassUserCreate: HassCommand
{
    public HassUserCreate(string id, string name, string password) :
       base("config/auth_provider/homeassistant/create")
    {
        this.UserId = id;
        this.Username = name;
        this.Password = password;
    }

    [JsonPropertyName("user_id")]
    public string UserId { get; init; }

    [JsonPropertyName("username")]
    public string Username { get; init; }

    [JsonPropertyName("pasword")]
    public string Password { get; init; }
}

internal record HassUserChangePassword: HassCommand
{
    public HassUserChangePassword(string id, string password) :
       base("config/auth_provider/homeassistant/admin_change_password")
    {
        this.UserId = id;
        this.Password = password;
    }

    [JsonPropertyName("user_id")]
    public string UserId { get; init; }

    [JsonPropertyName("pasword")]
    public string Password { get; init; }
}

