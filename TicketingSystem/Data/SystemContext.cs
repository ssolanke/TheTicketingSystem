﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.Data
{
    public class SystemContext : IdentityDbContext<Technician>
    {
        private string _connectionString;

        /// <summary>
        /// The collection of clients
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        /// The collection of tickets
        /// </summary>
        public DbSet<Ticket> Tickets { get; set; }

        /// <summary>
        /// The collection of TechnicianTicket pivot models
        /// </summary>
       // public DbSet<TechnicianTicketTime> TechnicianTicketTimes { get; set; }

        /// <summary>
        /// The constructor for this context
        /// </summary>
        /// <param name="options">The options to create the context around</param>
        /// <returns>A new instance of this context</returns>
        public SystemContext(DbContextOptions<SystemContext> options) : base(options)
        { }


    }
}
