using Microsoft.EntityFrameworkCore;
using MoviesManagement.Data.Models;
using System;

namespace MoviesManagement.Data
{
    public class MovieDbContext  : DbContext 
    {
        public MovieDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Movie> Movies { get; set; } 
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
