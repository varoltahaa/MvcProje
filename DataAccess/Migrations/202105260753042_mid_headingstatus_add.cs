namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mid_headingstatus_add : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "HeadingStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Headings", "HeadingStatus");
        }
    }
}
