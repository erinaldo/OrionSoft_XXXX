using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanredes
{
    
    public partial class form_Herramientas : Form
    {
        Logica logica = new Logica();
        form_AgregarHerramienta fah = new form_AgregarHerramienta();
        public form_Herramientas()
        {
            InitializeComponent();
        }

        private void form_Herramientas_Load(object sender, EventArgs e)
        {

        }
        public void herramienta()
        {
            dgw_Herramientas.DataSource = logica.llenardgw("select * from Herramientas");
        }

        private void btn_AgregarHerramienta_Click(object sender, EventArgs e)
        {
            fah.ShowDialog();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_Herramientas.SelectedRows != null)
            {
                //fah.ShowDialog();
                fah.editar(dgw_Herramientas.CurrentRow.Cells[0].Value.ToString());
                fah.ShowDialog();

            }
                

        }
    }
}
