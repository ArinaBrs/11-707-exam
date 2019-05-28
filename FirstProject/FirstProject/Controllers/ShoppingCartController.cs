using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstProject.Interfaces;
using FirstProject.Models;
using FirstProject.ViewModels;

namespace FirstProject.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IMerchandiseRepository merchandise;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IMerchandiseRepository merchandise, ShoppingCart shoppingCart)
        {
            this.merchandise = merchandise;
            this.shoppingCart = shoppingCart;
        }

        [Authorize]
        public ViewResult Index()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        [Authorize]
        public RedirectToActionResult AddToShoppingCart(int id)
        {
            var selected = merchandise.Merchandises.FirstOrDefault(p => p.Id == id);
            if (selected != null)
            {
                shoppingCart.AddToCart(selected, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int id)
        {
            var selected = merchandise.Merchandises.FirstOrDefault(p => p.Id == id);
            if (selected != null)
            {
                shoppingCart.RemoveFromCart(selected);
            }
            return RedirectToAction("Index");
        }

    }
}