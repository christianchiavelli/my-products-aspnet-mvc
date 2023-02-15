using ChiavelliDev.Infra.Data.Context;
using System.Data.Entity.Migrations;
namespace ChiavelliDev.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MeuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}
