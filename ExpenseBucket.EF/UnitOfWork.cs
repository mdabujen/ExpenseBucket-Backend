using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core;
using ExpenseBucket.Core.Repositories;

namespace ExpenseBucket.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        public IAccountRepository Accounts { get; }
        public IBackupRepository Backups { get; }
        public ICategoryRepository Categories { get; }
        public IItemRepository Items { get; }
        public int SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
