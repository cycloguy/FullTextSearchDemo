namespace FullTextSearchDemo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FullTextSearchDemo.Model.WorldwideContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FullTextSearchDemo.Model.WorldwideContext context)
        {
            var sql = "CREATE FULLTEXT CATALOG Shipments_catalog";
            context.Database.ExecuteSqlCommand(sql);
            sql = "CREATE FULLTEXT INDEX ON[dbo].[Shipments] ([FromName], [ToName]) " +
                 "KEY INDEX [PK_dbo.Shipments] ON Shipments_catalog;";
            context.Database.ExecuteSqlCommand(sql);
        }
    }
}
