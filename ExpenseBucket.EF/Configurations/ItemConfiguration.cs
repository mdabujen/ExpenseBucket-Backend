using System.Data.Entity.ModelConfiguration;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.EF.Configurations
{
    internal class ItemConfiguration : EntityTypeConfiguration<Item>
    {
        public ItemConfiguration()
        {
            ToTable("Items");
            HasKey(x => x.Id);

            Property(x => x.Cost)
                .IsOptional();

            Property(x => x.DateCreated)
                .IsRequired();

            Property(x => x.Hierarchy)
                .IsRequired();

            Property(x => x.LastModified)
                .IsRequired();

            Property(x => x.LocalId)
                .IsRequired();

            Property(x => x.ParentId)
                .IsRequired();

            Property(x => x.Quantity)
                .IsOptional();

            Property(x => x.StartingBudget)
                .IsOptional();

            Property(x => x.Title)
                .IsRequired();

            Property(x => x.Type)
                .IsRequired();
        }
    }
}
