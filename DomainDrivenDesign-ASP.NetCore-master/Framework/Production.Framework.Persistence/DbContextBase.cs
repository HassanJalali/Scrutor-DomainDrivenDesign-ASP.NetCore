using Microsoft.EntityFrameworkCore;
using Production.Framework.Core.Persistence;

namespace Production.Framework.Persistence
{
    public class DbContextBase : DbContext, IDbContext
    {
        public DbContextBase(DbContextOptions opt) : base(opt)
        {

        }

        public void Migrate()
        {
            base.Database.Migrate();
        }

        public int SavaChanges()
        {
           return base.SaveChanges();
        }
    }
}
