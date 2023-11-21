using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMSConsole;

public class Product
{
	public int ItemID { get; set; }
	public string? Name { get; set; }

	[Column(TypeName = "string(20)")]
	public decimal Price { get; set; }
	public required string Description { get; set; }
}
