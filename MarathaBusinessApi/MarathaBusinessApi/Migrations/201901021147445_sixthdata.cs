namespace MarathaBusinessApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sixthdata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblBusinessManRegistrations", "Location", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblBusinessManRegistrations", "Location");
        }
    }
}
