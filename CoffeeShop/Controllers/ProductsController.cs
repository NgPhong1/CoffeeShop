using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using YourProjectNamespace.Repositories;

namespace CoffeeShop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Detail(int id)
        {
            var product = productRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
    }
}
