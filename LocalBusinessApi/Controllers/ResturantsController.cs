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
    public class ResturantsController : ControllerBase
    {
        private LocalBusinessApiContext _db;

        public ResturantsController(LocalBusinessApiContext db)
        {
          _db = db;
        }

        // GET api/resturants
        [HttpGet]
        public ActionResult<IEnumerable<Resturant>> Get()
        {
            return _db.Resturants.ToList();
        }

        // GET api/resturants/5
        [HttpGet("{id}")]
        public ActionResult<Resturant> Get(int id)
        {
            return _db.Resturants.FirstOrDefault(entry => entry.ResturantId == id);
        }

        // POST api/resturants
        [HttpPost]
        public void Post([FromBody] Resturant resturant)
        {
          _db.Resturants.Add(resturant);
          _db.SaveChanges();
        }

        // PUT api/resturants/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Resturant resturant)
        {
          resturant.ResturantId = id;
          _db.Entry(resturant).State = EntityState.Modified;
          _db.SaveChanges();
        }

        // DELETE api/resturants/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          var resturantToDelete = _db.Resturants.FirstOrDefault(entry => entry.ResturantId == id);
          _db.Resturants.Remove(resturantToDelete);
          _db.SaveChanges();
        }
    }
}