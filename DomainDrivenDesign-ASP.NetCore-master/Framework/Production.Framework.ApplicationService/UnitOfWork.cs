using Production.Framework.Core.ApplicationService;
using Production.Framework.Core.Persistence;

namespace Production.Framework.ApplicationService
{   
        public class UnitOfWork : IUnitOfWork
        {
            private readonly IDbContext _dbContext;

            public UnitOfWork(IDbContext dbContext)
            {
                _dbContext = dbContext;
            }
            public void Commit()
            {
                _dbContext.SavaChanges();
            }

            public void RollBack()
            {
                _dbContext.Dispose();
            }
        }
}
