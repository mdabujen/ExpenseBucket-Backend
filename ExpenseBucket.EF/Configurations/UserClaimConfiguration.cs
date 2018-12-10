using ExpenseBucket.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ExpenseBucket.EF.Configurations
{
    internal class UserClaimConfiguration : EntityTypeConfiguration<UserClaim>
    {
        public UserClaimConfiguration()
        {
            ToTable("UserClaims");
            HasKey(x => x.ClaimId);

            Property(x => x.ClaimId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.ClaimType)
                .IsMaxLength()
                .IsOptional();

            Property(x => x.UserId)
                .HasMaxLength(128)
                .IsOptional();
        }
    }
}
