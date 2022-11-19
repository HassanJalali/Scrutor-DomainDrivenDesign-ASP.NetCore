using Production.Framework.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Production.Framework.AssemblyHelper;
using Production.Framework.Core.Persistence;

namespace Production.Persistence
{
    public class ProductionDbContext : DbContextBase
    {
        public ProductionDbContext(DbContextOptions<ProductionDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var entityMapping = DetectEntityMapping();

            entityMapping.ForEach(a =>
            {
                modelBuilder.ApplyConfiguration(a);

            });
        }


        protected List<dynamic> DetectEntityMapping()
        {

            var assemblyHelper = new AssemblyDiscovery("Production*.dll");
            var getType = assemblyHelper.DiscoverTypes<IEntityMapping>("Production")
                .Select(Activator.CreateInstance)
                .Cast<dynamic>()
                .ToList();

            return getType;
        }
    }
}
