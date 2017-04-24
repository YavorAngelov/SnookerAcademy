using Microsoft.Owin;
using Owin;
using SnookerAcadWebApp.Migrations;
using SnookerAcadWebApp.Models;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(SnookerAcadWebApp.Startup))]
namespace SnookerAcadWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>());

            ConfigureAuth(app);
        }
    }
}
