using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace TinDo.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Dispose();
        void Dispose(bool disposing);
        int SaveChanges();
        IRepository<TEntity> Repository<TEntity>() where TEntity : IObjectState;
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepository<TEntity> RepositoryAsync<TEntity>() where TEntity : IObjectState;
        void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        bool Commit();
        void Rollback();
    }
}