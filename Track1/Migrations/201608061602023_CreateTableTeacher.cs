namespace Track1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableTeacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teacher",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(maxLength: 1054),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Teacher");
        }
    }
}
