using System;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_Productos : Form
    {
        Logica logica = new Logica();
        form_Buscar_inventario fbi = new form_Buscar_inventario();
        
        
        public form_Productos()
        {
            InitializeComponent();
        }

        private void form_Productos_Load(object sender, EventArgs e)
        {

        }
        public void productos()
        {
            dgw_Productos.DataSource = logica.llenardgw("select * from inventario");
        }
        public void productos(string consulta)
        {
            dgw_Productos.DataSource = logica.llenardgw(consulta);
        }

        private void btn_BuscarProductos_Click(object sender, EventArgs e)
        {
            fbi.Show();
        }

        private void dgw_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
