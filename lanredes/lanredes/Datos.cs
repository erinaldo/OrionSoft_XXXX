using System;
using System.Data;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using System.Data.OracleClient;

namespace lanredes
{
    public class Datos
    {
        Home home = new Home();

        public static string user="proyecto", password="proyecto";
        public static string _user
        {
            get { return user; }
            set { user = value; }
        }
        public static string _password
        {
            get { return password; }
            set { password = value; }
        }
        




        static form_AgragarCliente fac = new form_AgragarCliente();
        public bool ingresar(string userm, string passm)
        {
            _user = userm;
            _password = passm;
            bool valor = true;
            try
            {
                conexionMySql();
                valor = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al iniciar sesion\nVerifica tus datos e intenta nuevamente", e.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                valor = false;
            }
            return valor;
        }
        
        //public MySqlConnection conectar=new MySqlConnection("Server=localhost; Database=proyectointegrador; Uid=" + user + "; Pwd=" + password+ "; Port=3306;");
        public MySqlConnection conectar = new MySqlConnection("Server=190.90.160.170; Database=udivivec_lan_redes; Uid=udivivec_lanredesadmin; Pwd=lanredesadmin; Port=3306; old guids = true; ");
        public DataSet dst;
        public MySqlDataAdapter adaptador;
        public void conexionMySql()
        {

            //string conex = "Server=localhost; Database=proyectointegrador; Uid=" + user + "; Pwd=" + password + "; Port=3306;";
            string conex = "Server=190.90.160.170; Database=udivivec_lan_redes; Uid=udivivec_lanredesadmin; Pwd=lanredesadmin; Port=3306;old guids = true;";
            conectar = new MySqlConnection(conex);
            if (conectar != null)
            {
                conectar.Close();
            }
            conectar.Open();
        }

        public void abrirConexion()
        {
            if (conectar == null)
                conectar.Open();
        }
        public void cerrarConexion()
        {
            if (conectar != null)
                conectar.Close();          
        }


        public DataTable llenarDgw()
        {
            abrirConexion();
            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();
            //string valor = "1";
            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT * FROM Cliente;", conectar);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);
            // Se cierra la conexión a la base de datos
            cerrarConexion();
            return dtDatos;
        }

        public DataTable llenarDgwGeneral(string consulta)
        {
            //conectar.Close();
            abrirConexion();
            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(consulta, conectar);
            try
            {
                mdaDatos.Fill(dtDatos);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los datos.\nVerifica tu conexion e intenta nuevamente"+ex.ToString());
            }
            //cerrarConexion();
            return dtDatos;
        }

        public MySqlDataReader consultarDatos(string consulta)
        {
            MySqlDataReader almacena=null;
            conexionMySql();
            //abrirConexion();
            MySqlCommand cmd = new MySqlCommand(consulta, conectar);
            almacena = cmd.ExecuteReader();//error
            //conectar.Close();
            return almacena;
        }

        public string consultarDato(string consulta)//Metodo que trae un solo dato
        {
            MySqlDataReader almacena = null;
            string resultado;
            conexionMySql();
            //abrirConexion();
            MySqlCommand cmd = new MySqlCommand(consulta, conectar);
            almacena = cmd.ExecuteReader();
            almacena.Read();
            try
            {
                resultado = almacena.GetValue(0).ToString();
            }
            catch (Exception e)
            {
                resultado = "0000";
            }
            return resultado;
        }


        public void insertarDatos(string insert)
        {
            conexionMySql();
            //abrirConexion();
            
            MySqlCommand cmd = new MySqlCommand(insert, conectar);
            cmd.ExecuteNonQuery();
            //cerrarConexion();
        }
        public string llenarVariable(MySqlDataReader consulta)
        {
            string variable;
            // variable = consulta.GetString(consulta);
            return "";
        }

        




    }
}
