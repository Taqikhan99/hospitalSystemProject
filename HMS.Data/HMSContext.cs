using HMS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data
{
    public class HMSContext : DbContext
    {
        public HMSContext() : base("HSMConnection")
        {
        }

        public DbSet<AccomodationTypes> AccomodationType { get; set; }
        public DbSet<AccomodationPackages> AccomodationPackage { get; set; }

        public DbSet<Accomodations> Accomodation { get; set; }

        public DbSet<Booking> Bookings { get; set; }

    }
}
