using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using LexiconMovieDb.DAL;
using LexiconMovieDb.Models;

namespace LexiconMovieDb.Migrations {

    internal sealed class Configuration : DbMigrationsConfiguration<LexiconMovieDb.DAL.MovieDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LexiconMovieDb.DAL.MovieDbContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            context.Movies.AddOrUpdate(
                m => m.Title,
                new Movie {
                    Title = "Return of the killing tomatoes",
                    Length = 90,
                    Genre = Genre.Horror,
                    AgeLimit = AgeLimit.FromFifteen,
                    MetaScore = 16
                },
                new Movie {
                    Title = "Finalizer 7",
                    Length = 95,
                    Genre = Genre.Action,
                    AgeLimit = AgeLimit.FromFifteen,
                    MetaScore = 7
                },
                new Movie {
                    Title = "The Lord of the Earrings",
                    Length = 91,
                    Genre = Genre.Drama,
                    AgeLimit = AgeLimit.FromEleven,
                    MetaScore = 80
                },
                new Movie {
                    Title = "Be Happy",
                    Length = 101,
                    Genre = Genre.Comedy,
                    AgeLimit = AgeLimit.FromSeven,
                    MetaScore = 90
                }
                );
        }
    }
}
