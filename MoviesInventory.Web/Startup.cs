using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesInventory.Web.Startup))]
namespace MoviesInventory.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
