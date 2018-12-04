using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.Core.Repositories
{
    public interface IItemRepository : IRepository<Item>
    {
        #region GetByBackup
        List<Item> GetByBackup(Backup backup);
        Task<List<Item>> GetByBackupAsync(Backup backup);
        Task<List<Item>> GetByBackupAsync(Backup backup, CancellationToken cancellationToken);

        List<Item> GetByBackup(int count, int offset, Backup backup);
        Task<List<Item>> GetByBackupAsync(int count, int offset, Backup backup);
        Task<List<Item>> GetByBackupAsync(int count, int offset, Backup backup, CancellationToken cancellationToken);
        #endregion

        #region GetByType
        List<Item> GetByType(string type, Backup backup);
        Task<List<Item>> GetByTypeAsync(string type, Backup backup);
        Task<List<Item>> GetByTypeAsync(string type, Backup backup, CancellationToken cancellationToken);

        List<Item> GetByType(int count, int offset, string type, Backup backup);
        Task<List<Item>> GetByTypeAsync(int count, int offset, string type, Backup backup);
        Task<List<Item>> GetByTypeAsync(int count, int offset, string type, Backup backup, CancellationToken cancellationToken);
        #endregion

        #region GetByTitle
        Item GetByTitle(string title, Backup backup);
        Task<Item> GetByTitleAsync(string title, Backup backup);
        Task<Item> GetByTitleAsync(string title, Backup backup, CancellationToken cancellationToken);
        #endregion

        #region GetByCategory
        List<Item> GetByCategory(Category category, Backup backup);
        Task<List<Item>> GetByCategoryAsync(Category category, Backup backup);
        Task<List<Item>> GetByCategoryAsync(Category category, Backup backup, CancellationToken cancellationToken);

        List<Item> GetByCategory(int count, int offset, Category category, Backup backup);
        Task<List<Item>> GetByCategoryAsync(int count, int offset, Category category, Backup backup);

        Task<List<Item>> GetByCategoryAsync(int count, int offset, Category category, Backup backup,
            CancellationToken cancellationToken);
        #endregion

        #region GetByDateCreated
        List<Item> GetByDateCreated(DateTime date, Backup backup);
        Task<List<Item>> GetByDateCreatedAsync(DateTime date, Backup backup);
        Task<List<Item>> GetByDateCreatedAsync(DateTime date, Backup backup, CancellationToken cancellationToken);

        List<Item> GetByDateCreated(int count, int offset, DateTime date, Backup backup);
        Task<List<Item>> GetByDateCreatedAsync(int count, int offset, DateTime date, Backup backup);

        Task<List<Item>> GetByDateCreatedAsync(int count, int offset, DateTime date, Backup backup,
            CancellationToken cancellationToken);
        #endregion

        #region GetByParentId
        List<Item> GetByParentId(int parentId, Backup backup);
        Task<List<Item>> GetByParentIdAsync(int parentId, Backup backup);
        Task<List<Item>> GetByParentIdAsync(int parentId, Backup backup, CancellationToken cancellationToken);

        List<Item> GetByParentId(int count, int offset, int parentId, Backup backup);
        Task<List<Item>> GetByParentIdAsync(int count, int offset, int parentId, Backup backup);
        Task<List<Item>> GetByParentIdAsync(int count, int offset, int parentId, Backup backup, CancellationToken cancellationToken);
        #endregion

        #region GetByCostRange
        List<Item> GetByCostRange(int minCost, int maxCost, Backup backup);
        Task<List<Item>> GetByCostRangeAsync(int minCost, int maxCost, Backup backup);
        Task<List<Item>> GetByCostRangeAsync(int minCost, int maxCost, Backup backup, CancellationToken cancellationToken);

        List<Item> GetByCostRange(int count, int offset, int minCost, int maxCost, Backup backup);
        Task<List<Item>> GetByCostRangeAsync(int count, int offset, int minCost, int maxCost, Backup backup);

        Task<List<Item>> GetByCostRangeAsync(int count, int offset, int minCost, int maxCost, Backup backup,
            CancellationToken cancellationToken); 
        #endregion
    }
}
