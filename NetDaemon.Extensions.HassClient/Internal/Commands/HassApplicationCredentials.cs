using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Extensions.HassClient.Internal.Json;
using NetDaemon.Extensions.HassClient.Models;
using System.Text.Json.Serialization;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassCredentialsConfig : HassCommand
{
    public HassCredentialsConfig() :
        base("application_credentials/config")
    {

    }
}

internal record HassCredentialsList : HassCommand
{
    public HassCredentialsList() : 
        base("application_credentials/list")
    {

    }
}

internal record HassCredentialsDelete : HassCommand
{
    public HassCredentialsDelete(string id) : 
        base("application_credentials/delete")
    {
        this.CredentialId = id;
    }

    [JsonPropertyName("application_credentials_id")]
    public string CredentialId { get; init; }
}

internal record HassCredentialsCreate : HassCommand
{
    public HassCredentialsCreate(string domain, string clientid, string clientSecret, string? authDomain, string? name) :
        base("application_credentials/create")
    {
        this.Domain = domain;
        this.ClientId = clientid;
        this.ClientSecret = clientSecret;
        this.AuthDomain = authDomain;
        this.Name = name;
    }

    [JsonPropertyName("domain")]
    public string Domain { get; init; }

    [JsonPropertyName("client_id")]
    public string ClientId { get; init; }

    [JsonPropertyName("client_secret")]
    public string ClientSecret { get; init; }

    [JsonPropertyName("auth_domain")]
    public string? AuthDomain { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }
}