using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTicket.Controllers
{
    [Route("api/User/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly AppDbContext _db;
        public CinemasController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IEnumerable<Cinema> GetCinema()
        {
            return (_db.Cinemas.ToList());
        }

        [HttpGet("{Id}")]
        public Cinema GtbyId(int Id)
        {
            return _db.Cinemas.FirstOrDefault(x => x.Id == Id);
        }
    }
}
