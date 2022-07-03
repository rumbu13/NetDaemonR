using NetDaemon.Client.HomeAssistant.Model;
using NetDaemon.Extensions.HassClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassBlueprintList : HassCommand
{
    public HassBlueprintList(HassBlueprintDomain domain) : 
        base("blueprint/list")
    {            
        Domain = domain;
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("domain")]
    public HassBlueprintDomain Domain { get; init; }
}

internal record HassBlueprintImport: HassCommand
{
    public HassBlueprintImport(string url) : 
        base("blueprint/import")
    {
        this.Url = url;
    }

    [JsonPropertyName("url")]
    public string Url { get; init; }

}

internal record HassBlueprintDelete : HassCommand
{
    public HassBlueprintDelete(HassBlueprintDomain domain, string path) : 
        base("blueprint/delete")
    {
        this.Domain = domain;
        this.Path = path;
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("domain")]
    public HassBlueprintDomain Domain { get; init; }

    [JsonPropertyName("path")]
    public string Path { get; init; }
}


internal record HassBlueprintSave: HassCommand
{
    public HassBlueprintSave(HassBlueprintDomain domain, string path, string yaml, string? sourceUrl) : 
        base("blueprint/save")
    {
        this.Domain = domain;
        this.Path = path;
        this.Yaml = yaml;
        this.SourceUrl = sourceUrl;
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [JsonPropertyName("domain")]
    public HassBlueprintDomain Domain { get; init; }

    [JsonPropertyName("path")]
    public string Path { get; init; }

    [JsonPropertyName("yaml")]
    public string Yaml { get; init; }

    [JsonPropertyName("source_url")]
    public string? SourceUrl { get; init; }
}


