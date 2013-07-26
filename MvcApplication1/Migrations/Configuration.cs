namespace MvcApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MvcApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcApplication1.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcApplication1.Models.MovieDBContext context)
        {
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
            //

            context.Movies.AddOrUpdate(i => i.Title,
         new Movie
         {
             Title = "When Harry Met Sally",
             ReleaseDate = DateTime.Parse("1989-1-11"),
             Genre = "Romantic Comedy",
             Rating = "YG",
             Price = 7.99M
         },

          new Movie
          {
              Title = "Ghostbusters ",
              ReleaseDate = DateTime.Parse("1984-3-13"),
              Genre = "Comedy",
              Rating = "XE",
              Price = 8.99M
          },

          new Movie
          {
              Title = "Ghostbusters 2",
              ReleaseDate = DateTime.Parse("1986-2-23"),
              Genre = "Comedy",
              Rating = "ZG",
              Price = 9.99M
          },

        new Movie
        {
            Title = "Rio Bravo",
            ReleaseDate = DateTime.Parse("1959-4-15"),
            Genre = "Western",
            Rating = "FY",
            Price = 3.09M
        }
    );
        }
    }
}
