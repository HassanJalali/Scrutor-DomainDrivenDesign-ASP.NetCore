using Production.WriteModel.ProductionLine.Domain.ProductionLines.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.WriteModel.ProductionlineContext.Domain.Services.ProductionLines
{
    public class ProductionLineTitleDuplicationChecker : IProductionLineTitleDuplicationChecker
    {
        private readonly IProductionLineRepository _productionLineRepository;

        public ProductionLineTitleDuplicationChecker(IProductionLineRepository productionLineRepository)
        {
            _productionLineRepository = productionLineRepository;
        }

        public bool IsDuplicated(string productionLineTitle)
        {
           return _productionLineRepository.IsProductionLineTitleDuplicated(pl => pl.ProductionLineTitle == productionLineTitle);
        }
    }
}
