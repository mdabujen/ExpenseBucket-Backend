using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.Core.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {
        #region GetAllCategoriesByBackup
        List<Category> GetAllCategoriesByBackup(Backup backup);
        Task<List<Category>> GetAllCategoriesByBackupAsync(Backup backup);
        Task<List<Category>> GetAllCategoriesByBackupAsync(Backup backup, CancellationToken cancellationToken);

        List<Category> GetAllCategoriesByBackup(int count, int offset, Backup backup);
        Task<List<Category>> GetAllCategoriesByBackupAsync(int count, int offset, Backup backup);
        Task<List<Category>> GetAllCategoriesByBackupAsync(int count, int offset, Backup backup, CancellationToken cancellationToken); 
        #endregion
    }
}
