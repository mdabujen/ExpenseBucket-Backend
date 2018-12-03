using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.Core.Repositories
{
    public interface IBackupRepository : IRepository<Backup>
    {
        List<Backup> GetByDate(int count, int offset, DateTime date);
        Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date);

        Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, CancellationToken cancellationToken);

        List<Backup> GetByTitle(int count, int offset, string title);
        Task<List<Backup>> GetByTitleAsync(int count, int offset, string title);
        Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, CancellationToken cancellationToken);

        List<Backup> GetByAccount(int count, int offset, Account account);
        Task<List<Backup>> GetByAccountAsync(int count, int offset, Account account);

        Task<List<Backup>> GetByAccountAsync(int count, int offset, Account account,
            CancellationToken cancellationToken);

    }
}
