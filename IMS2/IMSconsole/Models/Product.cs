using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMSConsole;

public class Product
{
	public int ProductID { get; set; }
	public string? Name { get; set; }

	[Column(TypeName = "string(20)")]
    public string? ProductType { get; set; }
	public decimal Price { get; set; }
	public required string Description { get; set; }
	public int Quantity { get; set; }	
}
