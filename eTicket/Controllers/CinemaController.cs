﻿using eTicket.Data;
using eTicket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly AppDbContext _db;
        public CinemaController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IEnumerable<Cinema> GetCinema()
        {
            return (_db.Cinemas.ToList());
        }

        [HttpGet("{id}")]
        public Cinema GtbyId(int Id)
        {
            return _db.Cinemas.FirstOrDefault(x => x.Id == Id);
        }

        [HttpPost]

        public Cinema Post(Cinema a)
        {
            _db.Cinemas.Add(a);
            _db.SaveChanges();
            return _db.Cinemas.FirstOrDefault(x => x.Id == a.Id);
        }
        [HttpDelete("{id}")]

        public Cinema Delete(int Id)
        {
            var a = _db.Cinemas.Find(Id);
            _db.Cinemas.Remove(a);
            _db.SaveChanges();
            return a;
        }

        [HttpPut("{id}")]

        public Cinema Put(int id, Cinema a)
        {
            _db.Entry(a).State = EntityState.Modified;
            _db.SaveChanges();
            return a;
        }
    }
}