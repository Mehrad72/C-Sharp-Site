using Microsoft.EntityFrameworkCore;
using GBCSporting_Huskies.Models;

namespace GBCSporting_Huskies.Models
{
    public class SportingContext : DbContext
    {

        public SportingContext(DbContextOptions<SportingContext> options) : base(options) { }

        public DbSet<Technician> Technicians { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Technician>().HasData(
                new Technician
                {
                    TechnicianId = 1,
                    Firstname = "Candice",
                    Lastname = "Simone",
                    Phone = "722-427-7823",
                    Email = "candice_simone@domain.ca"
                }
                );

            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Firstname = "Johnathon",
                    Lastname = "Mclare",
                    Address = "553 Emerson Drive",
                    City = "Gotham",
                    State = "Washington",
                    Postalcode = "T6R 3F7",
                    CountryId = "United States",
                    Email = "johnxmclare@yahoo.com",
                    Phone = "5567921312"
                }
               );

            modelBuilder.Entity<Country>().HasData(
               new Country { CountryId = "Canada", Name = "Canada" },
               new Country { CountryId = "China", Name = "China" },
               new Country { CountryId = "Russia", Name = "Russia" },
               new Country { CountryId = "United States", Name = "United States" },
               new Country { CountryId = "United Kingdom", Name = "United Kingdom" },
               new Country { CountryId = "Mexico", Name = "Mexico" },
               new Country { CountryId = "France", Name = "France" },
               new Country { CountryId = "Italy", Name = "Italy" },
               new Country { CountryId = "Tukrey", Name = "Tukrey" },
               new Country { CountryId = "Japan", Name = "Japan" }
               );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Code = "222",
                    Name = "Laptop",
                    YearPr = (decimal)699.00,
                    RelDate = new DateTime(2022, 6, 10)
                });

        }

    }
}
