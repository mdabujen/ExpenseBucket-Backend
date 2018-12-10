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

        public List<Backup> GetAllBackup(int id)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .ToList();
        }

        public Task<List<Backup>> GetAllBackupAsync(int id)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .ToListAsync();
        }

        public Task<List<Backup>> GetAllBackupAsync(int id, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByDate(DateTime date, int id)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == id)
                .ToList();
        }

        public Task<List<Backup>> GetByDateAsync(DateTime date, int id)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == id)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByDateAsync(DateTime date, int id, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == id)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByDate(int count, int offset, DateTime date, int id)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, int id)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByDateAsync(int count, int offset, DateTime date, int id, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.DateCreated.Date == date.Date && x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByTitle(string title, int id)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == id)
                .ToList();
        }

        public Task<List<Backup>> GetByTitleAsync(string title, int id)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == id)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByTitleAsync(string title, int id, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == id)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByTitle(int count, int offset, string title, int id)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, int id)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByTitleAsync(int count, int offset, string title, int id, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Title.ToLower() == title.ToLower() && x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByAccount(int id)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .ToList();
        }

        public Task<List<Backup>> GetByAccountAsync(int id)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByAccountAsync(int id, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .ToListAsync(cancellationToken);
        }

        public List<Backup> GetByAccount(int count, int offset, int id)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToList();
        }

        public Task<List<Backup>> GetByAccountAsync(int count, int offset, int id)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToListAsync();
        }

        public Task<List<Backup>> GetByAccountAsync(int count, int offset, int id, CancellationToken cancellationToken)
        {
            return Set
                .Where(x => x.Account.Id == id)
                .Take(count)
                .Skip(offset)
                .ToListAsync(cancellationToken);
        }
    }
}
