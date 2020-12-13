using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndianMovies.Models;

namespace IndianMovies.Data
{
    public class IndianMoviesContext : DbContext
    {
        public IndianMoviesContext (DbContextOptions<IndianMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<IndianMovies.Models.Movies> Movies { get; set; }

        public DbSet<IndianMovies.Models.Ranking> Ranking { get; set; }

        public DbSet<IndianMovies.Models.UpcomingMovies> UpcomingMovies { get; set; }

        public DbSet<IndianMovies.Models.MoviesCollection> MoviesCollection { get; set; }
    }
}
