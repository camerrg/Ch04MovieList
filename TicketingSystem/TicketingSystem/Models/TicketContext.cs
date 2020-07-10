using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TicketingSystem.Models
{
    public class TicketContext: DbContext
    {
        public TicketContext(DbContextOptions<TicketContext> options) : base(options) { }
        public DbSet<Ticket>Tickets { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sprint>().HasData(
                new Sprint { SprintId = "1a", Name = "1A" },
                new Sprint { SprintId = "2a", Name = "2A" },
                new Sprint { SprintId = "3a", Name = "3A" },
                new Sprint { SprintId = "4a", Name = "4A" });

            //status builder
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "to do", Name = "To Do"},
                new Status { StatusId = "in progress", Name = "In progress" },
                new Status { StatusId = "quality assurance", Name = "Quality Assurance"},
                new Status { StatusId = "done", Name = "Done"});


        }

        

    }
}
