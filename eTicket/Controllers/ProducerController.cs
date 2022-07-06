using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ProducerController( AppDbContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        [Route("Public/[controller]")]
        public IEnumerable<Producer> GetProducers()
        {
            return (_db.Producers.ToList());
        }
        
        [HttpGet("{id}")]
        [Route("Public/[controller]")]
        public Producer GetbyId(int Id)
        {
            return _db.Producers.FirstOrDefault(x => x.Id == Id);
        }
        [Authorize]
        [Authorize(Roles = UserRoles.Admin)]
        [HttpPost]
        [Route("Admin/[controller]")]
        public Producer PostProducer(Producer a)
        {
            _db.Producers.Add(a);
            _db.SaveChanges();
            return _db.Producers.FirstOrDefault(x => x.Id == a.Id);
        }
        [HttpDelete("{id}")]
        [Route("Admin/[controller]")]
        public Producer Delete(int Id)
        {
            var a = _db.Producers.Find(Id);
            _db.Producers.Remove(a);
            _db.SaveChanges();
            return a;
        }

        [HttpPut("{id}")]
        [Route("Admin/[controller]")]
        public Producer Put(int id, Producer a)
        {
            _db.Entry(a).State = EntityState.Modified;
            _db.SaveChanges();
            return a;
        }
    }
}
