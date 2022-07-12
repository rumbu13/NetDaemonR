using NetDaemon.Client.HomeAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassUserList : HassCommand
{
    public HassUserList() : 
        base("config/auth/list")
    {            
    }
}

internal record HassUserCreate : HassCommand
{
    public HassUserCreate(string name, IEnumerable<string> groups, bool localOnly) : 
        base("config/auth/create")
    {
        this.Name = name;
        this.Groups = groups.ToArray();
        this.LocalOnly = localOnly;
    }

    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("group_ids")]
    public string[] Groups { get; init; }

    [JsonPropertyName("local_only")]
    public bool LocalOnly { get; init; }

}

internal record HassUserDelete : HassCommand
{
    public HassUserDelete(string id) : 
        base("config/auth/delete")
    {
        this.UserId = id;
    }

    [JsonPropertyName("user_id")]
    public string UserId { get; init; }
}


internal record HassUserUpdate : HassCommand
{
    public HassUserUpdate(string id, string? name, bool? isActive, IEnumerable<string>? groups, bool? localOnly) :
        base("config/auth/update")
    {
        this.UserId = id;
        this.Name = name;
        this.IsActive = isActive;
        this.Groups = groups?.ToArray();
        this.LocalOnly = localOnly;
    }

    [JsonPropertyName("user_id")]
    public string UserId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("is_active")]
    public bool? IsActive { get; init; }

    [JsonPropertyName("group_ids")]
    public string[]? Groups { get; init; }

    [JsonPropertyName("local_only")]
    public bool? LocalOnly { get; init; }
}


