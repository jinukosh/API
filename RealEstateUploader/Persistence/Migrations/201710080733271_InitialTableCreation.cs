namespace RealEstateUploader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialTableCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Address = c.String(maxLength: 250),
                        AgencyCode = c.String(maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 150),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Properties");
        }
    }
}
