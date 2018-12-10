using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;
using ExpenseBucket.Core.Repositories;

namespace ExpenseBucket.EF.Repositories
{
    internal class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public User GetByEmail(string email)
        {
            return Set
                .SingleOrDefault(x => x.Email == email);
        }

        public Task<User> GetByEmailAsync(string email)
        {
            return Set
                .SingleOrDefaultAsync(x => x.Email == email);
        }

        public Task<User> GetByEmailAsync(string email, CancellationToken cancellationToken)
        {
            return Set
                .SingleOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
