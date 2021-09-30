using EmployeeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAPI.Controllers
{
	[Route("api/employee")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		[HttpGet("readall")]
		// Optional exercise: What would happen if I changed this to
		//[HttpGet]
		// with no path in it?
		public List<Employee> readall() // REMINDER: The name of this function has no bearing on the URL (unlike regular controllers)
		{
			return DAL.ReadAllEmployees();
		}

		[HttpGet("readone")]
		public Employee readone(int id)
		{
			return DAL.ReadOneEmployee(id);
		}

		[HttpGet("readbydepartment")]
		public List<Employee> readbydepartment(string dept)
		{
			List<Employee> result = DAL.ReadAllByDepartment(dept);
			return result;
		}

		[HttpDelete("delete")]
		public bool deleteEmployee(int id)
		{
			return DAL.DeleteEmployee(id);
		}

		[HttpPost("add")]
		public Employee addEmployee(Employee emp)
		{
			return DAL.AddEmployee(emp);
		}

		[HttpPut("update")]
		public Employee updateEmployee(Employee emp)
		{
			return DAL.UpdateEmployee(emp);
		}

		[HttpGet("search")]
		public List<Employee> searchLastName(string lastname)
		{
			return DAL.SearchByLastName(lastname);
		}
	}
}
