using ExpenseBucket.Core.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseBucket.WebApi.Models.Identity
{
    public class IdentityUser : IUser<string>
    {
        private ICollection<UserClaim> _userClaims;

        public IdentityUser()
        {
            Id = Guid.NewGuid().ToString();
        }

        public IdentityUser(string username)
            : this()
        {
            UserName = username;
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }

        public virtual ICollection<UserClaim> UserClaims
        {
            get => _userClaims ?? (_userClaims = new List<UserClaim>());
            set => _userClaims = value;
        }
    }
}