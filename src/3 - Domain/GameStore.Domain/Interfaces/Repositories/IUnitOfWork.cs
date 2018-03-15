namespace GameStore.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        ICompanyRepository Companies { get; }
        IGameRepository Games { get; }
        IGenreRepository Genres { get; }
        IPlataformRepository Plataforms { get; }
        IUserRepository Users { get ;}
        void Dispose();
    }
}