namespace NetDaemon.Extensions.HassClient.Internal.Commands;

internal record HassShoppingItemsList : HassCommand
{
    public HassShoppingItemsList() : 
        base("shopping_list/items")
    {            
    }
}

internal record HassShoppingItemsClear : HassCommand
{
    public HassShoppingItemsClear() :
        base("shopping_list/items/clear")
    {
    }
}

internal record HassShoppingItemCreate : HassCommand
{
    public HassShoppingItemCreate(string name) : 
        base("shopping_list/items/add")
    {
        this.Name = name;
    }

    [JsonPropertyName("name")]
    public string Name { get; init; }
}


internal record HassShoppingItemUpdate : HassCommand
{
    public HassShoppingItemUpdate(string id, string? name, bool? complete) :
        base("shopping_list/items/update")
    {
        this.ItemId = id;
        this.Name = name;
        this.Complete = complete;
    }

    [JsonPropertyName("item_id")]
    public string ItemId { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("complete")]
    public bool? Complete { get; init; }
}

internal record HassShoppingItemsReorder : HassCommand
{
    public HassShoppingItemsReorder(IEnumerable<string> itemIds) :
        base("shopping_list/items/reorder")
    {
        this.ItemIds = itemIds.ToArray();
    }

    [JsonPropertyName("item_ids")]
    public string[] ItemIds { get; init; }

}


