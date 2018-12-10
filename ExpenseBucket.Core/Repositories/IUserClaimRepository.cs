using ExpenseBucket.Core.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ExpenseBucket.Core.Repositories
{
    public interface IUserClaimRepository : IRepository<UserClaim>
    {
        List<UserClaim> GetAllNullUserId();
        List<UserClaim> GetAllByClaimTypeAndValue(string claimType, string claimValue);
        Task<List<UserClaim>> GetAllByClaimTypeAndValueAsync(string claimType, string claimValue);
        Task<List<UserClaim>> GetAllByClaimTypeAndValueAsync(string claimType, string claimValue, CancellationToken cancellationToken);
    }
}
