namespace HomeManager.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Relation_Between_Entry_and_GroupEntry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entries", "group_Id", c => c.Int());
            CreateIndex("dbo.Entries", "group_Id");
            AddForeignKey("dbo.Entries", "group_Id", "dbo.EntryGroups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entries", "group_Id", "dbo.EntryGroups");
            DropIndex("dbo.Entries", new[] { "group_Id" });
            DropColumn("dbo.Entries", "group_Id");
        }
    }
}
