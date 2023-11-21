using System;

namespace IMSonsole;

public class Tool
{
    public int ToolId { get; set; }
    public required string ToolName { get; set; }
    public string ToolDescription { get; set; } = string.Empty;
    public int Quantity { get; set; }
}
