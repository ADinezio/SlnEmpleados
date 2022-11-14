using EjercicioFinal.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFinal.Model.Derivadas
{
    public class Cliente:Persona
    {
        #region constructores
        
        public Cliente(int id, string nombre, string apellido, string cuit, string telefono) : base(id, nombre, apellido)
        {
            this.Cuit = cuit;
            this.Telefono = telefono;
        }
        #endregion

        #region propiedades
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        #endregion
    }
}
