using System.Data.Entity;
using MoviesInventory.Domain;

namespace MoviesInventory.Web.Models
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext() : base("MoviesConnection")
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}