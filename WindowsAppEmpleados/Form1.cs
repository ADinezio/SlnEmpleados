using EjercicioFinal.Model.Derivadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppEmpleados
{
    public partial class Form1 : Form
    {
        Departamento departamento;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            departamento = new Departamento(1, "Produccion");
            
            departamento.Empleados.Add(new Empleado(1, "Juan", "Perez", "AA011235"));
            departamento.Empleados.Add(new Empleado(2, "Martin", "Chinchulin", "BB22569"));
            departamento.Empleados.Add(new Empleado(3, "Pepe", "Grillo", "CC99456"));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridEmpleados.DataSource=departamento.Empleados;
        }
    }
}
