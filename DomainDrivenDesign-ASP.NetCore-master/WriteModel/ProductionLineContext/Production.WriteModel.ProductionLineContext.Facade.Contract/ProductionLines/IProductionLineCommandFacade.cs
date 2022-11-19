using Production.WriteModel.ProductionLineContext.AppSer.Contract.ProductionLines;

namespace Production.WriteModel.ProductionLineContext.Facade.Contract.ProductionLines
{
    public interface IProductionLineCommandFacade
    {
        void CreateProductionLine(CreateProductionLineComand comand);
    }
}
