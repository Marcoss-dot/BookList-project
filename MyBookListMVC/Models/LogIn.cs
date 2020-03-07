using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace MyBookListMVC.Models
{
	public class LogIn
	{
		[Required(ErrorMessage = "Please enter your User name ")]
		[Display(Name = "Enter User name")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Please enter you User name")]
		[DataType(DataType.Password)]
		[Display(Name = "Enter Password")]
		public string Pwd { get; set; }

		public bool IsLogged { get; set; }

	}
}
