using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    [Route("api/User/[controller]")]
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
        [HttpGet("{Id}")]
        public Actor GetbyId(int Id)
        {
            return _db.Actors.FirstOrDefault(x => x.Id == Id);
        }

    }
}
