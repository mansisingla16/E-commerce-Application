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
    public class SeatssController : ControllerBase
    {
        private readonly AppDbContext _db;

        public SeatssController(AppDbContext db) 
        {
            _db = db; 
        }

        [HttpGet] public IEnumerable<Seat> GetSeats(string likeName) 
        {
            return _db.Seats.ToList(); 
        }

        [HttpGet("{Id}")]

        public Seat GetbyId(int Id) 
        {
            return _db.Seats.FirstOrDefault(x => x.Id == Id);
        }

        [HttpPost] 
        //admin   
             public Seat Post(Seat a)  
             {    
            _db.Seats.Add(a);        
            _db.SaveChanges();      
            return _db.Seats.FirstOrDefault(x => x.Id == a.Id);       
             } 
    }
}

