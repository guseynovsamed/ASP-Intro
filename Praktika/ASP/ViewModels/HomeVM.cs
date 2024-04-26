using System;
using ASP.Models;
using ASP.ViewModels.Student;

namespace ASP.ViewModels
{
	public class HomeVM
	{
		public List<StudentVM>? Students { get; set; }
		public Book? Book { get; set; }
	}
}

