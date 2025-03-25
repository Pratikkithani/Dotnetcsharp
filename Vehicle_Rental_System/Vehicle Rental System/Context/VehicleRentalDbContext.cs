using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vehicle_Rental_System.Configurations;
using Vehicle_Rental_System.Models;

namespace Vehicle_Rental_System.Context
{
    public class VehicleRentalDbContext : IdentityDbContext
    {
        public VehicleRentalDbContext(DbContextOptions<VehicleRentalDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<Booking>()
        //        .Property(b => b.TotalAmount)
        //        .HasComputedColumnSql("[EndDate] - [StartDate] * (SELECT RentalPricePerDay FROM Vehicles WHERE VehicleId = [VehicleId])");
        //}
    }
}
