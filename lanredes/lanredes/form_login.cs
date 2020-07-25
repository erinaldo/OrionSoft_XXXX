using System;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_login : Form
    {
        Home home = new Home();
        public static string user;
        public static string pass;

        public form_login()
        {
            InitializeComponent();
        }

        private void img_Cerrar_Login_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de Salir", "Atencion", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btn_Ingresar_Login_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            //user = textBox1.Text;
            //pass = textBox2.Text;
            //if (datos.ingresar(textBox1.Text, textBox2.Text))            
            if(textBox1 !=null)
            {
                //home.nombre(datos.consultarDato("select nombre from Usuarios where id=1"));
                //home.apellido(datos.consultarDato("select apellido from Usuarios where id=1"));
                //home.cargo(datos.consultarDato("select cargo from Usuarios where id=1"));
                home.Show();
                this.Hide();
            }
        }
    }
}
