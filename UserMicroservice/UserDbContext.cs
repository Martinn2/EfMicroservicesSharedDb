using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using UserMicroservice.Models;

namespace UserMicroservice
{
    public class UserDbContext:DbContext
    {
        public DbSet<User> Users => Set<User>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer($"server=localhost;Database=userMicroserviceDb;Trusted_Connection=True;");
        }
    }
}
