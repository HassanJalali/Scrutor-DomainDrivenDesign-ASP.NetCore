
using Production.Framework.Core.ApplicationService;
using Production.Framework.Core.Facade;

namespace Production.Framework.Facade
{
    public abstract class FacadeCommandBase : ICommandFacade
    {
        protected readonly ICommandBus _commandBus;

        protected FacadeCommandBase(ICommandBus commandBus)
        {
            _commandBus = commandBus;
        }
    }
}

