namespace RealEstateUploader.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<RealEstateUploader.Persistence.DomainRSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Persistence\Migrations";
        }

        protected override void Seed(RealEstateUploader.Persistence.DomainRSDbContext context){}
    }
}
