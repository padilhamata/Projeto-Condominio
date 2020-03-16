namespace ProjetoCondominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Salas",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Salas = c.Int(nullable: false),
                        Andar = c.Int(nullable: false),
                        Garagem = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Salas");
        }
    }
}
