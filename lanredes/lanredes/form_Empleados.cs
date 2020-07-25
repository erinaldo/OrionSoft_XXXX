using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_Empleados : Form
    {
            Datos Datos = new Datos();
            public form_Empleados()
            {
                InitializeComponent();
            }

            private void btn_NuevoEmpleado_Click(object sender, EventArgs e)
            {
                form_AgregarEmpleado agregarEmpleado = new form_AgregarEmpleado();
                string consulta = "Select nombre from empleados";

                agregarEmpleado.Show();
            }
            public void empleado()
            {
                dgw_Empleado_Empleados.DataSource = Datos.llenarDgwGeneral("Select * from Empleado");
            }

        private void form_Empleados_Load(object sender, EventArgs e)
        {

        }
    }
}
