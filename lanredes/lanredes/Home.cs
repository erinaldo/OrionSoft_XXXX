using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
namespace lanredes
{
    public partial class Home : Form
    {
        public static string user = "";
        public static string pass = "";
        static form_cliente fc = new form_cliente();
        static form_ventas fv = new form_ventas();
        static Datos datos = new Datos();
        static form_login login = new form_login();
        static form_Empleados fe = new form_Empleados();
        static form_Productos fp = new form_Productos();
        static form_Herramientas fh = new form_Herramientas();
        static form_Proveedores f_proveedores = new form_Proveedores();
        static reportes reportes= new reportes();
        static form_Compras f_compras = new form_Compras();
        static form_About fa = new form_About();
        public static string _nombre;
        public static string _apellido;
        public static string _cargo;
        public void empleado()
        {
            lbl_Nombre.Text = _nombre;
            lbl_apellido.Text = _apellido;
            lbl_Cargo.Text = _cargo;
        }
        public void nombre(string nombre)
        {
            //set { _nombre = value; }
            //get { return _nombre; }
            lbl_Nombre.Text = nombre;

        }
        public void apellido (string apellido)
        {
            //set { _apellido = value; }
            //get { return _apellido; }
            lbl_apellido.Text = apellido;

        }
        public void cargo(string cargo)
        {
            //set { _cargo = value; }
            //get { return _cargo; }
            lbl_Cargo.Text = cargo;

        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelEncabezado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public Home()
        {
            InitializeComponent();
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            //timer1_Tick();
            //tmFechaHora_Tick();
            //lbl_fecha.Text = DateTime.Now.ToLongDateString();
            //lbl_Hora.Text = DateTime.Now.ToString("HH:mm");
            //datos.conexionMySql();
        }

        private void controlMenu_Click(object sender, EventArgs e)
        {
            panelcontenedor.Width -= 180;
            MenuVertical.Width = 250;
            controlMenu.Visible = false;
            control_menu_vertical_cerrar.Visible = true;
        }
        private void controlMenuVerticalCerrarClick(object sender, EventArgs e)
        {
            MenuVertical.Width = 70;
            controlMenu.Visible = true;
            control_menu_vertical_cerrar.Visible = false;
        }

        private void btnCerrarApp(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de Salir", "Atencion", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaurar.Visible = true;
            maximizar.Visible = false;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            pcColor(pcCompras);
            limpiarPanel();
            AbrirFormEnPanel(f_compras);
            f_compras.llenarData();
        }

        private void btnPreventas_Click(object sender, EventArgs e)
        {
            pcColor(pcPreventas);
            limpiarPanel();
            fh.herramienta();
            AbrirFormEnPanel(fh);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            pcColor(pcProductos);
            limpiarPanel();
            fp.productos();
            AbrirFormEnPanel(fp);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            pcColor(pcCliente);
            limpiarPanel();
            fc.cliente();
            AbrirFormEnPanel(fc);
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            pcColor(pcVentas);
            limpiarPanel();
            fv.llenarData();
            AbrirFormEnPanel(fv);

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            pcColor(pcEmpleados);
            limpiarPanel();
            AbrirFormEnPanel(fe);
            fe.empleado();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            pcColor(pcUsuarios);
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            pcColor(pcProveedores);
            limpiarPanel();
            f_proveedores.proveedor();
            AbrirFormEnPanel(f_proveedores);
        }
        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Boton deshabilitado");
            //limpiarPanel();
            //pcColor(pcUsuarios);
            //AbrirFormEnPanel(fc);
        }
        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            pcColor(pcReportes);
            AbrirFormEnPanel(reportes);
        }
        private void btn_About_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            pcColor(pcAbout);
            AbrirFormEnPanel(fa);
        }
        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        public void AbrirFormEnPanel(object formHijo)
        {
            limpiarPanel();
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }

        //METODO PARA LIMPIAR FORM DENTRO DE PANEL-----------------------------------------------------
        public void limpiarPanel()
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
        }

        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelcontenedor.Region = region;
            this.Invalidate();
        }
        //----------------METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void lbl_fecha_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Hora_Click(object sender, EventArgs e)
        {

        }
        //-------------------Metodo color antes de botones-------------------------------------------------------------
        private void pcColor(Panel pc)
        {
            pcCliente.Visible = false;
            pcCompras.Visible = false;
            pcUsuarios.Visible = false;
            pcPreventas.Visible = false;
            pcProductos.Visible = false;
            pcProveedores.Visible = false;
            pcVentas.Visible = false;
            pcEmpleados.Visible = false;
            pc_Home.Visible = false;
            pcAbout.Visible = false;
            pcReportes.Visible = false;
            pc.Visible = true;
        }
        private void pcColor()
        {
            pcCliente.Visible = false;
            pcCompras.Visible = false;
            pcUsuarios.Visible = false;
            pcPreventas.Visible = false;
            pcProductos.Visible = false;
            pcProveedores.Visible = false;
            pcVentas.Visible = false;
            pcEmpleados.Visible = false;
            pc_Home.Visible = false;
            pcAbout.Visible = false;
            pcReportes.Visible = false;
        }

        private void btn_CerraSeccion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de Cerrar Sesion", "Atencion", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
                login.Show();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            pcColor(pc_Home);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datos.conexionMySql();
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void panelEncabezado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}