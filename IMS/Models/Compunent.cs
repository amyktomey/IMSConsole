using System;

namespace IMS;

public class Component
{
    public int ComponentId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public int? Quantity { get; set; }
    public ICollection<ItemParts> ItemParts { get; set; } = null;
}
