using CoffeeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeAPI.Controllers
{
	[Route("api/category")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		// https://localhost:44388/api/category
		[HttpGet]   // or [HttpGet()]
		public List<Category> getAll()
		{
			return DAL.GetAllCategories();
		}

		// https://localhost:44388/api/category?id=COFF
		[HttpGet("{id}")]
		public Category getSingleCategory(string id)
		{
			return DAL.GetCategory(id);
		}

		// https://localhost:44388/api/category/products?id=COFF
		[HttpGet("products")]
		public List<Product> getProductsInCategory(string id)
		{
			return DAL.GetAllForCategory(id);
		}

		[HttpPost]
		public string insertCategory(Category cat)
		{
			DAL.InsertCategory(cat);
			return cat.id;
		}

		[HttpDelete("{id}")]
		public bool deleteCategory(string id)
		{
			DAL.DeleteCategory(id);
			return true;
		}




		//
		// Some samples to practice with
		//
		[HttpGet("testhello")]
		public string test()
		{
			return "Hello";
		}

		[HttpGet("testhello/there")]
		public string test2()
		{
			return "Hello there";
		}

		[HttpGet("testcat")]
		public Category test3()
		{
			return DAL.GetCategory("PAST");
		}

		[HttpGet("testcat/{id}")]
		public Category getSingleCategoryPractice(string id)
		{
			return DAL.GetCategory(id);
		}

	}
}
