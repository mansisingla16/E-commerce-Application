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
    [Route("api/user/[controller]")]
    [ApiController]
    public class moviescontroller : ControllerBase
    {
        private readonly AppDbContext _db;
        public moviescontroller(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet] //user

        public IEnumerable<Movie> GetMovie(string likeName)
        {
            if (string.IsNullOrEmpty(likeName))
                return _db.Movies.ToList();
            else
                return _db.Movies.Where(x => x.Name.Contains(likeName)).ToList();
        }

        [HttpGet("{Id}")]

        public Movie GetbyId(int Id)
        {
            return _db.Movies.FirstOrDefault(x => x.Id == Id);
        }
    }
}
