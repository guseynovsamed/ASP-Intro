using System;
using ASP_HW.Models;
using ASP_HW.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace ASP_HW.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Index()
		{
			var users = GetAllUsers();

			List<UserVM> user = new();

			foreach (var item in users)
			{
				user.Add(new UserVM
				{
					FullName = item.FullName,
					Age = item.Age,
					Address = item.Address,
					Email = item.Email
				});
			}
			return View(user);
		}



		private List<User> GetAllUsers()
		{
			return new List<User>
			{
				new User
				{
					Id = 1,
					FullName="Semed Huseynov",
					Age = 27,
					Email="semed@mail.ru",
				    Address = "Ehmedli"
				},

                new User
                {
                    Id = 2,
                    FullName="Tunzale Memmedova",
                    Age = 24,
                    Email="tunzale@mail.ru",
                    Address = "Nesimi"
                },



                new User
                {
                    Id = 3,
                    FullName="Besir Temirli",
                    Age = 26,
                    Email="besir@mail.ru",
                    Address = "Yasamal"
                }
            };
		}
			
	}
}

