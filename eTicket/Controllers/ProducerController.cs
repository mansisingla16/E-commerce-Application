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
    public class ProducerController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ProducerController( AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IEnumerable<Producer> GetProducers()
        {
            return (_db.Producers.ToList());
        }
    }
}
