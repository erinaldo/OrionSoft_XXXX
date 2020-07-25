using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lanredes
{
    public partial class form_Compras : Form
    {
        Datos datos = new Datos();
        form_NuevaCompra_Compras fnc = new form_NuevaCompra_Compras();

        public form_Compras()
        {
            InitializeComponent();
        }

        private void form_Compras_Load(object sender, EventArgs e)
        {

        }

        public void llenarData()
        {
            string consulta = "select (id)'Nro',(fecha)'Fecha Compra',(codProveedor)'Cedula Proveedor',(valorTotal)'Valor Total' from Compras";
            dgw_Compras.DataSource = datos.llenarDgwGeneral(consulta);
        }

        private void btn_Nueva_Compra_Click(object sender, EventArgs e)
        {
            fnc.ShowDialog();
        }
    }
}
