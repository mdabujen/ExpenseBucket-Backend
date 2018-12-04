using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;
using ExpenseBucket.Core.Repositories;

namespace ExpenseBucket.EF.Repositories
{
    internal class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(AppDbContext context) : base(context)
        {
        }

        #region GetByBackup
        public List<Item> GetByBackup(Backup backup)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .ToList();
        }


        public Task<List<Item>> GetByBackupAsync(Backup backup)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .ToListAsync();
        }

        public Task<List<Item>> GetByBackupAsync(Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Item> GetByBackup(int count, int offset, Backup backup)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Item>> GetByBackupAsync(int count, int offset, Backup backup)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Item>> GetByBackupAsync(int count, int offset, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }
        #endregion

        #region GetByType
        public List<Item> GetByType(string type, Backup backup)
        {
            return Set
                .Where(x => x.Type == type && x.Backup.Id == backup.Id)
                .ToList();
        }

        public Task<List<Item>> GetByTypeAsync(string type, Backup backup)
        {
            return Set
                .Where(x => x.Type == type && x.Backup.Id == backup.Id)
                .ToListAsync();
        }

        public Task<List<Item>> GetByTypeAsync(string type, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Type == type && x.Backup.Id == backup.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Item> GetByType(int count, int offset, string type, Backup backup)
        {
            return Set
                .Where(x => x.Type == type && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Item>> GetByTypeAsync(int count, int offset, string type, Backup backup)
        {
            return Set
                .Where(x => x.Type == type && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Item>> GetByTypeAsync(int count, int offset, string type, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Type == type && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }
        #endregion

        #region GetByTitle
        public Item GetByTitle(string title, Backup backup)
        {
            return Set
                .SingleOrDefault(x => x.Title.ToLower() == title.ToLower() && x.Backup.Id == backup.Id);
        }

        public Task<Item> GetByTitleAsync(string title, Backup backup)
        {
            return Set
                .SingleOrDefaultAsync(x => x.Title.ToLower() == title.ToLower() && x.Backup.Id == backup.Id);
        }

        public Task<Item> GetByTitleAsync(string title, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .SingleOrDefaultAsync(x => x.Title.ToLower() == title.ToLower() && x.Backup.Id == backup.Id
                , cancellationToken);
        }
        #endregion

        #region GetByCategory
        public List<Item> GetByCategory(Category category, Backup backup)
        {
            return Set
                .Where(x => x.Category.Id == category.Id && x.Backup.Id == backup.Id)
                .ToList();
        }

        public Task<List<Item>> GetByCategoryAsync(Category category, Backup backup)
        {
            return Set
                .Where(x => x.Category.Id == category.Id && x.Backup.Id == backup.Id)
                .ToListAsync();
        }

        public Task<List<Item>> GetByCategoryAsync(Category category, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Category.Id == category.Id && x.Backup.Id == backup.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Item> GetByCategory(int count, int offset, Category category, Backup backup)
        {
            return Set
                .Where(x => x.Category.Id == category.Id && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Item>> GetByCategoryAsync(int count, int offset, Category category, Backup backup)
        {
            return Set
                .Where(x => x.Category.Id == category.Id && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Item>> GetByCategoryAsync(int count, int offset, Category category, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Category.Id == category.Id && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }
        #endregion

        #region GetByDateCreated
        public List<Item> GetByDateCreated(DateTime date, Backup backup)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Backup.Id == backup.Id)
                .ToList();
        }

        public Task<List<Item>> GetByDateCreatedAsync(DateTime date, Backup backup)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Backup.Id == backup.Id)
                .ToListAsync();
        }

        public Task<List<Item>> GetByDateCreatedAsync(DateTime date, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Backup.Id == backup.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Item> GetByDateCreated(int count, int offset, DateTime date, Backup backup)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Item>> GetByDateCreatedAsync(int count, int offset, DateTime date, Backup backup)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Item>> GetByDateCreatedAsync(int count, int offset, DateTime date, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }
        #endregion

        #region GetByParentId
        public List<Item> GetByParentId(int parentId, Backup backup)
        {
            return Set
                .Where(x => x.ParentId == parentId && x.Backup.Id == backup.Id)
                .ToList();
        }

        public Task<List<Item>> GetByParentIdAsync(int parentId, Backup backup)
        {
            return Set
                .Where(x => x.ParentId == parentId && x.Backup.Id == backup.Id)
                .ToListAsync();
        }

        public Task<List<Item>> GetByParentIdAsync(int parentId, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.ParentId == parentId && x.Backup.Id == backup.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Item> GetByParentId(int count, int offset, int parentId, Backup backup)
        {
            return Set
                .Where(x => x.ParentId == parentId && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Item>> GetByParentIdAsync(int count, int offset, int parentId, Backup backup)
        {
            return Set
                .Where(x => x.ParentId == parentId && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Item>> GetByParentIdAsync(int count, int offset, int parentId, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.ParentId == parentId && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }
        #endregion

        #region GetByCostRange
        public List<Item> GetByCostRange(int minCost, int maxCost, Backup backup)
        {
            return Set
                .Where(x => x.Cost >= minCost && x.Cost <= maxCost && x.Backup.Id == backup.Id)
                .ToList();
        }

        public Task<List<Item>> GetByCostRangeAsync(int minCost, int maxCost, Backup backup)
        {
            return Set
                .Where(x => x.Cost >= minCost && x.Cost <= maxCost && x.Backup.Id == backup.Id)
                .ToListAsync();
        }

        public Task<List<Item>> GetByCostRangeAsync(int minCost, int maxCost, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Cost >= minCost && x.Cost <= maxCost && x.Backup.Id == backup.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Item> GetByCostRange(int count, int offset, int minCost, int maxCost, Backup backup)
        {
            return Set
                .Where(x => x.Cost >= minCost && x.Cost <= maxCost && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Item>> GetByCostRangeAsync(int count, int offset, int minCost, int maxCost, Backup backup)
        {
            return Set
                .Where(x => x.Cost >= minCost && x.Cost <= maxCost && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Item>> GetByCostRangeAsync(int count, int offset, int minCost, int maxCost, Backup backup,
            CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Cost >= minCost && x.Cost <= maxCost && x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        } 
        #endregion
    }
}
