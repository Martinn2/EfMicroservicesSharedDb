using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserAddressMicroservice.Models;
using UserMicroservice.Models;

namespace UserAddressMicroservice
{
    public class UserAddressDbContext : DbContext
    {
        public DbSet<UserAddress> Address => Set<UserAddress>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer($"server=localhost;Database=userMicroserviceDb;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Ignore<User>();


            modelBuilder.Entity<UserAddress>()
                .HasOne(x => x.User)
                .WithOne()
                .HasForeignKey<UserAddress>(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
