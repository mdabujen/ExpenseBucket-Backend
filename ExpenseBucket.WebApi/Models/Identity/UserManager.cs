using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace ExpenseBucket.WebApi.Models.Identity
{
    public class UserManager : UserManager<IdentityUser, string>
    {
        public UserManager(IUserStore<IdentityUser, string> store)
            : base(store)
        {
            UserValidator = new UserValidator<IdentityUser, string>(this)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6
            };

            ClaimsIdentityFactory = new AppClaimsIdentityFactory();

            var dataProtectionProvider = Startup
        }
    }

    #region AppClaimsIdentityFactory
    public class AppClaimsIdentityFactory : ClaimsIdentityFactory<IdentityUser, string>
    {
        public async override Task<ClaimsIdentity> CreateAsync(UserManager<IdentityUser, string> manager, IdentityUser user, string authenticationType)
        {
            var id = await base.CreateAsync(manager, user, authenticationType);

            id.AddClaim(new Claim("firstname", user.FirstName));
            id.AddClaim(new Claim("lastname", user.LastName));
            id.AddClaim(new Claim("email", user.Email));
            id.AddClaim(new Claim("emailpassword", user.EmailPassword));

            var claims = await manager.GetClaimsAsync(user.Id);

            foreach (var claim in claims)
            {
                id.AddClaim(claim);
            }

            return id;
        } 
        #endregion
    }
}