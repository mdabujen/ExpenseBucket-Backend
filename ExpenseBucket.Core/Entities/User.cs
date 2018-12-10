using System.Collections.Generic;

namespace ExpenseBucket.Core.Entities
{
    public class User
    {
        private ICollection<UserClaim> _userClaims;
        private ICollection<Backup> _backups;


        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string EmailPassword { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public virtual ICollection<UserClaim> UserClaims
        {
            get => _userClaims ?? (_userClaims = new List<UserClaim>());
            set => _userClaims = value;
        }
        public ICollection<Backup> Backups
        {
            get => _backups ?? (_backups = new List<Backup>());
            set => _backups = value;
        }
    }
}
