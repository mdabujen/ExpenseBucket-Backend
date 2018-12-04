using System.Data.Entity.ModelConfiguration;
using ExpenseBucket.Core.Entities;

namespace ExpenseBucket.EF.Configurations
{
    internal class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            ToTable("Categories");
            HasKey(x => x.Id);

            Property(x => x.Title)
                .IsRequired();

            Property(x => x.ImageId)
                .IsRequired();
        }
    }
}
