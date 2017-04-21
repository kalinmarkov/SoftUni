using AutoTrader.Data;
using AutoTrader.Migrations;
using Microsoft.Owin;
using Owin;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(AutoTrader.Startup))]
namespace AutoTrader
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarsDbContext, Configuration>());

            ConfigureAuth(app);
        }
    }
}
