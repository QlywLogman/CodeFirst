using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class FoofyByteDbCountext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=STHQ0118-06;Initial Catalog=MyFoodyByteDb;" +
                "User ID=admin;Password=admin;" +
                "Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;" +
                "Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Fovarite> Fovarites { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<PhoneNumer> PhoneNumers { get; set; }
        public DbSet<Resturant> Resturantes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Media>()
                .HasOne(m => m.User)
                .WithOne(u => u.Media)
                .HasForeignKey<User>(u => u.MediaId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Review>()
                .HasOne<User>(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Resturant)
                .WithMany(r => r.Reviews)
                .HasForeignKey(r => r.ResturantId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Resturant>()
                .HasOne(r => r.Address)
                .WithOne(a => a.Resturant)
                .HasForeignKey<Resturant>(r => r.AddressId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Resturant>()
                .HasMany(r => r.Dishes)
                .WithOne(d => d.Resturant)
                .HasForeignKey(d => d.ResturantId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Resturant>()
                .HasMany(r => r.PhoneNumbers)
                .WithOne(pn => pn.Resturant)
                .HasForeignKey(pn => pn.ResturantId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Dish>()
                .HasOne(d => d.Photo)
                .WithOne(m => m.Dish)
                .HasForeignKey<Dish>(d => d.MeidaId)
                .OnDelete(DeleteBehavior.NoAction);
             modelBuilder.Entity<Dish>()
                .HasOne(d => d.Category)
                .WithMany(c => c.Dishes)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
                

        }

    }
}
