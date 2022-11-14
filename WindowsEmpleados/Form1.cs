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
using WindowsEmpleados.Model;

namespace WindowsEmpleados
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado() { Apellido="Dine", Nombre="Agustin", Legajo="EE4589522"};
            AdminEmpleado.Nuevo(empleado);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            gridEmpleados.DataSource = AdminEmpleado.Listar();
        }
    }
}
