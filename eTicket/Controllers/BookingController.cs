
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
    public class BookingController : ControllerBase
    {
        private readonly AppDbContext _db;

        public BookingController(AppDbContext db) { _db = db; }

        [HttpPost] 
        //admin        
        
        public Booking Post(Booking a)       
        {
            _db.Bookings.Add(a); 
            _db.SaveChanges();      
            return _db.Bookings.FirstOrDefault(x => x.Booking_Id == a.Booking_Id);       
        }
    }
}

