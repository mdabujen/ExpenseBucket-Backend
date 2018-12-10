using System.Data.Entity;
using ExpenseBucket.Core.Entities;
using ExpenseBucket.EF.Configurations;

namespace ExpenseBucket.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext") { }

        public AppDbContext(string nameOrConnectionString) 
            : base(nameOrConnectionString) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<Backup> Backups { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new BackupConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ItemConfiguration());
        }
    }
}
