using System;
using ASP_HW.Models;
using ASP_HW.ViewModels.Book;
using Microsoft.AspNetCore.Mvc;

namespace ASP_HW.Controllers
{
	public class BookController : Controller
	{
		public IActionResult Index()
		{
            var books = GetAllBooks();
            List<BookVM> book = new List<BookVM>();

            foreach (var item in books)
            {
                book.Add(new BookVM
                {
                     Name = item.Name
                });
            }
            return View(book);
		}
        private List<Book> GetAllBooks()
        {
            return new List<Book>
        {
            new Book
            {
                Id=1,
                Name = "Sefiller"
            },

            new Book
            {
                Id=2,
                Name = "Isgendername"
            },

            new Book
            {
                Id=3,
                Name = "YeddiGozel"
            },

            new Book
            {
                Id=4,
                Name = "Xemse"
            }
        };
        }
    }



}

