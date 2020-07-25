using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_ventas : Form
    {
        public form_ventas()
        {
            InitializeComponent();
        }
        Datos datos = new Datos();
        private void btn_Nueva_Ventas_Click(object sender, EventArgs e)
        {
            form_nuevaVenta_Ventas nvv = new form_nuevaVenta_Ventas();
            nvv.ShowDialog();
        }

        private void btn_VerVenta_ventas_Click(object sender, EventArgs e)
        {
            form_nuevaVenta_Ventas fnv = new form_nuevaVenta_Ventas();
            fnv.Show();
        }

        private void dgw_Ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void llenarData()
        {
            string consulta = "select * from ventas";
            dgw_Ventas.DataSource = datos.llenarDgwGeneral(consulta);
        }

        private void form_ventas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
