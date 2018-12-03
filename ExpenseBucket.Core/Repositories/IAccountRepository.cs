using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.Core.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetByEmail(string email);
        Task<Account> GetByEmailAsync(string email);
        Task<Account> GetByEmailAsync(string email, CancellationToken cancellationToken);
    }
}
