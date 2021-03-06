﻿//http://msdn.microsoft.com/en-us/data/jj591621

using Microsoft.AspNet.Identity.EntityFramework;

namespace MoviesInventory.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
        public class ApplicationUser : IdentityUser
    {
        public string Email { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}