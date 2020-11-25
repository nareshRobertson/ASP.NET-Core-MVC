using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ActivityTwo.Controllers {

	[Route("[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase {

		private readonly ILogger<ProductsController> _logger;

		public ProductsController(ILogger<ProductsController> logger) {
			_logger = logger;
		}

		[HttpGet]
		public IActionResult Get(int? id, string? name) {
			List<Products> products;
			var context = new NorthwindContext();

			using (context) {
				// Get the full list of products with their supplier
				// and category from the database
				products = context.Products.Include("Supplier").Include("Category").ToList();

				// Return the full list if there are no parameters
				if (id == null && name == null) {
					return Ok(products);
				}

				// Check and filter for both name and id
				else if (id != null && name != null) {
					Products product = products.SingleOrDefault(p => 
							p.ProductId == id && p.ProductName == name);
					if (product != null) {
						return Ok(product);
					}
					else
						return NotFound();
				}

				// Check and filter for id only
				else if (id != null) {
					Products product = products.SingleOrDefault(p => 
							p.ProductId == id);
					if (product != null) {
						return Ok(product);
					}
					else
						return NotFound();
				}

				// Check and filter for name only
				else if (name != null) {
					Products product = products.SingleOrDefault(p => p.ProductName == name);
					if (product != null) {
						return Ok(product);
					}
					else
						return NotFound();
				}

				else
					return NotFound();
			}

			
		}
	}
}
