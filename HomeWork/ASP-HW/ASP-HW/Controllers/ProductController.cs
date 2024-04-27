using System;
using ASP_HW.Models;
using ASP_HW.ViewModels.Product;
using Microsoft.AspNetCore.Mvc;

namespace ASP_HW.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			var products = GetAllProducts();

			List<ProductVM> product = new();

			foreach (var item in products)
			{
				product.Add(new ProductVM
				{
					Name=item.Name,
					Price=item.Price,
					Count=item.Count,
					Description=item.Description
				});
			}
			return View(product);
		}




		private List<Product> GetAllProducts()
		{
			return new List<Product>
			{
				new Product
				{
					Id=1,
					Name="Iphone",
					Price=2000,
					Count=10,
					Description="Phone"
				},


                new Product
                {
                    Id=2,
                    Name="Samsung",
                    Price=1000,
                    Count=102,
                    Description="Phone"
                },


                new Product
                {
                    Id=3,
                    Name="Nokia",
                    Price=200,
                    Count=13,
                    Description="Phone"
                }
            };
		}
	}
}

