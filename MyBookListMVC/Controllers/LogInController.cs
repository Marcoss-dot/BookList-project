using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBookListMVC.Models;


namespace MyBookListMVC.Controllers
{
    public class LogInController : Controller
    {
			private readonly ApplicationDbContext _db;

			public LogInController(ApplicationDbContext db)
			{
				_db = db;
			}


        public IActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public IActionResult Index(LogIn login)
		{
			var name = _db.UserReg.Select(x => x.Username).Where(x => x == login.Username).FirstOrDefault();
			var password = _db.UserReg.Select(x => x.Pwd).Where(x => x == login.Pwd).FirstOrDefault();
			if (name != null && password != null)
			{
				login.IsLogged = true;
				return RedirectToAction("Index","Books");
			}
			ViewBag.message = "The User " + login.Username + " or the password is invalid!";
			return View();
		}
	}
}