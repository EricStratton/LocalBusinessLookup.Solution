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
    public class ShopsController : ControllerBase
    {
        private LocalBusinessApiContext _db;

        public ShopsController(LocalBusinessApiContext db)
        {
          _db = db;
        }

        // GET api/shops
        [HttpGet]
        public ActionResult<IEnumerable<Shop>> Get()
        {
            return _db.Shops.ToList();
        }

        // GET api/shops/5
        [HttpGet("{id}")]
        public ActionResult<Shop> Get(int id)
        {
            return _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
        }

        // POST api/shops
        [HttpPost]
        public void Post([FromBody] Shop shop)
        {
          _db.Shops.Add(shop);
          _db.SaveChanges();
        }

        // PUT api/shops/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Shop shop)
        {
          shop.ShopId = id;
          _db.Entry(shop).State = EntityState.Modified;
          _db.SaveChanges();
        }

        // DELETE api/shops/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          var shopToDelete = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
          _db.Shops.Remove(shopToDelete);
          _db.SaveChanges();
        }
    }
}