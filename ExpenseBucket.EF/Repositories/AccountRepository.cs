using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;
using ExpenseBucket.Core.Repositories;

namespace ExpenseBucket.EF.Repositories
{
    internal class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(AppDbContext context) : base(context)
        {
        }

        public Account GetByEmail(string email)
        {
            return Set
                .SingleOrDefault(x => x.Email == email);
        }

        public Task<Account> GetByEmailAsync(string email)
        {
            return Set
                .SingleOrDefaultAsync(x => x.Email == email);
        }

        public Task<Account> GetByEmailAsync(string email, CancellationToken cancellationToken)
        {
            return Set
                .SingleOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
