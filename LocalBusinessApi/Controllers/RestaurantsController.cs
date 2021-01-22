using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalBusinessApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LocalBusinessApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private LocalBusinessApiContext _db;

        public RestaurantsController(LocalBusinessApiContext db)
        {
          _db = db;
        }

        // GET api/restaurants
        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> Get(string keybusiness)
        {
          var query = _db.Restaurants.AsQueryable();

          if (keybusiness != null)
          {
            query = query.Where(entry => entry.KeyBusiness = keybusiness);
          }
            return query.ToList();
        }

        // GET api/restaurants/5
        [HttpGet("{id}")]
        public ActionResult<Restaurant> Get(int id)
        {
            return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
        }

        // POST api/restaurants
        [HttpPost]
        public void Post([FromBody] Restaurant restaurant)
        {
          _db.Restaurants.Add(restaurant);
          _db.SaveChanges();
        }

        // PUT api/restaurants/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Restaurant restaurant)
        {
          restaurant.RestaurantId = id;
          _db.Entry(restaurant).State = EntityState.Modified;
          _db.SaveChanges();
        }

        // DELETE api/restaurants/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
          _db.Restaurants.Remove(restaurantToDelete);
          _db.SaveChanges();
        }
    }
}