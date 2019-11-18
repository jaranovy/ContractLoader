using System.Data.Entity.Migrations;
using ContractLoader.DbModel;

namespace ContractLoader.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ContractDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ContractDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
