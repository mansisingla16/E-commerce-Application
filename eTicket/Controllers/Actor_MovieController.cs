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

        [HttpGet("{Id}")]
        public List<Actor> GetActorListByMovieId(int Id)
        {
            var actormovie = _db.Actor_Movies.Where(x => x.MovieId == Id).ToList();
            List<Actor> actorsList = new List<Actor>();
            foreach (var item in actormovie)
            {
                var actor = _db.Actors.FirstOrDefault(x => x.Id == item.ActorId);
                actorsList.Add(actor);

            }
            return actorsList;

        }
    }
}