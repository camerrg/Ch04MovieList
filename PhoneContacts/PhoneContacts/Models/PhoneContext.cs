using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PhoneContacts.Models
{
    public class PhoneContext : DbContext
    {
        public PhoneContext(DbContextOptions<PhoneContext> options)
            : base(options)
        { }

        public DbSet<Phone> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().HasData(
               new Phone
               {
                   PhoneId = 4,
                   Name = "Peter Pan",
                   PhoneNum = 5155552314,
                   Address = "123 Main St",
                   Notes = "Contact on Monday"
               },

               new Phone
               {
                   PhoneId = 3,
                   Name = "Jack Beanstalk",
                   PhoneNum = 5558675309,
                   Address = "555 Gingerbread Lane",
                   Notes = "Meet for Lunch" 
               }
               );
        }
    }
}
