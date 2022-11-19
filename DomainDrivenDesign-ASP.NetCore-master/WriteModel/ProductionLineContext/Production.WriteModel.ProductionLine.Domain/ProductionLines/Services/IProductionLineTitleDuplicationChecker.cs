using Production.Framework.Core.Domain;

namespace Production.WriteModel.ProductionLine.Domain.ProductionLines.Services
{
    public interface IProductionLineTitleDuplicationChecker : IDomainService
    {
        bool IsDuplicated(string productionLineTitle);
    }
}
