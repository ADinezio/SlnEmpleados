using EjercicioFinal.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal.Model.Derivadas
{
    public class Empleado:Persona
    {
        #region constructor
        public Empleado() { }
        public Empleado(int id, string nombre, string apellido,string legajo) : base(id, nombre, apellido)
        {
            this.Legajo=legajo;
        }
        #endregion

        #region propiedades
        public string Legajo { get; set; }
        #endregion

        #region propiedades navegacion
        public Departamento Departamento { get; set; }
        #endregion
    }
}
