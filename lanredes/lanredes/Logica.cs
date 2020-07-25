using System;
using System.Data;
using MySql.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace lanredes
{
    public class Logica
    {
        Datos datos = new Datos();
        public int Dia = DateTime.Now.Day;
        public int Mes = DateTime.Now.Month;
        public int Año = DateTime.Now.Year;

        public void agregarCliente()
        {

        }
        public string comprobarSiYaExiste(string campo, string tabla, string condicion)
        {
            MySqlDataReader vari;
            string var;
            vari = datos.consultarDatos("select " + campo + " from " + tabla + " where upper(" + campo + ")=upper(" + condicion + ")");
            vari.Read();
            if (vari.HasRows)//Verifica si tiene Rows
            {
                var = vari.GetValue(0).ToString();
            }
            else
            {
                var = "0";
            }
            return var;
        }
        public bool verificarVacio(string campo)
        {
            bool valor;
            if (campo.Length == 0)
            {
                valor = true;
            }
            else
            {
                valor = false;
            }

            return valor ;
        }
        public void insertarDatos(string sentencia)
        {
            datos.insertarDatos(sentencia);

        }
        public string covertirCiudad(string sentencia)
        {
            MySqlDataReader temporal;
            temporal = datos.consultarDatos(sentencia);
            temporal.Read();

            return temporal.GetValue(0).ToString();
        }
        public MySqlDataReader consultar(string sentencia)
        {
           return datos.consultarDatos(sentencia);
        }
        public bool verificarFormatoNumerico(string text)
        {
            bool bandera=true;
            string mensaje;
            try
            {
                int cedulaI = int.Parse(text);
            }
            catch
            {
                //mensaje = "Formato de text no reconocido";
                bandera = false;
            }
            return bandera;
        }

        public DataTable  llenardgw(string consulta)
        {
            return datos.llenarDgwGeneral(consulta);
        }

        public void deshabilitarTexbox(TextBox textbox)
        {
            textbox.Enabled = false;
        }
        public void deshabilitarCombobox(ComboBox comboBox)
        {
            comboBox.Enabled = false;
        }

        public void habilitarTexbox(TextBox textbox)
        {
            textbox.Enabled = true;
        }
        public void habilitarCombobox(ComboBox comboBox)
        {
            comboBox.Enabled = true;
        }
        public int traerUltimoId(string campo,string tabla)
        {
            string cadena;
            int valor;
            try
            {
                cadena = covertirCiudad("SELECT max(" + campo + ") FROM " + tabla);
                valor = int.Parse(cadena) + 1;
            }
            catch(Exception ex)
            {
                valor = 0;
            }
            return valor;
        }
        public int traerid(string tabla, string nombre, string campo, string campoComparar)
        {
            int valor;
            string consultaId= "select "+campo+" from "+tabla+" where "+campoComparar+" like '"+nombre+"'; ";
            consultaId = datos.consultarDato(consultaId);
            valor = int.Parse(consultaId);
            return valor;
        }
         
    }
}