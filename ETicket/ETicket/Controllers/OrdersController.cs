using ETicket.Data.Cart;
using ETicket.Data.Services;
using ETicket.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicket.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMoviesService moviesService;
        private readonly ShoppingCart shoppingCart;
        private readonly IOrdersService orderService;

        public OrdersController(
            IMoviesService moviesService, 
            ShoppingCart shoppingCart, 
            IOrdersService orderService)
        {
            this.moviesService = moviesService;
            this.shoppingCart = shoppingCart;
            this.orderService = orderService;
        }

        public IActionResult ShoppingCart()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };
            return View(response);
        }

        public async Task<RedirectToActionResult> AddItemToShoppingCart(int id)
        {
            var item = await moviesService.GetMovieByIdAsync(id);

            if (item != null)
            {
                shoppingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        // RedirectToActionResult and IActionResult work the same
        public async Task<RedirectToActionResult> RemoveItemFromShoppingCart(int id)
        {
            var item = await moviesService.GetMovieByIdAsync(id);

            if (item != null)
            {
                shoppingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            var items = shoppingCart.GetShoppingCartItems();
            string userId = "";
            string userEmailAddress = "";
            await orderService.StoreOrderAsync(items, userId, userEmailAddress);
            await shoppingCart.ClearShoppingCartAsync();
            return View("OrderCompleted");
        }

        public async Task<IActionResult> Index()
        {
            string userId = "";
            var orders = await orderService.GetOrdersByUserIdAsync(userId);
            return View(orders);
        }
    }
}
