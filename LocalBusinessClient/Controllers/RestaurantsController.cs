using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessClient.Models;

namespace LocalBusinessClient.Controllers
{
    public class RestaurantsController : Controller
    {
        public IActionResult Index()
        {
          var allRestaurants = Restaurant.GetRestaurants();
          return View(allRestaurants);
        }

        [HttpPost] // Create new restaurant
        public IActionResult Index(Restaurant restaurant)
        {
          Restaurant.Post(restaurant);
          return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
          var restaurant = Restaurant.GetDetails(id);
          return View(restaurant);
        }

        public IActionResult Edit(int id)
        {
          var restaurant = Restaurant.GetDetails(id);
          return View(restaurant);
        }

        [HttpPost]
        public IActionResult Details(int id, Restaurant restaurant)
        {
          restaurant.RestaurantId = id;
          Restaurant.Put(restaurant);
          return RedirectToAction("Details", id);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
          Restaurant.Delete(id);
          return RedirectToAction("Index");
        }

        public IActionResult Random() // Chooses randomly from list of restaurants and redirects to its details page
        {
          var randomRestaurant = Restaurant.GetRandom();
          var randomDetails = Restaurant.GetDetails(randomRestaurant.RestaurantId);
          return View("Details", randomDetails);
        }
    }
}