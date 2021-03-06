﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class TicketDetailContext : DbContext
    {
        public TicketDetailContext(DbContextOptions<TicketDetailContext> options) : base(options)
        {

        }

        public DbSet<TicketDetail> TicketDetails { get; set; }
    }
}
