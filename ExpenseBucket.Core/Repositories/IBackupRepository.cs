using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.Core.Repositories
{
    public interface IBackupRepository : IRepository<Backup>
    {
        #region GetByDate
        List<Backup> GetByDate(DateTime date, Account account);
        Task<List<Backup>> GetByDateAsync(DateTime date, Account account);
        Task<List<Backup>> GetByDateAsync(DateTime date, Account account, CancellationToken cancellationToken);

        List<Backup> GetByDate(int count, int offset, DateTime date, Account account);
        Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, Account account);

        Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, Account account, CancellationToken cancellationToken);
        #endregion

        #region GetByTitle
        List<Backup> GetByTitle(string title, Account account);
        Task<List<Backup>> GetByTitleAsync(string title, Account account);
        Task<List<Backup>> GetByTitleAsync(string title, Account account, CancellationToken cancellationToken);

        List<Backup> GetByTitle(int count, int offset, string title, Account account);
        Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, Account account);
        Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, Account account, CancellationToken cancellationToken);
        #endregion

        #region GetByAccount
        List<Backup> GetByAccount(Account account);
        Task<List<Backup>> GetByAccountAsync(Account account);
        Task<List<Backup>> GetByAccountAsync(Account account, CancellationToken cancellationToken);

        List<Backup> GetByAccount(int count, int offset, Account account);
        Task<List<Backup>> GetByAccountAsync(int count, int offset, Account account);

        Task<List<Backup>> GetByAccountAsync(int count, int offset, Account account,
            CancellationToken cancellationToken); 
        #endregion

    }
}
