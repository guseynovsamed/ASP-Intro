using System;
using ASP_HW.Models;
using ASP_HW.ViewModels.Employee;
using ASP_HW.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace ASP_HW.Controllers
{
	public class EmployeeController : Controller
	{
        public IActionResult Index()
        {
            var employees = GetAllEmployees();

            List<EmployeeVM> employee = new();

            foreach (var item in employees)
            {
                employee.Add(new EmployeeVM
                {
                    Name = item.Name,
                    Age = item.Age,
                    Surname = item.Surname,
                    Salary = item.Salary
                });
            }

            return View(employee);
        }



        private List<Employee> GetAllEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name="Semed",
                    Age = 27,
                    Surname="Huseynov",
                    Salary = 1000
                },

                new Employee
                {
                    Id = 2,
                    Name="Tunzale Memmedova",
                    Age = 24,
                    Surname="Memmedova",
                    Salary = 2000
                },

                new Employee
                {
                    Id = 3,
                    Name="Besir",
                    Age = 26,
                    Surname="Temirli",
                    Salary = 3000
                }
            };
        }
    }
}

