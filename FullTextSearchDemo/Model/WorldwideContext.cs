using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.IO;
using System.Reflection;

namespace FullTextSearchDemo.Model
{
    public partial class WorldwideContext : DbContext
    {
        static WorldwideContext()
        {
               DbInterception.Add(new FtsInterceptor());
        }
        public WorldwideContext()
            : base("name=WorldwideContext")
        {
        
        }
        public virtual DbSet<Shipment> Shipments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          //  modelBuilder.Configurations.Add(new InformationMap());
        }
    }

}
