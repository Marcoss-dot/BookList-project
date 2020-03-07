using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyBookListMVC.Models
{
	public class UserClass
	{
		[Key]
		public int UserId { get; set; }

		[Required(ErrorMessage = "Username is required.")]
		[Display(Name="User name")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Password is required.")]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Pwd { get; set; }

		[Required(ErrorMessage = "Confirm password is required.")]
		[Compare("Pwd", ErrorMessage = "Please confirm your password.")]
		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		public string Confirmpwd { get; set; }

		[Required(ErrorMessage = "Email is required.")]
		[Display(Name = "Email")]
		public string Uemail { get; set; }

		[Required(ErrorMessage = "Select the Gender.")]
		[Display(Name = "Gender")]
		public string  Gender { get; set; }

		[Required(ErrorMessage = "Select the Martial status.")]
		[Display(Name = "Martial Status")]
		public string Martialstatus { get; set; }
	}
}
