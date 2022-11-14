namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificaciones : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Departamentoes", newName: "Departamento");
            RenameTable(name: "dbo.Empleadoes", newName: "Empleado");
            AlterColumn("dbo.Departamento", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Empleado", "Legajo", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Empleado", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Empleado", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleado", "Apellido", c => c.String());
            AlterColumn("dbo.Empleado", "Nombre", c => c.String());
            AlterColumn("dbo.Empleado", "Legajo", c => c.String());
            AlterColumn("dbo.Departamento", "Nombre", c => c.String());
            RenameTable(name: "dbo.Empleado", newName: "Empleadoes");
            RenameTable(name: "dbo.Departamento", newName: "Departamentoes");
        }
    }
}
