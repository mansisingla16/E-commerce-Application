﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextoptions options):base(options)
        {
        }
    }
}
