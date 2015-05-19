namespace FamilyTree.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Individuals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Date_Of_birth = c.String(),
                        Place_Of_Birth = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Relationships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Individual_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Individuals", t => t.Individual_Id)
                .Index(t => t.Individual_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Relationships", "Individual_Id", "dbo.Individuals");
            DropIndex("dbo.Relationships", new[] { "Individual_Id" });
            DropTable("dbo.Relationships");
            DropTable("dbo.Individuals");
        }
    }
}
