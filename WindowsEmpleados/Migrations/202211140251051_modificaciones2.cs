namespace WindowsEmpleados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificaciones2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Departamento", newName: "Departamentos");
            RenameTable(name: "dbo.Empleado", newName: "Empleados");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Empleados", newName: "Empleado");
            RenameTable(name: "dbo.Departamentos", newName: "Departamento");
        }
    }
}
