using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.Core.Repositories
{
    public interface IBackupRepository : IRepository<Backup>
    {
        #region GetAllBackup
        List<Backup> GetAllBackup(int id);
        Task<List<Backup>> GetAllBackupAsync(int id);
        Task<List<Backup>> GetAllBackupAsync(int id, CancellationToken cancellationToken); 
        #endregion

        #region GetByDate
        List<Backup> GetByDate(DateTime date, int id);
        Task<List<Backup>> GetByDateAsync(DateTime date, int id);
        Task<List<Backup>> GetByDateAsync(DateTime date, int id, CancellationToken cancellationToken);

        List<Backup> GetByDate(int count, int offset, DateTime date, int id);
        Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, int id);

        Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, int id, CancellationToken cancellationToken);
        #endregion

        #region GetByTitle
        List<Backup> GetByTitle(string title, int id);
        Task<List<Backup>> GetByTitleAsync(string title, int id);
        Task<List<Backup>> GetByTitleAsync(string title, int id, CancellationToken cancellationToken);

        List<Backup> GetByTitle(int count, int offset, string title, int id);
        Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, int id);
        Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, int id, CancellationToken cancellationToken);
        #endregion

        #region GetByAccount
        List<Backup> GetByAccount(int id);
        Task<List<Backup>> GetByAccountAsync(int id);
        Task<List<Backup>> GetByAccountAsync(int id, CancellationToken cancellationToken);

        List<Backup> GetByAccount(int count, int offset, int id);
        Task<List<Backup>> GetByAccountAsync(int count, int offset, int id);

        Task<List<Backup>> GetByAccountAsync(int count, int offset, int id,
            CancellationToken cancellationToken); 
        #endregion

    }
}
