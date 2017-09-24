namespace GameStore.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IGameRepository Games { get; }
        void Dispose();
    }
}