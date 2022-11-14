using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal.Model.Derivadas
{
    public class Departamento
    {
      
        public Departamento(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Empleados = new List<Empleado>();
        }
      

        public int Id { get; set; }
        public string Nombre { get; set; }
       

        public List<Empleado> Empleados { get; set; }
 

      
    }
}
