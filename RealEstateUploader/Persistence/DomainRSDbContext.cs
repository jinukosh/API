using RealEstateUploader.Core.Entities;
using System.Data.Entity;

namespace RealEstateUploader.Persistence
{
    public class DomainRSDbContext : DbContext
    {
        public DomainRSDbContext() : base("DomainConnectionString")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DomainRSDbContext>());           
        }

        public DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           base.OnModelCreating(modelBuilder);
        }

    }
}