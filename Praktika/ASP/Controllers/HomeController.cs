using System;
using ASP.Models;
using ASP.ViewModels;
using ASP.ViewModels.Student;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Controllers
{
	public class HomeController : Controller
	{

		//public string Search(string searchText, string name)
		//{
		//	if (name.Contains(searchText))
		//	{
		//		return "yes";
		//	}
		//	return "no";
		//}


		public IActionResult Index()
		{
			var datas = GetAllStudents();

			List<StudentVM> students = new();

			foreach (var item in datas)
			{
				students.Add(new StudentVM
				{
					FullName = item.FullName
				});
			}


			Book book = new()
			{
				Id = 1,
				Name = "Cirtdan"
			};

			HomeVM model = new()
			{
				Students = students,
				Book = book

			};

			
            return View(model);
		}


        private List<Student> GetAllStudents()
		{
			return new List<Student>
			 {
				 new Student
				 {
					 Id=1,
					 FullName="Semed Huseynov",
					 Age=28
				 },

				 new Student
				 {
					 Id=2,
					 FullName="Tunzale Memmedova",
					 Age=25
				 },


                 new Student
                 {
                     Id=3,
                     FullName="Nise Nermanov",
                     Age=26
                 },



                 new Student
                 {
                     Id=4,
                     FullName="Arzu Kerimova",
                     Age=27
                 }
             };
		}
		

	}
}

