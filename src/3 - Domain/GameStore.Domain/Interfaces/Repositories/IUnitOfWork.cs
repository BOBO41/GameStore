namespace GameStore.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IDeveloperRepository Developers { get; }
        IGameRepository Games { get; }
        IGenreRepository Genres { get; }
        IPlataformRepository Plataforms { get; }
        IPublisherRepository Publishers { get; }
        IUserRepository Users { get ;}
        void Dispose();
    }
}