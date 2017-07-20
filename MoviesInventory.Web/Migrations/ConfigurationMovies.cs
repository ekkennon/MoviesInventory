namespace MoviesInventory.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationMovies : DbMigrationsConfiguration<MoviesInventory.Web.Models.MovieDbContext>
    {
    
        public ConfigurationMovies()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MoviesInventory.Web.Models.MovieDbContext";
        }

        protected override void Seed(MoviesInventory.Web.Models.MovieDbContext context)
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
        }
    }
}
