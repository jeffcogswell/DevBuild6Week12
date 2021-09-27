using BookAPIDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http; // Add this
using System.Threading.Tasks;

namespace BookAPIDemo.Controllers
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

		// In order to use the "await" and "Async" functions in this function, we have to make the function itself an "async" function.
		// Although this function LOOKS like it returns something called Task<IActionResult>, in fact it actually just returns an IActionResult.
		// So for example, if we have an async function that returns a string, we have to make the return type Task<string>. Our function
		// STILL returns a string though, and will have a line such as return "Hello".
		public async Task<IActionResult> testapicall()
		{
			string domain = "https://openlibrary.org";
			string path = "/search/authors.json?q=Stephen%20King";

			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri(domain);
			var connection = await client.GetAsync(path); // Async means our function will pause and wait until GetAsync finishes. Then come back and pick up where we left off.
			string result = await connection.Content.ReadAsStringAsync();

			return Content(result);
		}

		public async Task<IActionResult> searchauthor(string author)
		{
			string domain = "https://openlibrary.org";
			string path = $"/search/authors.json?q={author}";

			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri(domain);
			var connection = await client.GetAsync(path); // Async means our function will pause and wait until GetAsync finishes. Then come back and pick up where we left off.
			Root result = await connection.Content.ReadAsAsync<Root>();

			return View(result);
		}

		public async Task<IActionResult> authordetails(string key)
		{
			string domain = "https://openlibrary.org";
			string path = $"/authors/{key}.json";

			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri(domain);
			var connection = await client.GetAsync(path); // Async means our function will pause and wait until GetAsync finishes. Then come back and pick up where we left off.
			AuthorDetail result = await connection.Content.ReadAsAsync<AuthorDetail>();

			return View(result);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
