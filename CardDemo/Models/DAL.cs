using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CardDemo.Models
{
	public class DAL
	{
		private static HttpClient client = null;
		private static HttpClient GetHttpClient()
		{
			// We're building a **SINGLETON** object of type HttpClient
			// Book: Design Patterns

			if (client == null)
			{
				// client instance hasn't been made yet, make it and initialize it
				client = new HttpClient();
				client.BaseAddress = new Uri("https://www.deckofcardsapi.com");
			}
			return client;
		}

		public static async Task<string> GetNewDeck()
		{
			var connection = await GetHttpClient().GetAsync("/api/deck/new/shuffle/?deck_count=1");
			DeckResponse resp = await connection.Content.ReadAsAsync<DeckResponse>();
			return resp.deck_id;
		}

		public static async Task<DeckResponse> GetCards(string deck_id, int count)
		{
			var connection = await GetHttpClient().GetAsync($"https://www.deckofcardsapi.com/api/deck/{deck_id}/draw/?count={count}");
			DeckResponse resp = await connection.Content.ReadAsAsync<DeckResponse>();
			return resp;
		}
	}
}

/*
 * 			string domain = "https://openlibrary.org";
			string path = $"/authors/{key}.json";

			HttpClient client = new HttpClient();
			client.BaseAddress = new Uri(domain);
			var connection = await GetHttpClient().GetAsync(path);
			AuthorDetail result = await connection.Content.ReadAsAsync<AuthorDetail>();
*/
