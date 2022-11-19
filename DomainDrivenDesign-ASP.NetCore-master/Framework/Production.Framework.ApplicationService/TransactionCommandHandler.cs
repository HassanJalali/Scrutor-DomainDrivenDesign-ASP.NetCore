using Production.Framework.Core.ApplicationService;
using Production.Framework.Core.DependencyInjection;

namespace Production.Framework.ApplicationService
{
    public class TransactionCommandHandler<TCommand> : ICommandHandler<TCommand> where TCommand : Command
    {
        private readonly ICommandHandler<TCommand> _commandHandler;
        private readonly IDIContainer _diContainer;

        public TransactionCommandHandler(ICommandHandler<TCommand> commandHandler, IDIContainer diContainer)
        {
            _commandHandler = commandHandler;
            _diContainer = diContainer;
        }
        public void Execute(TCommand command)
        {
            var unitOfWork = _diContainer.Resolve<IUnitOfWork>();
            try
            {
                _commandHandler.Execute(command);
                unitOfWork.Commit();
            }
            catch
            {
                unitOfWork.RollBack();
                throw;
            }
        }
    }
}
