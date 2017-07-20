namespace MoviesInventory.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixAnnotations : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Movies", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Movies", "Title");
        }
    }
}
