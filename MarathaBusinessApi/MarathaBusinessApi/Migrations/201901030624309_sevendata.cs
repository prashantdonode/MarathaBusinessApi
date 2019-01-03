namespace MarathaBusinessApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sevendata : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblImages",
                c => new
                    {
                        Iid = c.Int(nullable: false, identity: true),
                        Bid = c.Int(nullable: false),
                        image1 = c.Binary(),
                        image2 = c.Binary(),
                        image3 = c.Binary(),
                        image4 = c.Binary(),
                    })
                .PrimaryKey(t => t.Iid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblImages");
        }
    }
}
