namespace MyPracticeCass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        IdProducto = c.Int(nullable: false, identity: true),
                        CodigoProducto = c.String(nullable: false),
                        DescripcionProducto = c.String(nullable: false),
                        CantidadProducto = c.Int(nullable: false),
                        PrecioProducto = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdProducto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Productos");
        }
    }
}
