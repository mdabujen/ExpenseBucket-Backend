using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ExpenseBucket.Core.Entities;
using ExpenseBucket.Core.Repositories;
using System.Data.Entity;

namespace ExpenseBucket.EF.Repositories
{
    internal class UserClaimRepository : Repository<UserClaim>, IUserClaimRepository
    {
        public UserClaimRepository(AppDbContext context)
            : base(context)
        {
            
        }               

        public List<UserClaim> GetAllByClaimTypeAndValue(string claimType, string claimValue)
        {
            return Set
                .Include(x => x.User)
                .Where(type => type.ClaimType == claimType)
                .ToList();
        }

        public Task<List<UserClaim>> GetAllByClaimTypeAndValueAsync(string claimType, string claimValue)
        {
            return Set
                .Include(x => x.User)
                .Where(type => type.ClaimType == claimType)
                .ToListAsync();
        }

        public Task<List<UserClaim>> GetAllByClaimTypeAndValueAsync(string claimType, string claimValue, CancellationToken cancellationToken)
        {
            return Set
                .Include(x => x.User)
                .Where(type => type.ClaimType == claimType)
                .ToListAsync(cancellationToken);
        }

        public List<UserClaim> GetAllNullUserId()
        {
            return Set
                .Where(x => x.UserId == null)
                .ToList();
        }
    }
}
