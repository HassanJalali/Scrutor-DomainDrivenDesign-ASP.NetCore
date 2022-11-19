using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Production.Persistence
{
    public class ProductionDesignTimeDbContext : IDesignTimeDbContextFactory<ProductionDbContext>
    {
        public ProductionDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductionDbContext>();
            optionsBuilder.UseSqlServer("server=.;initial catalog =Production_Developer;integrated security=true");
            return new ProductionDbContext(optionsBuilder.Options);
        }
    }
}
