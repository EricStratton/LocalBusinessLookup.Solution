using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessClient.Models;

namespace LocalBusinessClient.Controllers
{
    public class ShopsController : Controller
    {
        public IActionResult Index()
        {
          var allShops = Shop.GetShops();
          return View(allShops);
        }

        [HttpPost] // Create new shop
        public IActionResult Index(Shop shop)
        {
          Shop.Post(shop);
          return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
          var shop = Shop.GetDetails(id);
          return View(shop);
        }

        public IActionResult Edit(int id)
        {
          var shop = Shop.GetDetails(id);
          return View(shop);
        }

        [HttpPost]
        public IActionResult Details(int id, Shop shop)
        {
          shop.ShopId = id;
          Shop.Put(shop);
          return RedirectToAction("Details", id);
        }

        public IActionResult Random() // Chooses randomly from list of shops and redirects to its details page
        {
          var randomShop = Shop.GetRandom();
          var randomDetails = Shop.GetDetails(randomShop.ShopId);
          return View("Details", randomDetails);
        }
    }
}
