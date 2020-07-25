using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_AgregarHerramienta : Form
    {
        Logica logica = new Logica();
        //static bool _editar = false;
        public form_AgregarHerramienta()
        {
            InitializeComponent();
        }

        public void constructor()
        {
            txt_marca.Text = "";
            txt_nombre.Text = "";
            txt_serial.Text = "";
            lbl_id.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verificaVacio())
            {

                if (button1.Text!="Editar")
                {
                    //try
                    //{
                        logica.insertarDatos("INSERT INTO Herramientas (`estado`,`marca`,`serial`,`nombre`) VALUES('1','" + txt_marca.Text + "','" + txt_serial.Text + "','" + txt_nombre.Text + "')");
                        MessageBox.Show("Correcto");
                        constructor();
                        this.Close();
                    //}
                    //catch
                    //{
                        MessageBox.Show("Error al insertar los datos\nintenta nuevamente" + MessageBoxIcon.Error);
                    //}
                }
                else
                {
                    string estado;
                    if(lbl_estado.Text== "Disponible")
                    {
                        estado = "1";
                    }
                    else
                    {
                        estado = "0";
                    }
                    //update campos
                    logica.insertarDatos("update Herramientas set marca='" + txt_marca.Text + "', serial='" + txt_serial.Text + "', nombre='" + txt_nombre.Text + "',estado='"+estado+"'  where id = "+lbl_id.Text+"");
                    MessageBox.Show("Correcto");
                    constructor();
                    button1.Text = "AGREGAR";
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error! Campos vacios\nverifica e intenta nuevamente");
            }
        }

        private bool verificaVacio()
        {
            bool valor = true;
            lbl_Vacionombre.Visible = false;
            lbl_Vacioserial.Visible = false;
            if (logica.verificarVacio(txt_nombre.Text))
            {
                valor = false;
                lbl_Vacionombre.Visible = true;
            }
            if (logica.verificarVacio(txt_serial.Text))
            {
                valor = false;
                lbl_Vacioserial.Visible = true;
            }
            return valor;
        }











        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void form_AgregarHerramienta_Load(object sender, EventArgs e)
        {
            //editar("1");
        }


        public void editar(string fila)
        {
            button1.Text = "Editar";
            MySqlDataReader almacena = null;
            almacena=logica.consultar("select * from Herramientas where id="+fila+"");
            almacena.Read();
            lbl_id.Text = almacena.GetValue(0).ToString();
            txt_nombre.Text= almacena.GetValue(1).ToString();
            txt_marca.Text= almacena.GetValue(2).ToString();
            txt_serial.Text= almacena.GetValue(3).ToString();
            if (almacena.GetValue(4).ToString() == "1"){
                lbl_estado.Text = "Disponible";
                lbl_estado.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                lbl_estado.Text = "No disponible";
                lbl_estado.BackColor = System.Drawing.Color.Red;
            }

        }
        private void label7_Click(object sender, EventArgs e)
        {
            if (lbl_estado.Text != "No disponible")
            {
                lbl_estado.Text = "No disponible";
                lbl_estado.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                lbl_estado.Text = "Disponible";
                lbl_estado.BackColor = System.Drawing.Color.Lime;
            }
        }

        private void lbl_Vacionombre_Click(object sender, EventArgs e)
        {

        }
    }
}
