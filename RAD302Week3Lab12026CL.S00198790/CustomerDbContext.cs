using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Tracker.WebAPIClient;

namespace RAD302Week3Lab12026CL.S00198790
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ActivityAPIClient.Track(
                StudentID: "S00198790",
                StudentName: "Ronan Keaveney",
                activityName: "Rad302 2026 Week 3 Lab 1",
                Task: "Creating Customer DB Schema"
            );

            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=CustomerCorDB-S00198790;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(
                new Customer { ID = 1, Name = "John Murphy", Address = "Galway", CreditRating = 700 },
                new Customer { ID = 2, Name = "Mary Kelly", Address = "Dublin", CreditRating = 650 },
                new Customer { ID = 3, Name = "Tom O'Brien", Address = "Cork", CreditRating = 720 },
                new Customer { ID = 4, Name = "Sarah Walsh", Address = "Limerick", CreditRating = 680 },
                new Customer { ID = 5, Name = "David Ryan", Address = "Waterford", CreditRating = 710 }
            );
        }
    }
}
