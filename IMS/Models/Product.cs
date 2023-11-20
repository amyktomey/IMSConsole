using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS;

public class Product
{
	public int ItemID { get; set; }
	public string Name { get; set; } = null;

	[Column(TypeName = "string(20)")]
	public decimal Price { get; set; }
	public required string Description { get; set; }
}
