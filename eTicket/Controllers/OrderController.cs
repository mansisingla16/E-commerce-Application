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
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _db;
        public OrderController(AppDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public Order PostOrder(Order a)
        {
            _db.Orders.Add(a);
            _db.SaveChanges();
            return _db.Orders.FirstOrDefault(x => x.Order_Id == a.Order_Id);
        }
    }
}
