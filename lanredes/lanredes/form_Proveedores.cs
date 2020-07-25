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
    public partial class form_Proveedores : Form
    {
        Datos Datos = new Datos();
        form_AgregarProveedor agregarProveedor = new form_AgregarProveedor();
        Logica logica = new Logica();
        public form_Proveedores()
        {
            InitializeComponent();
        }

        private void btn_NuevoEmpleado_Click(object sender, EventArgs e)
        {
            agregarProveedor.actualizarCombo(logica.consultar("select nombre from ciudad"));
            agregarProveedor.ShowDialog();
        }
        public void proveedor()
        {
            dgw_Proveedor_Proveedores.DataSource = Datos.llenarDgwGeneral("Select * from Proveedor");
        }

        private void form_Proveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
