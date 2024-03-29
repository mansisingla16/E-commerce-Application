﻿using eTicket.Data;
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
    public class actorscontroller : ControllerBase
    {
        private readonly AppDbContext _db;
        public actorscontroller(AppDbContext db)
        {
            _db = db;
        }
        //Get the records from API
        [HttpGet]
        public IEnumerable<Actor> GetActor(string likeName)
        {
            if (string.IsNullOrEmpty(likeName))
                return _db.Actors.ToList();
            else
            return _db.Actors.Where(x => x.FullName.Contains(likeName)).ToList();
        }
        [HttpGet("{Id}")]
        public Actor GetbyId(int Id)
        {
            return _db.Actors.FirstOrDefault(x => x.Actor_Id == Id);
        }

    }
}
