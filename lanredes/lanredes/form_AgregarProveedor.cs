using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_AgregarProveedor : Form
    {
        Logica logica = new Logica();
        Datos datos = new Datos();
        public void constructor()
        {
            txt_cedula_Agregarproveedor.Text = "";
            txt_nombres_Agregarproveedor.Text = "";
            txt_apellidos_Agregarproveedor.Text = "";
            txt_direccion_Agregarproveedor.Text = "";
            txt_correo_Agregarproveedor.Text = "";
            cb_ciudad_Agregarproveedor.Text = null;
            cb_ciudad_Agregarproveedor.Items.Clear();
            txt_descripcion_Agregarproveedor.Text = "";
            txt_cargo_Agregarproveedor.Text = "";
            txt_telefono_Agregarproveedor.Text = "";
        }
        private bool verifivarVacio()
        {
            lbl_ErrorApellidos.Visible = false;
            lbl_ErrorCedula.Visible = false;
            lbl_ErrorCiudad.Visible = false;
            lbl_ErrorCorreo.Visible = false;
            lbl_ErrorDireccion.Visible = false;
            lbl_ErrorNombres.Visible = false;
            lbl_ErrorCargo.Visible = false;
            lbl_ErrorDireccion.Visible = false;
            bool valor = true;
            if (logica.verificarVacio(txt_cedula_Agregarproveedor.Text))
            {
                mostrarLabel(lbl_ErrorCedula);
                valor = false;
            }
            if (logica.verificarVacio(txt_nombres_Agregarproveedor.Text))
            {
                mostrarLabel(lbl_ErrorNombres);
                valor = false;
            }
            if (logica.verificarVacio(txt_apellidos_Agregarproveedor.Text))
            {
                mostrarLabel(lbl_ErrorApellidos);
                valor = false;
            }
            if (logica.verificarVacio(txt_correo_Agregarproveedor.Text))
            {
                mostrarLabel(lbl_ErrorCorreo);
                valor = false;
            }
            if (logica.verificarVacio(txt_cargo_Agregarproveedor.Text))
            {
                mostrarLabel(lbl_ErrorCargo);
                valor = false;
            }
            if (logica.verificarVacio(txt_telefono_Agregarproveedor.Text))
            {
                mostrarLabel(lbl_ErrorTelefono);
                valor = false;
            }
            if (logica.verificarVacio(txt_direccion_Agregarproveedor.Text))
            {
                mostrarLabel(lbl_ErrorDireccion);
                valor = false;
            }
            if (logica.verificarVacio(cb_ciudad_Agregarproveedor.Text))
            {
                mostrarLabel(lbl_ErrorCiudad);
                valor = false;
            }
            if (valor == false)
            {
                errorVacio();
            }

            return valor;
        }
        private void mostrarLabel(Label label)
        {
            label.Visible = true;
        }
        private void errorVacio()
        {
            MessageBox.Show(" Error!\nCampos vacios, verifica e intenta nuevamente");
        }
        public form_AgregarProveedor()
        {
            InitializeComponent();
        }
        private void form_AgregarProveedor_Load(object sender, EventArgs e)
        {
            cb_ciudad_Agregarproveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void actualizarCombo(MySqlDataReader almacena)
        {
            while (almacena.Read())
            {
                cb_ciudad_Agregarproveedor.Items.Add(almacena.GetValue(0).ToString());
                cb_ciudad_Agregarproveedor.Refresh();
            }
        }

        private void txt_cedula_Agregarproveedor_TextChanged(object sender, EventArgs e)
        {
            if (txt_cedula_Agregarproveedor.Text != "")
            {
                if (logica.verificarFormatoNumerico(txt_cedula_Agregarproveedor.Text) == false)
                {
                    lbl_ErrorCedula.Text = "Formato de cedula incorrecto!";
                    lbl_ErrorCedula.Visible = true;
                    MessageBox.Show("Error!\nFormato de cedula no reconocido");
                }
                else
                {
                    lbl_ErrorCedula.Visible = false;
                }
            }
            else
            {
                lbl_ErrorCedula.Visible = false;
            }
        }

        private void btn_Agregar_Agregarproveedor_Click_1(object sender, EventArgs e)
        {
            form_Proveedores pro = new form_Proveedores();
            Home home = new Home();
            string consulta = cb_ciudad_Agregarproveedor.Text;
            string nombre = "select p.nombre from Proveedor p JOIN telefonoProveedor tp ON p.cedula=tp.cedProveedor WHERE tp.telefono=" + txt_telefono_Agregarproveedor.Text + "";
            string nombre1 = datos.consultarDato(nombre);
            try
            {
                if (verifivarVacio() == true)
                {
                    if (txt_cedula_Agregarproveedor.Text != logica.comprobarSiYaExiste("cedula", "Proveedor", txt_cedula_Agregarproveedor.Text))
                    {
                        if (txt_telefono_Agregarproveedor.Text != logica.comprobarSiYaExiste("telefono", "telefonoProveedor", txt_telefono_Agregarproveedor.Text))
                        {
                            try
                            {
                                logica.insertarDatos("INSERT INTO Proveedor (`cedula`, `nombre`, `apellido`, `direccion`, `cargo`, `correo`, `codCiudad`, `observaciones`) VALUES('" + txt_cedula_Agregarproveedor.Text + "',' " + txt_nombres_Agregarproveedor.Text + "',' " + txt_apellidos_Agregarproveedor.Text + "',' " + txt_direccion_Agregarproveedor.Text + "','" + txt_cargo_Agregarproveedor.Text + "',' " + txt_correo_Agregarproveedor.Text + "',' " + logica.covertirCiudad("select id from ciudad where upper(nombre)=upper('" + consulta + "')") + "', '" + txt_descripcion_Agregarproveedor.Text + "')");
                                logica.insertarDatos("INSERT INTO telefonoProveedor (`id`,`telefono`,`cedProveedor`) VALUES (null,'" + txt_telefono_Agregarproveedor.Text + "','" + txt_cedula_Agregarproveedor.Text + "')");
                                constructor();
                                pro.proveedor();
                                home.AbrirFormEnPanel(pro);
                                MessageBox.Show("Correcto");
                                home.limpiarPanel();
                                this.Refresh();
                                this.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Error");
                                constructor();
                            }
                        }
                        else
                        {
                            MessageBox.Show("El telefono " + txt_telefono_Agregarproveedor.Text + " ya esta registrado y le pertenece al proveedor  " + nombre1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El proveedor " + txt_nombres_Agregarproveedor.Text + " " + txt_apellidos_Agregarproveedor.Text + " ya esta registrado con cedula  " + txt_cedula_Agregarproveedor.Text);
                    }
                }
                else
                {
                    constructor();
                    lbl_ErrorApellidos.Visible = false;
                    lbl_ErrorCedula.Visible = false;
                    lbl_ErrorCiudad.Visible = false;
                    lbl_ErrorCorreo.Visible = false;
                    lbl_ErrorDireccion.Visible = false;
                    lbl_ErrorNombres.Visible = false;
                    lbl_ErrorCargo.Visible = false;
                    lbl_ErrorTelefono.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Por favor llene los campos");
            }
            
        }

        private void cb_ciudad_Agregarproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txt_nombres_Agregarproveedor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_apellidos_Agregarproveedor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_direccion_Agregarproveedor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_cargo_Agregarproveedor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_correo_Agregarproveedor_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_telefono_Agregarproveedor_TextChanged(object sender, EventArgs e)
        {
            if (txt_telefono_Agregarproveedor.Text != "")
            {
                if (logica.verificarFormatoNumerico(txt_telefono_Agregarproveedor.Text) == false)
                {
                    lbl_ErrorTelefono.Text = "Formato de telefono incorrecto!";
                    lbl_ErrorTelefono.Visible = true;
                    MessageBox.Show("Error!\nFormato de telefono no reconocido");
                }
                else
                {
                    lbl_ErrorTelefono.Visible = false;
                }
            }
            else
            {
                lbl_ErrorTelefono.Visible = false;
            }
        }
    }
}

