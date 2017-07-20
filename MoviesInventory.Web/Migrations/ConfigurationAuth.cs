namespace MoviesInventory.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationAuth : DbMigrationsConfiguration<MoviesInventory.Web.Models.ApplicationDbContext>
    {
        public ConfigurationAuth()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MoviesInventory.Web.Models.ApplicationDbContext";
        }

        protected override void Seed(MoviesInventory.Web.Models.ApplicationDbContext context)
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
