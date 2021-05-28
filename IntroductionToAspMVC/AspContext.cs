using IntroductionToAspMVC.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace IntroductionToAspMVC
{
    public class AspContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet <Address> Addresses { get; set; }

        public AspContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Jurassic Park",
                    ReleaseDate = new DateTime(1993, 1, 1),
                    Rating = 7.8,
                    Created = DateTime.Now,
                    Genre = Enums.Genre.ScienceFiction,
                },
                new Movie
                {
                    Id = 2,
                    Title = "Terminator 2",
                    ReleaseDate = new DateTime(1991, 1, 1),
                    Rating = 7.5,
                    Created = DateTime.Now,
                    Genre = Enums.Genre.Action,
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Thing",
                    ReleaseDate = new DateTime(1982, 1, 1),
                    Rating = 7.8,
                    Created = DateTime.Now,
                    Genre = Enums.Genre.Horror,
                });
        }
    }
}