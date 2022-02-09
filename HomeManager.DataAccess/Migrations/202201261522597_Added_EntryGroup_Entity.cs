namespace HomeManager.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_EntryGroup_Entity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EntryGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EntryGroups");
        }
    }
}
