using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPIDemo.Models
{
	public class Root
	{
		public int numFound { get; set; }
		public int start { get; set; }
		public bool numFoundExact { get; set; }
		public List<AuthorDoc> docs { get; set; }
	}

	public class AuthorDoc
	{
		public string key { get; set; }
		public List<string> text { get; set; }
		public string type { get; set; }
		public string name { get; set; }
		public List<string> alternate_names { get; set; }
		public string birth_date { get; set; }
		public string top_work { get; set; }
		public int work_count { get; set; }
		public List<string> top_subjects { get; set; }

	}

	public class AuthorDetail
	{
		public List<int> photos { get; set; }
		public string personal_name { get; set; }
		public string birth_date { get; set; }
		public Bio bio { get; set; }
		public List<string> alternate_names { get; set; }
	}

	public class Bio
	{
		public string type { get; set; }
		public string value { get; set; }
	}
}
