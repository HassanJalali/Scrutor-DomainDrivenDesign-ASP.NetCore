using Production.Framework.Core.ApplicationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.WriteModel.ProductionLineContext.AppSer.Contract.ProductionLines
{
    public class CreateProductionLineComand : Command
    {

        public int CostCenter { get; set; }
        public string ProductionLineTitle { get; set; }
    }
}
