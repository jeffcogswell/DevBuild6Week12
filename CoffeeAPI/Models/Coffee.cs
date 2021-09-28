using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data;

namespace CoffeeAPI.Models
{

	[Table("category")]
	public class Category
	{
		[ExplicitKey]
		public string id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
	}

	[Table("product")]
	public class Product
	{
		[Key]
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public decimal price { get; set; }
		public string categoryId { get; set; }
	}

	// This is a ViewModel class:
	public class CategoryProducts
	{
		public Category cat { get; set; }
		public List<Product> prods { get; set; }
	}
}
