namespace Eureka.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInitialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coments",
                c => new
                    {
                        ComentarioID = c.Int(nullable: false, identity: true),
                        Usuario = c.String(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 250),
                        Avaliacao = c.Int(),
                        Ideia_IdeiaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComentarioID)
                .ForeignKey("dbo.Ideias", t => t.Ideia_IdeiaID, cascadeDelete: true)
                .Index(t => t.Ideia_IdeiaID);
            
            CreateTable(
                "dbo.Ideias",
                c => new
                    {
                        IdeiaID = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 150),
                        Tag = c.String(),
                        Descricao = c.String(nullable: false),
                        Avaliacao = c.Int(),
                        Usuario = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdeiaID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coments", "Ideia_IdeiaID", "dbo.Ideias");
            DropIndex("dbo.Coments", new[] { "Ideia_IdeiaID" });
            DropTable("dbo.Ideias");
            DropTable("dbo.Coments");
        }
    }
}
