using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core;
using ExpenseBucket.Core.Repositories;
using ExpenseBucket.EF.Repositories;

namespace ExpenseBucket.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private IUserRepository _accounts;
        private IBackupRepository _backups;
        private ICategoryRepository _categories;
        private IItemRepository _items;
        private IUserClaimRepository _userClaims;

        public IUserRepository Accounts 
            => _accounts ?? (_accounts = new UserRepository(_context));

        public IBackupRepository Backups
            => _backups ?? (_backups = new BackupRepository(_context));

        public ICategoryRepository Categories
            => _categories ?? (_categories = new CategoryRepository(_context));

        public IItemRepository Items
            => _items ?? (_items = new ItemRepository(_context));

        public IUserClaimRepository UserClaims
            => _userClaims ?? (_userClaims = new UserClaimRepository(_context));

        public UnitOfWork(string nameOrConnectionString)
        {
            _context = new AppDbContext(nameOrConnectionString);
        }

        public void Dispose()
        {
            _accounts = null;
            _backups = null;
            _categories = null;
            _items = null;
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return _context.SaveChangesAsync(cancellationToken);
        }        
    }
}
