using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.Core.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByEmail(string email);
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByEmailAsync(string email, CancellationToken cancellationToken);
    }
}
