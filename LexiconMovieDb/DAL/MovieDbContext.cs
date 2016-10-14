using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LexiconMovieDb.Models;

namespace LexiconMovieDb.DAL {
    public class MovieDbContext : DbContext {

        public MovieDbContext() : base("LMovieDB") {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}