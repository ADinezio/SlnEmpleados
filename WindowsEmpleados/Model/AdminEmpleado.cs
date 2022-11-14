using EjercicioFinal.Model.Derivadas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Data;

namespace WindowsEmpleados.Model
{
    public static class AdminEmpleado
    {
        private static DBEmpleadosContext context = new DBEmpleadosContext();
        public static int Nuevo(Empleado empleado)
        {
            int filasAfectadas = 0;
            context.Empleados.Add(empleado);
            filasAfectadas=context.SaveChanges();
            return filasAfectadas;
        }

        public static List<Empleado> Listar()
        {
            return context.Empleados.ToList();
        }
    }
}
