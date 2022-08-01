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
    [Route("api/user/[controller]")]
    [ApiController]
    public class cinemascontroller : ControllerBase
    {
        private readonly AppDbContext _db;
        public cinemascontroller(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public  IEnumerable<Cinema> GetCinema(string likeName)
        {
            if (string.IsNullOrEmpty(likeName))
                return _db.Cinemas.ToList();
            else
                return _db.Cinemas.Where(x => x.Name.Contains(likeName)).ToList();
        }

        [HttpGet("{Id}")]
        public Cinema GtbyId(int Id)
        {
            return _db.Cinemas.FirstOrDefault(x => x.Id == Id);
        }
    }
}
