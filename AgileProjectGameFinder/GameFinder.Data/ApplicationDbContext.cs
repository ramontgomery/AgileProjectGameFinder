using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using GameFinder.Data.Entities;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
=======
>>>>>>> f39af17b5a2df6ce07530f2d1d8db53d3be27530
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GamesEntity>().ToTable("Games");
        }
    }
}