namespace Production.Framework.Core.ApplicationService
{
    public interface ICommandHandler<TCommand>: IHandler where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
