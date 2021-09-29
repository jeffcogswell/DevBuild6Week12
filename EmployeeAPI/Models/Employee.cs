using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace EmployeeAPI.Models
{
	[Table("employee")]
	public class Employee
	{
		[Key]
		public int id { get; set; }
		public string firstname { get; set; }
		public string lastname { get; set; }
		public string department { get; set; }
	}
}

//   Employee emp = new Employee() { id = 10, firstname = "Fred", lastname = "Smith", department = "ACCT" };