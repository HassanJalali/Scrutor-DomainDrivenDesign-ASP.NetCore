using Microsoft.AspNetCore.Mvc;
using Production.Framework.Core.Persistence;
using Production.WriteModel.ProductionLineContext.AppSer.Contract.ProductionLines;
using Production.WriteModel.ProductionLineContext.Facade.Contract.ProductionLines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.ProductionLineContext
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductionLineController : Controller
    {
        private readonly IProductionLineCommandFacade _productionLineCommandFacade;
        

        public ProductionLineController(IProductionLineCommandFacade productionLineCommandFacade)
        {
            _productionLineCommandFacade = productionLineCommandFacade;
            
        }

        [HttpPost]
        public void CreateProductionLine(CreateProductionLineComand comand)
        {
            _productionLineCommandFacade.CreateProductionLine(comand);
        }
    }
}
