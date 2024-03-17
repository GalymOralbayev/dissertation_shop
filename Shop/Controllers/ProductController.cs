
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Services;
using System;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productService;
        private readonly RecDataService recDataService;

        public ProductController(ProductService productService, RecDataService recDataService)
        {
            this.productService = productService;
            this.recDataService = recDataService;
        }

        public async Task<IActionResult> IndexAsync(int id)
        {
            var product = productService.GetProduct(id);
            var recProducts = await recDataService.GetRecommendedProducts(id);
            return View(new ProductViewModel()
            {
                Description = product.Description,
                File = product.File,
                Id = product.Id,
                ImagePath = product.ImagePath,
                Name = product.Name,
                Price = product.Price,
                RecProducts = recProducts
            });
        }
    }
}
