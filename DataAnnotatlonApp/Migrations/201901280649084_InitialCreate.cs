namespace DataAnnotatlonApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Firma",
                c => new
                    {
                        FirmaId = c.Guid(nullable: false),
                        FirmaUnvani = c.String(storeType: "ntext"),
                        TelefonNo = c.String(),
                        Adres = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.FirmaId);
            
            CreateTable(
                "dbo.Kisiler",
                c => new
                    {
                        KisiId = c.Guid(nullable: false),
                        FirmaRefId = c.Guid(nullable: false),
                        KisiAdi = c.String(nullable: false, maxLength: 40),
                        Soyadi = c.String(maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 100),
                        Foto = c.Binary(maxLength: 1000),
                    })
                .PrimaryKey(t => t.KisiId)
                .ForeignKey("dbo.Firma", t => t.FirmaRefId, cascadeDelete: true)
                .Index(t => t.FirmaRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kisiler", "FirmaRefId", "dbo.Firma");
            DropIndex("dbo.Kisiler", new[] { "FirmaRefId" });
            DropTable("dbo.Kisiler");
            DropTable("dbo.Firma");
        }
    }
}
