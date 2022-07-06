using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace eTicket.Controllers
{
    [Route("api/user/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ActorsController(AppDbContext db)
        {
            _db = db;
        }
        //Get the records from API
        [HttpGet]
        public IEnumerable<Actor> GetActor()
        {
            return _db.Actors.ToList();
        }
        [HttpGet("{id}")]
        public Actor GetbyId(int Id)
        {
            return _db.Actors.FirstOrDefault(x => x.Id == Id);
        }

        [HttpPost]
        public Actor PostActor(Actor a)
        {
            _db.Actors.Add(a);
            _db.SaveChanges();
            return _db.Actors.FirstOrDefault(x => x.Id == a.Id);
        }
        [HttpDelete("{id}")]
        public Actor Delete(int Id)
        {
            var a = _db.Actors.Find(Id);
            _db.Actors.Remove(a);
            _db.SaveChanges();
            return a;
        }

        [HttpPut("{id}")]
        public Actor Put(int id, Actor a)
        {
            _db.Entry(a).State = EntityState.Modified;
            _db.SaveChanges();
            return a;
        }
    }
}
