using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBookListMVC.Models;


namespace MyBookListMVC.Controllers
{
	public class UserRegistrationController : Controller
	{
		private readonly ApplicationDbContext _db;


		public UserRegistrationController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(UserClass UserReg)
		{
			var Name = _db.UserReg.Select(x => x.Username).Where(x => x == UserReg.Username).FirstOrDefault();
			var Email = _db.UserReg.Select(x => x.Uemail).Where(x => x == UserReg.Uemail).FirstOrDefault();

			if (Name == null && Email == null)
			{
				_db.Add(UserReg);
				_db.SaveChanges();
				ViewBag.message = "The User " + UserReg.Username + " is Saved Successfully.";
				return View();
			}
			else
			{
				ViewBag.message = "The User " + UserReg.Username + " is already exist or the email "+ UserReg.Uemail + " is already used!";
				return View();
			}


		}



	}
}