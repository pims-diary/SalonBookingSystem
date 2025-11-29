using Microsoft.EntityFrameworkCore;
using Salon.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Salon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed two sample staff records
            modelBuilder.Entity<Staff>().HasData(
                new Staff { Id = 1, StaffId = "staff1", Password = "password1" },
                new Staff { Id = 2, StaffId = "staff2", Password = "password2" }
            );

            // Seed two sample promotions
            modelBuilder.Entity<Promotion>().HasData(
                new Promotion { Id = 1, Title = "Black Friday Sale", Description = "50% off all haircuts – one day only!" },
                new Promotion { Id = 2, Title = "Combo Offer", Description = "Haircut + Facial in a combo price for the weekend." },
                new Promotion { Id = 3, Title = "New Customer Special", Description = "20% off on the first visit of any new customer." }
            );
        }
    }
}
