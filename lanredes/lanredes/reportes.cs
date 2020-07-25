using System;
using System.Windows.Forms;

namespace lanredes
{
    public partial class reportes : Form
    {
        Home home = new Home();
        form_Reporte_HerramientasDisponibles frhd = new form_Reporte_HerramientasDisponibles();
        public reportes()
        {
            InitializeComponent();
        }

        private void img_HerraminetasDisponibles_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("jjjjjj");
            frhd.reportes("select id as numero, nombre, marca, serial from Herramientas where estado = 1;");
            frhd.ShowDialog();
            //home.limpiarPanel();
            //home.AbrirFormEnPanel(frhd);
        }

        private void img_EmpleadosConAlturas_Click(object sender, EventArgs e)
        {
            //frhd.Close();
             frhd.reportes("SELECT cedula, upper(nombre) as Nombre,upper(apellido) as Apellido,cursoAltura as Alturas, fechaInicio, fechaSalida from Empleado; where cursoAltura like 'Sí';");
             frhd.ShowDialog();
            
        }
    }
}
