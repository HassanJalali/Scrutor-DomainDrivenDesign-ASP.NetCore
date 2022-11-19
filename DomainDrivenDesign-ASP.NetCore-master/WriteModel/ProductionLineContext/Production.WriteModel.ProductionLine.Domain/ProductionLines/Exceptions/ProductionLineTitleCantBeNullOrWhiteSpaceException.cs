using Production.Framework.Domain;
using Production.WriteModel.ProductionLine.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.WriteModel.ProductionLine.Domain.ProductionLines.Exceptions
{
    public class ProductionLineTitleCantBeNullOrWhiteSpaceException : DomainException
    {
        public override string Message =>ExceptionResource.ProductionLineTitleCantBeNullOrWhiteSpaceException;
    }

    

         public class ProductionLineTitleIsDuplicatedException : DomainException
    {
        public override string Message => ExceptionResource.ProductionLineTitleIsDuplicatedException;
    }
}
