using Production.Framework.Core.Domain;
using Production.Framework.Domain;
using Production.WriteModel.ProductionLine.Domain.ProductionLines.Exceptions;
using Production.WriteModel.ProductionLine.Domain.ProductionLines.Services;

namespace Production.WriteModel.ProductionLine.Domain.ProductionLines
{
    public class ProductionLine : EntityBase , IAggrigateRoot
    {
        private readonly IProductionLineTitleDuplicationChecker _productionLineTitleDuplicationChecker;

        public ProductionLine(int costCenter, string productionLineTitle , IProductionLineTitleDuplicationChecker productionLineTitleDuplicationChecker)
        {
            SetCostCenter(costCenter);
            SetProductionLineTitle(productionLineTitle);
            _productionLineTitleDuplicationChecker = productionLineTitleDuplicationChecker;
        }   
         protected ProductionLine()
          {

          }

        private void SetProductionLineTitle(string productionLineTitle)
        {
            if (string.IsNullOrWhiteSpace(productionLineTitle))
            {
                throw new ProductionLineTitleCantBeNullOrWhiteSpaceException();
            }

            if (_productionLineTitleDuplicationChecker.IsDuplicated(productionLineTitle))
            {
                throw new ProductionLineTitleIsDuplicatedException();
            }

            ProductionLineTitle = productionLineTitle;
        }

        private void SetCostCenter(int costCenter)
        {
            if (costCenter.ToString().Length > 4)
            {
                throw new CostCenterNumberCantBeLessOrBiggerThan4();
            }

            CostCenter = costCenter;
        }

        public int CostCenter { get ;private set; }
        public string ProductionLineTitle { get;private set; }
    }
}
