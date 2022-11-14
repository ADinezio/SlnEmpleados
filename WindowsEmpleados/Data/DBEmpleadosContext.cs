using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EjercicioFinal.Model.Derivadas;
using WindowsEmpleados.Model;

namespace WindowsEmpleados.Data
{
    public class DBEmpleadosContext:DbContext
    {
        public DBEmpleadosContext():base("keyDBEmpleados") {}

        public DbSet<Departamento> Departamentos  { get; set; }
        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Departamento>().ToTable("Departamentos");
            modelBuilder.Entity<Empleado>().ToTable("Empleados");

            modelBuilder.Entity<Departamento>().HasKey(t => t.Id);
            modelBuilder.Entity<Empleado>().HasKey(t => t.Id);

            modelBuilder.Entity<Departamento>().Property(t => t.Nombre).HasColumnType("varchar").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Empleado>().Property(t => t.Nombre).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Empleado>().Property(t => t.Apellido).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Empleado>().Property(t => t.Legajo).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        }
    }
}
