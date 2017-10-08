namespace RealEstateUploader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDataLoad : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Properties (Address, AgencyCode, Name, Latitude, Longitude) values('Address1', 'LRE', 'Property1',33.86,151.20)");
            Sql("Insert into Properties (Address, AgencyCode, Name, Latitude, Longitude) values('Address2', 'LRE', 'Property2',38.86,150.20)");
            Sql("Insert into Properties (Address, AgencyCode, Name, Latitude, Longitude) values('Address3', 'CRE', 'Property3',49.86,251.20)");
        }
        
        public override void Down()
        {
            Sql("delete from Properties where id in(1,2,3)");
        }
    }
}
