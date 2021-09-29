using JSONDemoViaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JSONDemoViaMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult mypage()
		{
			return View();
		}

		public IActionResult mypage2()
		{
			Response.Headers.Add("Content-Type", "application/json");
			return Content("Hello!");
		}

		public IActionResult mypage3()
		{
			return Content("{ \"name\" : \"Fred\", \"id\" : 5 }");
		}

		public IActionResult mypage4()
		{
			// Imagine instead of hardcoding the string, we read something from a database

			// We might read in an object that has a name and an ID
			// Here we'll just create the object ourselves, but imagine
			// that we read it from a database

			Employee emp = new Employee();
			emp.name = "Sally";
			emp.id = 6;

			Response.Headers.Add("Content-Type", "application/json");
			return Content($"{{ \"name\" : \"{emp.name}\", \"id\" : {emp.id} }}");
			//return Content($"name {emp.name} with id number {emp.id}!");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
