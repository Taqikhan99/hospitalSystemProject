namespace HMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BasicEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accomodations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccomodationPackageId = c.Int(nullable: false),
                        Name = c.String(),
                        AcmPackage_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccomodationPackages", t => t.AcmPackage_Id)
                .Index(t => t.AcmPackage_Id);
            
            CreateTable(
                "dbo.AccomodationPackages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccomodationTypeId = c.Int(nullable: false),
                        Name = c.String(),
                        NoOfRooms = c.Int(nullable: false),
                        Fees = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AccomodationTypes", t => t.AccomodationTypeId, cascadeDelete: true)
                .Index(t => t.AccomodationTypeId);
            
            CreateTable(
                "dbo.AccomodationTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccomodationId = c.Int(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        Duration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accomodations", t => t.AccomodationId, cascadeDelete: true)
                .Index(t => t.AccomodationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "AccomodationId", "dbo.Accomodations");
            DropForeignKey("dbo.Accomodations", "AcmPackage_Id", "dbo.AccomodationPackages");
            DropForeignKey("dbo.AccomodationPackages", "AccomodationTypeId", "dbo.AccomodationTypes");
            DropIndex("dbo.Bookings", new[] { "AccomodationId" });
            DropIndex("dbo.AccomodationPackages", new[] { "AccomodationTypeId" });
            DropIndex("dbo.Accomodations", new[] { "AcmPackage_Id" });
            DropTable("dbo.Bookings");
            DropTable("dbo.AccomodationTypes");
            DropTable("dbo.AccomodationPackages");
            DropTable("dbo.Accomodations");
        }
    }
}
