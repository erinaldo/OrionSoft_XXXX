using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_AgragarCliente : Form
    {
        Logica logica = new Logica();
        Datos datos = new Datos();

        public void constructor()
        {
            txt_cedula_Agregarcliente.Text = "";
            txt_Nombre_Agregarcliente.Text = "";
            txt_Apellidos_Agregarcliente.Text = "";
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
            string consulta = cb_ciudad_Agregarcliente.Text;
            //MySqlDataReader temporal;
            if (verifivarVacio()==true)
            {
                //temporal = datos.consultarDatos("select id from ciudad where upper(nombre)=upper('" + consulta + "')");
                //temporal.Read();
                if (txt_cedula_Agregarcliente.Text != logica.comprobarSiYaExiste("cedula", "Cliente", txt_cedula_Agregarcliente.Text))
                {
                    try
                    {
                        //txt_descripcion_Agregarcliente.Text = datos.consultarDatos("a");
                        //datos.insertarDatos("INSERT INTO Cliente (`cedula`, `nombre`, `apellido`, `direccion`, `correo`, `observaciones`, `codCiudad`) VALUES('" + txt_cedula_Agregarcliente.Text + "',' " + txt_Nombre_Agregarcliente.Text + "',' " + txt_Apellidos_Agregarcliente.Text + "',' " + txt_dirrecion_Agregarcliente.Text + "',' " + txt_Correo_Agregarcliente.Text + "',' " + txt_descripcion_Agregarcliente.Text + "', '" + temporal.GetValue(0).ToString() + "')");
                        logica.insertarDatos("INSERT INTO Cliente (`cedula`, `nombre`, `apellido`, `direccion`, `correo`, `observaciones`, `codCiudad`) VALUES('" + txt_cedula_Agregarcliente.Text + "',' " + txt_Nombre_Agregarcliente.Text + "',' " + txt_Apellidos_Agregarcliente.Text + "',' " + txt_dirrecion_Agregarcliente.Text + "',' " + txt_Correo_Agregarcliente.Text + "',' " + txt_descripcion_Agregarcliente.Text + "', '" + logica.covertirCiudad("select id from ciudad where upper(nombre)=upper('" + consulta + "')") + "')");
                        constructor();
                        fi.cliente();
                        home.AbrirFormEnPanel(fi);
                        MessageBox.Show("Correcto");
                        home.limpiarPanel();
                        this.Refresh();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente " + txt_Nombre_Agregarcliente.Text + " " + txt_Apellidos_Agregarcliente.Text + " ya esta registrado con cedula  " + txt_cedula_Agregarcliente.Text);

                }
            }
        }

        private bool verifivarVacio()
        {
            lbl_ErrorApellido.Visible = false;
            lbl_ErrorCedula.Visible = false;
            lbl_Errorciudad.Visible = false;
            lbl_ErrorCorreo.Visible = false;
            lbl_ErrorDirrecion.Visible = false;
            lbl_ErrorNombre.Visible = false;
            lbl_ErrorTelefono.Visible = false;
            bool valor=true;
            if (logica.verificarVacio(txt_cedula_Agregarcliente.Text))
            {
                mostrarLabel(lbl_ErrorCedula);
                valor = false;
            }
            if (logica.verificarVacio(txt_Nombre_Agregarcliente.Text))
            {
                mostrarLabel(lbl_ErrorNombre);
                valor = false;
            }
            if (logica.verificarVacio(txt_Apellidos_Agregarcliente.Text))
            {
                mostrarLabel(lbl_ErrorApellido);
                valor = false;
            }
            if (logica.verificarVacio(txt_Correo_Agregarcliente.Text))
            {
                mostrarLabel(lbl_ErrorCorreo);
                valor = false;
            }
            if (logica.verificarVacio(cb_ciudad_Agregarcliente.Text))
            {
                mostrarLabel(lbl_Errorciudad);
                valor = false;
            }
            if (valor==false){
                errorVacio();
            }
            return valor;

        }
        private void errorVacio()
        {
            MessageBox.Show(" Error!\nCampos vacios, verifica e intenta nuevamente");
        }
        private void mostrarLabel(Label label)
        {
            label.Visible = true;
        }



        private void form_AgragarCliente_Load(object sender, EventArgs e)
        {
            cb_ciudad_Agregarcliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cb_ciudad_Agregarcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void actualizarCombo(MySqlDataReader almacena)
        {
            while (almacena.Read())
            {
                cb_ciudad_Agregarcliente.Items.Add(almacena.GetValue(0).ToString());
                cb_ciudad_Agregarcliente.Refresh();
            }
            almacena.Close();
        }

        private void txt_cedula_Agregarcliente_TextChanged(object sender, EventArgs e)
        {
            lbl_ErrorCedula.Visible = false;
            if (txt_cedula_Agregarcliente.Text!="")
            {
                if (logica.verificarFormatoNumerico(txt_cedula_Agregarcliente.Text) == false)
                {
                    lbl_ErrorCedula.Text = "Formato de cedula incorecto!";
                    lbl_ErrorCedula.Visible = true;
                    MessageBox.Show("Error!\nFormato de cedula no reconocido");
                    lbl_ErrorCedula.Text = "Campo vacio";
                }
            }
            
        }

        private void txt_Telefono_Agregarcliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_Telefono_Agregarcliente.Text!="")
            {
                lbl_ErrorTelefono.Visible = false;
                if (logica.verificarFormatoNumerico(txt_Telefono_Agregarcliente.Text) == false)
                {
                    lbl_ErrorTelefono.Text = "Formato de telefono incorecto!";
                    lbl_ErrorTelefono.Visible = true;
                    MessageBox.Show("Error!\nFormato de telefono no reconocido");
                    lbl_ErrorTelefono.Text = "Campo Vacio";
                }
            }
        }

        
       public void editar(string cedula,string nombre,string apellidos,string direccion,string correo/*,string telefono*/,string descripcion)
       {            
            txt_cedula_Agregarcliente.Text= cedula;
            txt_Nombre_Agregarcliente.Text=nombre;
            txt_Apellidos_Agregarcliente.Text= apellidos;
            txt_dirrecion_Agregarcliente.Text= direccion;
            txt_Correo_Agregarcliente.Text= correo;
            //= ciudad;
            //txt_dirrecion_Agregarcliente.Text= descripcion;
            txt_descripcion_Agregarcliente.Text = descripcion;
            string consulta = "select tc.telefono from telefonoCliente tc JOIN Cliente c ON c.cedula=tc.cedCliente WHERE tc.cedCliente=" + cedula + "";
            string telefono = datos.consultarDato(consulta);
            txt_Telefono_Agregarcliente.Text = telefono;


        }
    }




}
