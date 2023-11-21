using System;

namespace IMSConsole;

public class Component
{
    public int ComponentId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ProductType { get; set; }
    public int? Quantity { get; set; }
    public ICollection<ItemPart>? ItemParts { get; set; }
}
