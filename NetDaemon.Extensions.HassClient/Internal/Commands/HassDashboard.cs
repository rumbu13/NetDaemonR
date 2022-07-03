using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Extensions.HassClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassDashboardList : HassCommand
{
    public HassDashboardList() : 
        base("lovelace/dashboards/list")
    {            
    }
}

internal record HassDashboardCreate : HassCommand
{
    public HassDashboardCreate(string title, string url, bool? requiresAdmin, string? icon, bool? showInSidebar, 
        HassDashboardMode? mode) : 
        base("lovelace/dashboards/create")
    {
        this.Title = title;
        this.Url = url;
        this.RequiresAdmin = requiresAdmin;
        this.Icon = icon;
        this.ShowInSidebar = showInSidebar;
        this.Mode = mode;
    }

    [JsonPropertyName("title")]
    public string Title { get; init; }

    [JsonPropertyName("url_path")]
    public string Url { get; init; }

    [JsonPropertyName("require_admin")]
    public bool? RequiresAdmin { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("show_in_sidebar")]
    public bool? ShowInSidebar { get; init; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("mode")]
    public HassDashboardMode? Mode { get; init; }

   
}

internal record HassDashboardDelete : HassCommand
{
    public HassDashboardDelete(string id) : 
        base("lovelace/dashboards/delete")
    {
        this.DashboardId = id;
    }

    [JsonPropertyName("dashboard_id")]
    public string DashboardId { get; init; }
}


internal record HassDashboardUpdate : HassCommand
{
    public HassDashboardUpdate(string id, string? title, bool? requiresAdmin, string? icon, bool? showInSidebar) :
        base("lovelace/dashboards/create")
    {
        this.DashboardId = id;
        this.Title = title;
        this.RequiresAdmin = requiresAdmin;
        this.Icon = icon;
        this.ShowInSidebar = showInSidebar;
    }

    [JsonPropertyName("dashboard_id")]
    public string DashboardId { get; init; }

    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonPropertyName("require_admin")]
    public bool? RequiresAdmin { get; init; }

    [JsonPropertyName("icon")]
    public string? Icon { get; init; }

    [JsonPropertyName("show_in_sidebar")]
    public bool? ShowInSidebar { get; init; }

}


