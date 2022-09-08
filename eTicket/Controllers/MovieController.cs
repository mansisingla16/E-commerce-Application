using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [Authorize]
    [Route("api/admin/[controller]")]
    [ApiController]
    public class moviecontroller : ControllerBase
    {
            private readonly AppDbContext _db;
            public moviecontroller(AppDbContext db)
            {
                _db = db;
            }

            [HttpGet] 
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
                return _db.Movies.FirstOrDefault(x => x.Movie_Id == Id);
            }
        
             [HttpPost] //admin
            public Movie Post(Movie a)
            {
                _db.Movies.Add(a);
                _db.SaveChanges();
                return _db.Movies.FirstOrDefault(x => x.Movie_Id == a.Movie_Id);
            }

            [HttpDelete("{Id}")]
            public Movie Delete(int Id)
            {
                var a = _db.Movies.Find(Id);
                _db.Movies.Remove(a);
                _db.SaveChanges();
                return a;
            }

            [HttpPut("{Id}")]
            public Movie Put(int Id, Movie a)
            {
                _db.Entry(a).State = EntityState.Modified;
                _db.SaveChanges();
                return a;
            }
    }
}