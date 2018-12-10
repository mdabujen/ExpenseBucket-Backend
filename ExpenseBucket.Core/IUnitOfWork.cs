using System;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Repositories;

namespace ExpenseBucket.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Accounts { get; }
        IBackupRepository Backups { get; }
        ICategoryRepository Categories { get; }
        IItemRepository Items { get; }
        IUserClaimRepository UserClaims { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
