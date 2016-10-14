namespace FilmDatabas.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FilmDatabas.DataAccessKayer.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccessKayer.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Movies.AddOrUpdate(
              p => p.Title,
              new Movie
              {
                  Title = "Action Andrew Peters",
                  Length = 34,
                  Genre = Genre.Action,
                  AgeLimit = 12,
                  MetaScore = 56
              },
              new Movie
              {
                  Title = "Drama Andrew Peters",
                  Length = 34,
                  Genre = Genre.Drama,
                  AgeLimit = 12,
                  MetaScore = 56
              },
              new Movie
              {
                  Title = "Motor Andrew Peters",
                  Length = 34,
                  Genre = Genre.Motor,
                  AgeLimit = 12,
                  MetaScore = 56
              },
              new Movie
              {
                  Title = "Sport Andrew Peters",
                  Length = 34,
                  Genre = Genre.Drama,
                  AgeLimit = 12,
                  MetaScore = 56
              },
              new Movie
              {
                  Title = "Violence Andrew Peters",
                  Length = 34,
                  Genre = Genre.Violence,
                  AgeLimit = 12,
                  MetaScore = 56
              }

            );
            //
        }
    }
}
