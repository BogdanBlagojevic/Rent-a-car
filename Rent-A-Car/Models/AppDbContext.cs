using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rent_A_Car.Models;
using System;

namespace Rent_A_Car.Models
{
    public class AppDbContext:IdentityDbContext<AppUser,AppRole,int, 
        IdentityUserClaim<int>,AppUserRole,IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        public AppDbContext(DbContextOptions options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .IsRequired();

            builder.Entity<AppRole>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(u => u.RoleId)
                .IsRequired();


            builder.Entity<Car>()
                .HasData(
                    new Car { Id = 1, Brand = "Mercedes-Benz", Model = "E-Class", Date = 2020, Price = 120, GearShift = "Manual", Country = "Serbia", City = "Novi Sad", Address = "Bulevar Oslobodjenja 15"},
                    new Car { Id = 2, Brand = "BMW", Model = "X3", Date = 2018, Price = 100, GearShift = "Manual", Country = "Serbia", City = "Belgrade", Address = "Knez Mihajlova 12"},
                    new Car { Id = 3, Brand = "Mercedes-Benz", Model = "GLC 4x4 GPS", Date = 2021, Price = 150, GearShift = "Automatic", Country = "Serbia", City = "Novi Sad", Address = "Skolska 1"},
                    new Car { Id = 4, Brand = "Hyundai", Model = "Elantra", Date = 2019, Price = 90, GearShift = "Manual", Country = "Serbia", City = "Nis", Address = "Avalska 23"},
                    new Car { Id = 5, Brand = "Peugeot", Model = "308", Date = 2020, Price = 80, GearShift = "Automatic", Country = "Serbia", City = "Novi Sad", Address = "Bulevar Evrope 45"},
                    new Car { Id = 6, Brand = "Audi", Model = "SQ5", Date = 2021, Price = 140, GearShift = "Automatic", Country = "Serbia", City = "Belgrade", Address = "Andricev Venac 17"}

                );
            builder.Entity<Reservation>()
                .HasData(
                    new Reservation { Id = 1, AppUserId = 3, CarId = 2, DateOfPickup = new DateTime(2023, 06, 05, 13, 30, 0), DateOfReturn = new DateTime(2023, 08, 05, 13, 30, 0), TotalPrice = 200 },
                    new Reservation { Id = 2, AppUserId = 5, CarId = 1, DateOfPickup = new DateTime(2023, 11, 10, 17, 0, 0), DateOfReturn = new DateTime(2023, 11, 15, 17, 0, 0), TotalPrice = 600 },
                    new Reservation { Id = 3, AppUserId = 1, CarId = 4, DateOfPickup = new DateTime(2023, 07, 05, 11, 15, 0), DateOfReturn = new DateTime(2023, 07, 11, 11, 15, 0), TotalPrice = 540 }
                );
        }
    }
}
