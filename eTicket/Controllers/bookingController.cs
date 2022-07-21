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
    [Route("api/[controller]")]
    [ApiController]
    public class bookingController : ControllerBase
    {
        private readonly AppDbContext _db;
        public bookingController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IEnumerable<Actor_Movie> GetActor_Movies()
        {
            return _db.Actor_Movies.ToList();
        }

    }
}
