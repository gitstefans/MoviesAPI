using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using moviesAPI.Entities;

namespace moviesAPI.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            :base(options)
        {          
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
                builder.Entity<Actor>(f =>
                {
                    f.HasKey(e => e.ActorId);
                });

                builder.Entity<Movie>( f =>
                {
                    f.HasKey(e => e.MovieId);
                });
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        
    }
}

