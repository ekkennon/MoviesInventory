namespace MoviesInventory.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "RunningTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "RunningTime", c => c.DateTime(nullable: false));
        }
    }
}
