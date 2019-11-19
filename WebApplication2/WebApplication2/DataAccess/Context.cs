using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.DataAccess
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    Name = "Аскар",
                    PhoneNumber = "+77017778899"
                },
                new Client
                {
                    Name = "Олег Скидан",
                    PhoneNumber = "+77015554411"
                });

            modelBuilder.Entity<Driver>().HasData(
                new Driver
                {
                    Name = "Graf Aleksandr III",
                    PhoneNumber = "+77013336655",
                    Car = "Range Rover Voque 3",
                    CarNumber = "z001mmm"
                },
                new Driver
                {
                    Name = "Kasym Jomart",
                    PhoneNumber = "+77010202022",
                    Car = "Maybach Original Reserve",
                    CarNumber = "kz001"
                });
        }
    }
}
