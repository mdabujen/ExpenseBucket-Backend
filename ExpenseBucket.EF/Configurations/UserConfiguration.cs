using System.Data.Entity.ModelConfiguration;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.EF.Configurations
{
    internal class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("Users");
            HasKey(x => x.Id);

            Property(x => x.Id)
                .IsRequired();

            Property(x => x.Email)
                .IsRequired();

            Property(x => x.Password)
                .IsRequired();

            Property(x => x.FirstName)
                .IsRequired();

            Property(x => x.LastName)
                .IsRequired();
        }
    }//Sql("INSERT INTO Accounts VALUES('mdabujen@gmail.com', 'password', 'Mark Denver', 'Abujen')");
}
