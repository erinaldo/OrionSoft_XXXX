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
    public partial class form_AgragarCliente : Form
    {
        Datos datos = new Datos();
        
        public void limpiarForm()
        {
            txt_cedula_Agregarcliente.Text="";
            txt_Nombre_Agregarcliente.Text="";
            txt_Apellidos_Agregarcliente.Text="";
            txt_dirrecion_Agregarcliente.Text = "";
            txt_Correo_Agregarcliente.Text = "";
            txt_Telefono_Agregarcliente.Text = "";
            cb_ciudad_Agregarcliente.Text = "";
            txt_descripcion_Agregarcliente.Text = "";
        }
       

        public form_AgragarCliente()
        {
            InitializeComponent();
        }

        public void btn_Agregar_Agregarcliente_Click(object sender, EventArgs e)
        {
            form_cliente fi = new form_cliente();
            Home home = new Home();
            try
            {
                datos.agregarUsuario("INSERT INTO Cliente (`cedula`, `nombre`, `apellido`, `direccion`, `correo`, `observaciones`, `codCiudad`) VALUES('" + txt_cedula_Agregarcliente.Text + "',' " + txt_Nombre_Agregarcliente.Text + "',' " + txt_Apellidos_Agregarcliente.Text + "',' " + txt_dirrecion_Agregarcliente.Text + "',' " + txt_Correo_Agregarcliente.Text + "',' " + txt_descripcion_Agregarcliente.Text + "', '1')");
                limpiarForm();
                home.limpiarPanel();
                fi.cliente();
                home.AbrirFormEnPanel(fi);
                MessageBox.Show("Correcto");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
