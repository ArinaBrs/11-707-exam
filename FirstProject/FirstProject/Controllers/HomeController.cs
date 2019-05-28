using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FirstProject.Interfaces;
using FirstProject.Models;
using FirstProject.ViewModels;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
        DBContext db;

        public HomeController(DBContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.Merchandise.ToList());
        }

        [HttpGet]
        public IActionResult AddMerchandise()
        {
            return View();
        }

        [HttpPost]
        public string AddMerchandise(Merchandise newMerchandise)
        {
            db.Merchandise.Add(newMerchandise);
            db.SaveChanges();
            return "Блюдо добавлено в корзину";
        }


        [Authorize(Roles = "Admin")]
        public IActionResult CreateDish(string name, int cost)
        {
            return View("Edit", new Dish());
        }
       
        public IActionResult Error()
        {
            return View();
        }

    }
}
