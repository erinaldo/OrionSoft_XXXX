using System;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_Reporte_HerramientasDisponibles : Form
    {
        Logica logica = new Logica();
        Datos datos = new Datos();
        public form_Reporte_HerramientasDisponibles()
        {
            InitializeComponent();
        }

        private void form_Reporte_HerramientasDisponibles_Load(object sender, EventArgs e)
        {
            
        }
        public void reportes(string sentencia)
        {
            dgw_Herramientas.DataSource = logica.llenardgw(sentencia);
            //this.ShowDialog();
        }
    }
}
