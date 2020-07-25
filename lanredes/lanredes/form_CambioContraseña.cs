using System;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_CambioContraseña : Form
    {
        public form_CambioContraseña()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_ContraseñaCorta_CambioContraseña.Visible = false;
            lbl_ContraseñaNoCoincide_CambioContraseña.Visible = false;
            if(txt_Nuevacontraseña_CambioContraseña.TextLength <= 7)
            {
                lbl_ContraseñaCorta_CambioContraseña.Visible = true;
            }
            if(txt_RepetirContraseña_CambioContraseña.Text.Equals(txt_Nuevacontraseña_CambioContraseña.Text) == false)
            {
                lbl_ContraseñaNoCoincide_CambioContraseña.Visible = true;
            }
        }
    }
}
