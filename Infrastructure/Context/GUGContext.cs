using Infrastructure.Models.System;
using Infrastructure.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class GUGContext : DbContext
    {
        public GUGContext() { }
        public GUGContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasIndex(c => c.StartTime);
            modelBuilder.Entity<Trip>().HasIndex(c => c.EndTime);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Zone> Zones { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
