using System.Data.Entity.ModelConfiguration;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.EF.Configurations
{
    internal class BackupConfiguration : EntityTypeConfiguration<Backup>
    {
        public BackupConfiguration()
        {
            ToTable("Backups");
            HasKey(x => x.Id);

            Property(x => x.DateCreated)
                .IsRequired();

            Property(x => x.Title)
                .IsRequired();
        }
    }
}
