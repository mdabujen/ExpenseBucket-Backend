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
    internal class BackupRepository : Repository<Backup>, IBackupRepository
    {
        public BackupRepository(AppDbContext context) : base(context)
        {
        }

        public List<Backup> GetByDate(DateTime date, Account account)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == account.Id)
                .ToList();
        }

        public Task<List<Backup>> GetByDateAsync(DateTime date, Account account)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == account.Id)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByDateAsync(DateTime date, Account account, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == account.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByDate(int count, int offset, DateTime date, Account account)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, Account account)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, Account account, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByTitle(string title, Account account)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == account.Id)
                .ToList();
        }

        public Task<List<Backup>> GetByTitleAsync(string title, Account account)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == account.Id)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByTitleAsync(string title, Account account, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == account.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByTitle(int count, int offset, string title, Account account)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, Account account)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, Account account, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByAccount(Account account)
        {
            return Set
                .Where(x => x.Account.Id == account.Id)
                .ToList();
        }

        public Task<List<Backup>> GetByAccountAsync(Account account)
        {
            return Set
                .Where(x => x.Account.Id == account.Id)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByAccountAsync(Account account, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Account.Id == account.Id)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByAccount(int count, int offset, Account account)
        {
            return Set
                .Where(x => x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Backup>> GetByAccountAsync(int count, int offset, Account account)
        {
            return Set
                .Where(x => x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByAccountAsync(int count, int offset, Account account, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Account.Id == account.Id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }
    }
}
