using Production.Framework.Core.ApplicationService;
using Production.Framework.Facade;
using Production.WriteModel.ProductionLineContext.AppSer.Contract.ProductionLines;
using Production.WriteModel.ProductionLineContext.Facade.Contract.ProductionLines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.WriteModel.ProductionLineContext.Facade.ProductionLines
{
    public class ProductionLineCommandFacade : FacadeCommandBase, IProductionLineCommandFacade
    {
        public ProductionLineCommandFacade(ICommandBus commandBus) : base(commandBus)
        {


        }

        public void CreateProductionLine(CreateProductionLineComand comand)
        {
            _commandBus.Dispatch(comand);
        }
    }
}
