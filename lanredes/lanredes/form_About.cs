using System;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_About : Form
    {
        Desarrolladores desarrolladores = new Desarrolladores();
        uppdate uppdate = new uppdate();

        public form_About()
        {
            InitializeComponent();
        }

        private void form_About_Load(object sender, EventArgs e)
        {

        }
        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        public void AbrirFormEnPanel(object formHijo)
        {
            limpiarPanel();
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        //METODO PARA LIMPIAR FORM DENTRO DE PANEL-----------------------------------------------------
        public void limpiarPanel()
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
        }

        private void desarrolladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            AbrirFormEnPanel(desarrolladores);
        }

        private void ActualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            AbrirFormEnPanel(uppdate);
        }
    }
}
