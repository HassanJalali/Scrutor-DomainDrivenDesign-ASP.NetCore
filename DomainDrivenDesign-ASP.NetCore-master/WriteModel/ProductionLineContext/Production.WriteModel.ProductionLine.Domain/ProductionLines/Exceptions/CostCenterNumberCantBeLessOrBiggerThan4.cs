using Production.Framework.Domain;
using Production.WriteModel.ProductionLine.Resources;

namespace Production.WriteModel.ProductionLine.Domain.ProductionLines.Exceptions
{
    public class CostCenterNumberCantBeLessOrBiggerThan4 : DomainException
    {
        public override string Message => ExceptionResource.CostCenterNumberCantBeLessOrBiggerThan4;
    }
    
}
