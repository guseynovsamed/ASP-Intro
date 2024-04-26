using System;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

