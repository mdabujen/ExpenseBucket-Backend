namespace ExpenseBucket.Core.Entities
{
    public class UserClaim
    {
        private User _user;


        public int ClaimId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string UserId { get; set; }


        public virtual User User
        {
            get => _user;
            set => _user = value;
        }
    }
}
