using System;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_Buscar_inventario : Form
    {
        Logica logica = new Logica();
        static form_Productos fp = new form_Productos();
        static Home home = new Home();
        static form_AgragarCliente fac = new form_AgragarCliente();
        Datos datos = new Datos();
        public form_Buscar_inventario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_id_BuscarInventario.Text != "")
            {
                logica.deshabilitarTexbox(txt_Nombre_BuscarInventario);
                logica.deshabilitarCombobox(cb_Categoria_BuscarInventario);
            }
            else
            {
                logica.habilitarCombobox(cb_Categoria_BuscarInventario);
                logica.habilitarTexbox(txt_Nombre_BuscarInventario);
            }
            if (txt_id_BuscarInventario.Text != "")
            {
                if (logica.verificarFormatoNumerico(txt_id_BuscarInventario.Text) == false)
                    MessageBox.Show("Formato de ID no reconocido");
            }
            else
            {
                if (chb_id.Checked == true)
                    dgw_BuscarProducto.DataSource = logica.llenardgw("select * from inventario where upper(id)=upper(" + txt_id_BuscarInventario.Text + ")");
            }
        }

        private void form_Buscar_inventario_Load(object sender, EventArgs e)
        {
            cb_Categoria_BuscarInventario.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void txt_Nombre_BuscarInventario_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nombre_BuscarInventario.Text != "")
            {
                logica.deshabilitarTexbox(txt_id_BuscarInventario);
                logica.deshabilitarCombobox(cb_Categoria_BuscarInventario);

            }
            else
            {
                logica.habilitarCombobox(cb_Categoria_BuscarInventario);
                logica.habilitarTexbox(txt_id_BuscarInventario);
            }
            if(chb_nombre.Checked==true)
            dgw_BuscarProducto.DataSource = logica.llenardgw("select * from inventario where upper(nombre) LIKE ('%" + txt_Nombre_BuscarInventario.Text + "%')");
        }

        private void cb_Categoria_BuscarInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_Categoria_BuscarInventario.Text!="")
            {
                logica.deshabilitarTexbox(txt_id_BuscarInventario);
                logica.deshabilitarTexbox(txt_Nombre_BuscarInventario);
            }
            else
            {
                logica.habilitarTexbox(txt_id_BuscarInventario);
                logica.habilitarTexbox(txt_Nombre_BuscarInventario);

            }
        }

        private void btn_Buscar_Buscar_Click(object sender, EventArgs e)
        {
            home.limpiarPanel();
            ///////////////////Consulta Combo ///////////////////////
            if (txt_id_BuscarInventario.Enabled==false && txt_Nombre_BuscarInventario.Enabled==false)
            {
                dgw_BuscarProducto.DataSource = logica.llenardgw("select * from inventario where upper(idCategoria)=upper(" + cb_Categoria_BuscarInventario.Text + ")");
            }
            //////////////////Consulta ID /////////////////////////// 
            if (txt_Nombre_BuscarInventario.Enabled==false && cb_Categoria_BuscarInventario.Enabled==false)
            {
                dgw_BuscarProducto.DataSource = logica.llenardgw("select * from inventario where upper(id)=upper(" + txt_id_BuscarInventario.Text + ")");
            }
            //////////////////Consulta Nombre /////////////////////////// 
            if (txt_id_BuscarInventario.Enabled==false && cb_Categoria_BuscarInventario.Enabled==false)
            {
                dgw_BuscarProducto.DataSource = logica.llenardgw("select * from inventario where upper(nombre) LIKE ('%" + txt_Nombre_BuscarInventario.Text + "%')");
            }

            //dgw_BuscarProducto.
            
        }
    }
}
