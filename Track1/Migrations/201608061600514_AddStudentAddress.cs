namespace Track1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Address", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Student", "Address");
        }
    }
}
