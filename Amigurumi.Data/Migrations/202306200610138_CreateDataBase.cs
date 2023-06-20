namespace Amigurumi.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Email = c.String(nullable: false, maxLength: 80, unicode: false),
                        Login = c.String(),
                        Senha = c.String(nullable: false, maxLength: 8, fixedLength: true, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Email, unique: true, name: "UQ_dbo.Usuario.Email");
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuario", "UQ_dbo.Usuario.Email");
            DropTable("dbo.Usuario");
        }
    }
}
