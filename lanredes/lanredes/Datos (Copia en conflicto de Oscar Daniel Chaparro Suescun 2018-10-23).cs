using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
//using System.Data.OracleClient;

namespace lanredes
{
   public class Datos
    {
        static form_AgragarCliente fac = new form_AgragarCliente();
        /*public OracleConnection conexion_Login()
        {
            OracleConnection  ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD=preparcial ;USER ID = preparcial;");
            return ora;
        }

        public void abrir_Conexion(OracleConnection ora)
        {
            ora.Open();
        }

        public void cerrar_conexion(OracleConnection ora)
        {
            ora.Close();
        }*/

        ///////////////////Conect mysql////////////////////////////
        public string conex;
        public MySqlConnection conectar;
        public DataSet dst;
        public MySqlDataAdapter adaptador;
        public void conexionMySql()
        {
                conex = "Server=db4free.net; Database=lanredes; Uid=lanredesadmin; Pwd=administrador; Port=3306; old guids = true; ";
                //conex = @"Server=db4free.net; Database=lanredes; Uid=lanredesadmin; Pwd=administrador; Port=3306;";
                conectar = new MySqlConnection(conex);
                conectar.Open();
        }
        public DataTable llenarDgw()
        {
            conexionMySql();
            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter("SELECT* FROM Cliente;", conectar);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            // Se asigna el DataTable como origen de datos del DataGridView
            //dgvDatos.DataSource = dtDatos;

            // Se cierra la conexión a la base de datos
            conectar.Close();
            return dtDatos;
        }

        public void agregarUsuario()
        {
            MySqlCommand cmd = conectar.CreateCommand();
            cmd.CommandText = "INSERT INTO 'Cliente' ('cedula', 'nombre', 'apellido', 'direccion', 'correo', 'observaciones', 'codCiudad') VALUES('" + fac.cedula + "', '" + fac.nombre + "', '" + fac.apellido + "', '" + fac.direccion + "', '" + fac.correo + "', '" + fac.descripcion+ "', '1')";
            conectar.Open();
            cmd.ExecuteNonQuery();
            conectar.Close();


            //string cliente="INSERT INTO 'Cliente' ('cedula', 'nombre', 'apellido', 'direccion', 'correo', 'observaciones', 'codCiudad') VALUES('1005295044', 'jhon', 'velasco', 'calle 5#13-86 florida', 'frediv0406@gmail.com', 'AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA', '1')";
            //return cliente;
        }

    }
}
