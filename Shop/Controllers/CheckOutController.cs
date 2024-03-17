using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shop.DataAccess;
using Shop.Models;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Controllers {
    public class CheckOutController : Controller {
        private readonly OrderService orderService;
        private readonly ProductService productService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly CartService cartService;
        private readonly RecDataService recDataService;

        public CheckOutController(CartService cartService, OrderService orderService, ProductService productService,
            UserManager<ApplicationUser> userManager, RecDataService recDataService) {
            this.orderService = orderService;
            this.userManager = userManager;
            this.recDataService = recDataService;
            this.productService = productService;
            this.cartService = cartService;
        }

        public IActionResult Thanks() {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(Dictionary<int, int> items) {
            var orderViewModel = new OrderViewModel();
            ProductViewModel product;
            foreach (var item in items) {
                product = productService.GetProduct(item.Key);
                orderViewModel.OrderItems.Add(new OrderItemViewModel { Product = product, Amount = item.Value, Id = item.Key });
            }

            return View(orderViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> SaveOrder(Dictionary<int, int> items, OrderViewModel orderViewModel) {
            ProductViewModel product;
            var userId = userManager.GetUserId(User);
            foreach (var item in items) {
                product = productService.GetProduct(item.Key);
                orderService.AddProductToOrder(userId, product, item.Value);
            }

            orderService.AddInformation(userId, orderViewModel);
            cartService.DeleteCart(userId);
            await recDataService.AddRecData(userId);
            return RedirectToAction("Thanks");
        }
    }
}