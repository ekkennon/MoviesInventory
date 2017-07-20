namespace MoviesInventory.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumns : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Movies");
            AddColumn("dbo.Movies", "Note", c => c.String());
            AddColumn("dbo.Movies", "RunningTime", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Movies", "Owner", c => c.String());
            AddColumn("dbo.Movies", "Barcode", c => c.String());
            AddColumn("dbo.Movies", "Format", c => c.String());
            AddColumn("dbo.Movies", "Location", c => c.String());
            AddColumn("dbo.Movies", "Rating", c => c.String());
            AlterColumn("dbo.Movies", "ID", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "Title", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Movies", "Title");
            DropColumn("dbo.Movies", "Genre");
            DropColumn("dbo.Movies", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Movies", "Genre", c => c.String());
            DropPrimaryKey("dbo.Movies");
            AlterColumn("dbo.Movies", "Title", c => c.String());
            AlterColumn("dbo.Movies", "ID", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Movies", "Rating");
            DropColumn("dbo.Movies", "Location");
            DropColumn("dbo.Movies", "Format");
            DropColumn("dbo.Movies", "Barcode");
            DropColumn("dbo.Movies", "Owner");
            DropColumn("dbo.Movies", "RunningTime");
            DropColumn("dbo.Movies", "Note");
            AddPrimaryKey("dbo.Movies", "ID");
        }
    }
}
