namespace CodeFirstNewDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "Url", c => c.String());
            AlterColumn("dbo.Blogs", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Name", c => c.Int(nullable: false));
            DropColumn("dbo.Blogs", "Url");
        }
    }
}
