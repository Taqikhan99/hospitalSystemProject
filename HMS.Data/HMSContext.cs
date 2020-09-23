using HMS.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Data
{
    public class HMSContext : IdentityDbContext<HMSUser>
    {
        public HMSContext() : base("HSMConnection")
        {
        }

        public static HMSContext Create()
        {
            return new HMSContext();
        }

        public DbSet<AccomodationTypes> AccomodationType { get; set; }
        public DbSet<AccomodationPackages> AccomodationPackage { get; set; }

        public DbSet<Accomodations> Accomodation { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        


    }
}
