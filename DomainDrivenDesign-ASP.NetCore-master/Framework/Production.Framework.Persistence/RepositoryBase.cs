using Production.Framework.Core.Domain;
using Production.Framework.Core.Persistence;
using Production.Framework.Domain;

namespace Production.Framework.Persistence
{
    public abstract class RepositoryBase<TAggrigateRoot> : IRepository where TAggrigateRoot : EntityBase , IAggrigateRoot
    {
        protected readonly DbContextBase _dbContext;

        protected RepositoryBase(IDbContext dbContext)
        {
            _dbContext =(DbContextBase) dbContext;
        }
         
        protected void Create(TAggrigateRoot aggrigateRoot)
        {
            _dbContext.Set<TAggrigateRoot>().Add(aggrigateRoot);
        }

        protected void Remove(TAggrigateRoot aggrigateRoot)
        {
            _dbContext.Set<TAggrigateRoot>().Remove(aggrigateRoot);
        }

    }
}
