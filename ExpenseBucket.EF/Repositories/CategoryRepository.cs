using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;
using ExpenseBucket.Core.Repositories;

namespace ExpenseBucket.EF.Repositories
{
    internal class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public List<Category> GetAllCategoriesByBackup(Backup backup)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .ToList();
        }

        public Task<List<Category>> GetAllCategoriesByBackupAsync(Backup backup)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .ToListAsync();
        }

        public Task<List<Category>> GetAllCategoriesByBackupAsync(Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Category> GetAllCategoriesByBackup(int count, int offset, Backup backup)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToList();

        }

        public Task<List<Category>> GetAllCategoriesByBackupAsync(int count, int offset, Backup backup)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Category>> GetAllCategoriesByBackupAsync(int count, int offset, Backup backup, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Backup.Id == backup.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }
    }
}
