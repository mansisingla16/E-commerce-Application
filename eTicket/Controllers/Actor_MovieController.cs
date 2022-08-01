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
    public class Actor_MovieController : ControllerBase
    {
        private readonly AppDbContext _db;
        public Actor_MovieController(AppDbContext db)
        {
            _db = db;
        }
        /*[HttpGet("{Id}")]
        public List<Actor_Movie> GetMovieListByActorId(int Id)
        {
            return _db.Actor_Movies.Where(x => x.ActorId == Id).ToList();
        }*/

        [HttpGet("{Id}")]
        public List<Actor_Movie> GetActorListByMovieId(int Id)
        {
            return _db.Actor_Movies.Where(x => x.MovieId == Id).ToList();
        }
    }
}
