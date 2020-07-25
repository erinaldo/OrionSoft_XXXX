using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lanredes
{
    public partial class form_nuevaVenta_Ventas : Form
    {
        static Logica Logica = new Logica();
        static Datos datos = new Datos();
        static form_nuevaVenta_Ventas nvv = new form_nuevaVenta_Ventas();
        static string valor="'1'";
        public form_nuevaVenta_Ventas()
        {
            InitializeComponent();
        }

        private void lbl_Categoria_NuevaVenta_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NoVenta_Nuevaventa_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Cliente_Nuevaventa_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Direccion_Nuevaventa_Click(object sender, EventArgs e)
        {

        }

        private void lbl_fecha_Nuevaventa_Click(object sender, EventArgs e)
        {

        }

        private void txt_direccion_Nuevaventa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Agregar_Nuevaventa_Click(object sender, EventArgs e)
        {
            form_AgregarProducto fap = new form_AgregarProducto();
            fap.Show();
        }

        private void lbl_NoValorTotal_Nuevaventa_Click(object sender, EventArgs e)
        {

        }

        public void actualizarComboServicio(MySqlDataReader almacena)
        {
            while (almacena.Read())
            {
                cb_Servicio_nuevaVenta.Items.Add(almacena.GetValue(0).ToString());
                cb_Servicio_nuevaVenta.Refresh();
            }
            datos.cerrarConexion();
        }

        public void constructor()
        {
            
        }

        private void form_nuevaVenta_Ventas_Load(object sender, EventArgs e)
        {
            int nro;
            nro = Logica.traerUltimoId("nroVentas","Ventas");
            cb_Servicio_nuevaVenta.DropDownStyle = ComboBoxStyle.DropDownList;
            lbl_NoVenta_Nuevaventa.Text = nro.ToString();
            lbl_Valor_Nuevaventa.Text = "0";
            cb_Dia.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Mes.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Año.DropDownStyle = ComboBoxStyle.DropDownList;
            string consulta1 = "select id from Servicios;";
            actualizarComboServicio(datos.consultarDatos(consulta1));
        }

        private void cb_Servicio_nuevaVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta;
            valor = cb_Servicio_nuevaVenta.Text;
            consulta = "select he.nombre, '1' as Cantidad, 'Unidades' as Unidad,'0' as ValorTotal from detalleServiciosHerramientas dsh join Herramientas he on dsh.idHerramientas=he.id where "+valor+"=dsh.idServicio union select inv.nombre, (select dsi.cantidad where "+valor+" = dsi.idServicios) as Cantidad,inv.unidad,'0' as ValorTotal from Inventario inv join detalleServiciosInventarios dsi on dsi.idInventario = inv.id where "+valor+" = dsi.idServicios";
            dgw_servicio_Nuevaventa.DataSource = datos.llenarDgwGeneral(consulta);
        }

        private void btn_FinalizarVenta_Nuevaventa_Click(object sender, EventArgs e)
        {
            try
            {
                string insertar = "insert into ventas (direccion,fecha,manoObra,descripcion,cedCli) " +
                "values('" + txt_direccion_Nuevaventa.Text + "', '" + cb_Año.Text + "-" + cb_Mes.Text + "-" + cb_Dia.Text + "', " + txt_ValorManoObra_Nuevaventa.Text + ", '" + txt_Descripcion_Nuevaventa.Text + "', " + txt_Cedula_NuevaVenta.Text + "); ";
                Logica.insertarDatos(insertar);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }

        private void txt_ValorManoObra_Nuevaventa_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int valorT = 0;
                valorT = valorT + (int.Parse(txt_ValorManoObra_Nuevaventa.Text));
                lbl_Valor_Nuevaventa.Text = valorT.ToString();
            }
            catch
            {
                lbl_Valor_Nuevaventa.Text = "0";
            }
        }

        private void txt_Cedula_NuevaVenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string consulta3 = "SELECT nombre FROM Cliente WHERE " + txt_Cedula_NuevaVenta.Text + "=cedula";
                lbl_NombreCliente_NuevaVenta.Text = datos.consultarDato(consulta3);
            }
            catch(Exception ex)
            {
                lbl_NombreCliente_NuevaVenta.Text = "No existe";
            }
            
        }

        private void lbl_NombreCliente_NuevaVenta_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // form_nuevaVenta_Ventas
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "form_nuevaVenta_Ventas";
            this.ResumeLayout(false);

        }
    }
}