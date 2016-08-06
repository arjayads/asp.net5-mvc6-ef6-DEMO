namespace Track1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Standards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfBirth = c.DateTime(),
                        Photo = c.Binary(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Weight = c.Single(nullable: false),
                        StandardId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Standards", t => t.StandardId)
                .Index(t => t.StandardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "StandardId", "dbo.Standards");
            DropIndex("dbo.Students", new[] { "StandardId" });
            DropTable("dbo.Students");
            DropTable("dbo.Standards");
        }
    }
}
