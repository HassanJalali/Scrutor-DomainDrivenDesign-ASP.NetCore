namespace Production.Framework.Core.ApplicationService
{
    public interface IUnitOfWork
    {
        void Commit();
        void RollBack();
    }
}
