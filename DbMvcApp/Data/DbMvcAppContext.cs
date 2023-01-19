using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbMvcApp.Models;

namespace DbMvcApp.Data
{
    public class DbMvcAppContext : DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> Users { get; set; }

        public DbMvcAppContext (DbContextOptions<DbMvcAppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Email = "admin@example.com",
                    Password = User.HashPassword("qwerty"),
                    Role = Role.Admin
                },
                new User
                {
                    Id = 2,
                    Email = "moderator@example.com",
                    Password = User.HashPassword("qwerty"),
                    Role = Role.Moderator
                },
                new User
                {
                    Id = 3,
                    Email = "user@example.com",
                    Password = User.HashPassword("qwerty"),
                    Role = Role.User
                }
            );
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Rush Hour",
                    ReleaseDate = new(1998, 9, 18),
                    Genre = "Comedy",
                    Price = 300
                }
            );
        }
    }
}
