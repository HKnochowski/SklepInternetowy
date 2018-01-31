namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update29PW : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.State",
                c => new
                    {
                        StateID = c.Int(nullable: false, identity: true),
                        StateName = c.String(),
                    })
                .PrimaryKey(t => t.StateID);
            
            AddColumn("dbo.Client", "State_StateID", c => c.Int());
            CreateIndex("dbo.Client", "State_StateID");
            AddForeignKey("dbo.Client", "State_StateID", "dbo.State", "StateID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Client", "State_StateID", "dbo.State");
            DropIndex("dbo.Client", new[] { "State_StateID" });
            DropColumn("dbo.Client", "State_StateID");
            DropTable("dbo.State");
        }
    }
}
