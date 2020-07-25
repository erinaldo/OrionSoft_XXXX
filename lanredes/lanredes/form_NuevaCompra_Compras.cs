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
    public partial class form_NuevaCompra_Compras : Form
    {
        Logica logica = new Logica();
        Datos datos = new Datos();

        public form_NuevaCompra_Compras()
        {
            InitializeComponent();
        }

        private void lbl_Unidad_NuevaCompra_Click(object sender, EventArgs e)
        {

        }

        public void actualizarComboProveedor(MySqlDataReader almacena)
        {
            cb_Proveedor_NuevaCompra.Items.Add("Selecciona una opcion");
            while (almacena.Read())
            {
                cb_Proveedor_NuevaCompra.Refresh();
                cb_Proveedor_NuevaCompra.Items.Add(almacena.GetValue(0).ToString());
            }
        }

        public void actualizarComboBox(MySqlDataReader almacena,ComboBox cb_desplegar)
        {
            cb_desplegar.Items.Add("Selecciona una opcion");
            while (almacena.Read())
            {
                cb_desplegar.Refresh();
                cb_desplegar.Items.Add(almacena.GetValue(0).ToString());
            }
        }

        

        private void form_NuevaCompra_Compras_Load(object sender, EventArgs e)
        {
            limpiar(cb_Proveedor_NuevaCompra, cb_Producto_NuevaCompra, cb_Categoria_NuevaCompra, cb_Año, cb_Dia, cb_Mes);
            lbl_Unidad.Text = "";
            txt_ValorUnidad_NuevaCompra.Text = "";
            string consulta1 = "select cedula from proveedor";
            cb_Proveedor_NuevaCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Categoria_NuevaCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Producto_NuevaCompra.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_Numero.Text = (logica.traerUltimoId("id","Compras")).ToString();
            actualizarComboProveedor(datos.consultarDatos(consulta1));
            dgw_Productos_NuevaCompra.Rows.Clear();
            cb_Dia.Text = logica.Dia.ToString();
            cb_Mes.Text = logica.Mes.ToString();
            cb_Año.Text = logica.Año.ToString();
            cb_Proveedor_NuevaCompra.SelectedIndex = 0;
            lbl_ValorTotal.Text = "0";
        }

        private void cb_Proveedor_NuevaCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiar(cb_Categoria_NuevaCompra);
            try
            {
                string consulta1 = "select c.nombre from categoria c " +
                "join ofrece o on c.id = o.idCategoria " +
                "join proveedor po on o.idProveedor = po.cedula " +
                "where po.cedula =" + cb_Proveedor_NuevaCompra.Text + ";";
                lbl_Nombre_NuevaCompra.Text = datos.consultarDato("select CONCAT(nombre, ' ', apellido) from proveedor where cedula = " + cb_Proveedor_NuevaCompra.Text);
                actualizarComboBox(datos.consultarDatos(consulta1), cb_Categoria_NuevaCompra);
                cb_Categoria_NuevaCompra.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                lbl_Nombre_NuevaCompra.Text = "Seleccione un proveedor";
            }
        }
        
        public void limpiar(ComboBox combo)
        {
            combo.Text = "";
            combo.Items.Clear();
        }
        public void limpiar(ComboBox combo1, ComboBox combo2, ComboBox combo3, ComboBox combo4, ComboBox combo5, ComboBox combo6)
        {
            combo1.Text = ""; combo1.Items.Clear();
            combo2.Text = ""; combo2.Items.Clear();
            combo3.Text = ""; combo3.Items.Clear();
            combo4.Text = ""; combo4.Items.Clear();
            combo5.Text = ""; combo5.Items.Clear();
            combo6.Text = ""; combo6.Items.Clear();
        }

        private void brn_AgregarProducto_NuevaCompra_Click(object sender, EventArgs e)
        {
            
            try
            {
                int valor1 = 0, valor2 = 0;
                valor1 = int.Parse(lbl_ValorTotal.Text);
                valor2 = int.Parse(txt_ValorUnidad_NuevaCompra.Text);
                valor1 += valor2;
                lbl_ValorTotal.Text = valor1.ToString();
                int n = dgw_Productos_NuevaCompra.Rows.Add(); //Trae la poscicion nueva a agregar
                dgw_Productos_NuevaCompra.Rows[n].Cells[0].Value = cb_Producto_NuevaCompra.Text;
                dgw_Productos_NuevaCompra.Rows[n].Cells[1].Value = txt_Cantidad_NuevaCompra.Text;
                dgw_Productos_NuevaCompra.Rows[n].Cells[2].Value = txt_ValorUnidad_NuevaCompra.Text;
                txt_Cantidad_NuevaCompra.Text = "";
                txt_ValorUnidad_NuevaCompra.Text = "";
                limpiar(cb_Producto_NuevaCompra);
                
            }
            catch
            {
                if (cb_Proveedor_NuevaCompra.SelectedIndex == 0)
                {
                    MessageBox.Show("Por favor, escoja un proveedor");
                }
                if (cb_Categoria_NuevaCompra.SelectedIndex == 0)
                {
                    MessageBox.Show("Por favor, escoja una categoria");
                }
            }
        }

        private void cb_Categoria_NuevaCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiar(cb_Producto_NuevaCompra);
            try
            {
                lbl_Unidad.Text = "";
                string consultaProductos = "select i.nombre " +
                    "from inventario i " +
                    "join categoria c on i.idCategoria = c.id " +
                    "where c.nombre = '" + cb_Categoria_NuevaCompra.Text + "'; ";
                actualizarComboBox(datos.consultarDatos(consultaProductos), cb_Producto_NuevaCompra);
            }
            catch
            {
                cb_Producto_NuevaCompra.SelectedIndex = 0;
            }
        }

        private void cb_Producto_NuevaCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string consultaUnidad = "select unidad " +
                "from inventario " +
                "where nombre = '" + cb_Producto_NuevaCompra.Text + "'; ";
                lbl_Unidad.Text = datos.consultarDato(consultaUnidad);
            }
            catch(Exception ex)
            {
                lbl_Unidad.Text = "";
            }
        }

        private void btn_FinalizarCompra_NuevaCompra_Click(object sender, EventArgs e)
        {
            string insert = "insert into compras (fecha,codProveedor,valorTotal) "+
                "values('"+cb_Año.Text+"-"+cb_Mes.Text+"-"+cb_Dia.Text+"', '"+cb_Proveedor_NuevaCompra.Text+"', "+lbl_ValorTotal.Text+");";
            string insert2 = "insert into detalleinventariocompra(cantidad, idCompra, idInventario, valorProducto) "+
                "values(1, "+lbl_Numero.Text+", 1, 15000); ";
            string update = "update inventario set valor = 15000 where id = 1;";

            logica.insertarDatos(insert);
            this.Close();
            //int resultado = logica.traerid("categoria", cb_Categoria_NuevaCompra.Text, "id");
            //Funcion para contar registros en datagrid = dgw_Productos_NuevaCompra.Rows.Count.ToString();
        }

        private void lbl_ValorTotal_Click(object sender, EventArgs e)
        {

        }

        private void txt_ValorUnidad_NuevaCompra_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
