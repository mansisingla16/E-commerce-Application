﻿using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    [Authorize(Roles=UserRoles.Admin)]
    [Authorize]
    [Route("api/admin/[controller]")]
    [ApiController]
    public class producercontroller : ControllerBase
    {
        private readonly AppDbContext _db;
        public producercontroller( AppDbContext db)
        {
            _db = db;
        }        
        [HttpGet]       
        public IEnumerable<Producer> GetProducers(string likeName)
        {
            if (string.IsNullOrEmpty(likeName))
                return _db.Producers.ToList();
            else
                return _db.Producers.Where(x => x.FullName.Contains(likeName)).ToList();
        }
        
        [HttpGet("{Id}")]       
        public Producer GetbyId(int Id)
        {
            return _db.Producers.FirstOrDefault(x => x.Producer_Id == Id);
        }
       
        [HttpPost]
        public Producer PostProducer(Producer a)
        {
            _db.Producers.Add(a);
            _db.SaveChanges();
            return _db.Producers.FirstOrDefault(x => x.Producer_Id == a.Producer_Id);
        }

        [HttpDelete("{Id}")]
        public Producer Delete(int Id)
        {
            var a = _db.Producers.Find(Id);
            _db.Producers.Remove(a);
            _db.SaveChanges();
            return a;
        }

        [HttpPut("{Id}")]
        public Producer Put(int Id, Producer a)
        {
            _db.Entry(a).State = EntityState.Modified;
            _db.SaveChanges();
            return a;
        }
    }
}
