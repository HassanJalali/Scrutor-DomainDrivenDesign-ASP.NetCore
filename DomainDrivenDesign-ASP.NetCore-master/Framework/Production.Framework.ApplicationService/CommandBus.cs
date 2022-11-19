using Production.Framework.Core.ApplicationService;
using Production.Framework.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production.Framework.ApplicationService
{
    public class CommandBus : ICommandBus
    {
        private readonly IDIContainer _dicontainer;

        public CommandBus(IDIContainer dicontainer)
        {
            _dicontainer = dicontainer;
        }
        public void Dispatch<TCommand>(TCommand command) where TCommand : Command
        {
            var commandHandler = _dicontainer.Resolve<ICommandHandler<TCommand>>();
            var transactionCommandHandler = new TransactionCommandHandler<TCommand>(commandHandler, _dicontainer);
            transactionCommandHandler.Execute(command);
        }
    }
}
