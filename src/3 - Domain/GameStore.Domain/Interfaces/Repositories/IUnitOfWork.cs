namespace GameStore.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IGameRepository Games { get; }
        void Dispose();
    }
}