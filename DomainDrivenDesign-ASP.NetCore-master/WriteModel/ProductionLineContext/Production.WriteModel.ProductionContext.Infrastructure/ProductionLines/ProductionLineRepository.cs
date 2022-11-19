using Microsoft.EntityFrameworkCore;
using Production.Framework.Core.Persistence;
using Production.Framework.Persistence;
using Production.WriteModel.ProductionLine.Domain.ProductionLines.Services;
using System.Linq.Expressions;

namespace Production.WriteModel.ProductionContext.Infrastructure.ProductionLines
{
    public class ProductionLineRepository : RepositoryBase<Production.WriteModel.ProductionLine.Domain.ProductionLines.ProductionLine>, IProductionLineRepository
    {
        public ProductionLineRepository(IDbContext dbContext) : base(dbContext)
        {
        }

        public void Create(ProductionLine.Domain.ProductionLines.ProductionLine productionLine)
        {
            base.Create(productionLine);
        }

        public bool IsProductionLineTitleDuplicated(Expression<Func<ProductionLine.Domain.ProductionLines.ProductionLine, bool>> expression)
        {
            return _dbContext.Set<ProductionLine.Domain.ProductionLines.ProductionLine>().Any(expression);
        }
    }
}
