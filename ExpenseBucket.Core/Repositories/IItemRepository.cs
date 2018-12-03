using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.Core.Repositories
{
    public interface IItemRepository : IRepository<Item>
    {
        List<Item> GetByBackup(int count, int offset, Backup backup);
        Task<List<Item>> GetByBackupAsync(int count, int offset, Backup backup);
        Task<List<Item>> GetByBackupAsync(int count, int offset, Backup backup, CancellationToken cancellationToken);

        List<Item> GetByType(int count, int offset, string type);
        Task<List<Item>> GetByTypeAsync(int count, int offset, string type);
        Task<List<Item>> GetByTypeAsync(int count, int offset, string type, CancellationToken cancellationToken);

        Item GetByTitle(string title);
        Task<Item> GetByTitleAsync(string title);
        Task<Item> GetByTitleAsync(string title, CancellationToken cancellationToken);

        List<Item> GetByCategory(int count, int offset, Category category);
        Task<List<Item>> GetByCategoryAsync(int count, int offset, Category category);

        Task<List<Item>> GetByCategoryAsync(int count, int offset, Category category,
            CancellationToken cancellationToken);

        List<Item> GetByDateCreated(int count, int offset, DateTime dateCreated);
        Task<List<Item>> GetByDateCreatedAsync(int count, int offset, DateTime dateCreated);

        Task<List<Item>> GetByDateCreatedAsync(int count, int offset, DateTime dateCreated,
            CancellationToken cancellationToken);

        List<Item> GetByParentId(int count, int offset, int parentId);
        Task<List<Item>> GetByParentIdAsync(int count, int offset, int parentId);
        Task<List<Item>> GetByParentIdAsync(int count, int offset, int parentId, CancellationToken cancellationToken);

        List<Item> GetByCostRange(int count, int offset, int minCost, int maxCost);
        Task<List<Item>> GetByCostRangeAsync(int count, int offset, int minCost, int maxCost);

        Task<List<Item>> GetByCostRangeAsync(int count, int offset, int minCost, int maxCost,
            CancellationToken cancellationToken);

        List<Item> GetByHierarchy(int count, int offset, string hierarchy);
        Task<List<Item>> GetByHierarchyAsync(int count, int offset, string hierarchy);

        Task<List<Item>> GetByHierarchyAsync(int count, int offset, string hierarchy,
            CancellationToken cancellationToken);
    }
}
