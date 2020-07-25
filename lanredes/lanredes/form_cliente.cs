using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_cliente : Form
    {
        Logica logica=new Logica();
        Datos Datos = new Datos();
        form_AgragarCliente fac = new form_AgragarCliente();
        public string _cedula { get; set; }
        public string _nombre { get; set; }
        public string _apellidos { get; set; }
        public string _direccion { get; set; }
        public string _correo { get; set; }
        public string _telefono { get; set; }
        public string _ciudad { get; set; }
        public string _descripcion { get; set; }
        public  form_cliente(/*string cedula,string nombre,string apellidos,string direccion,string correo,string telefono,string ciudad,string descripcion*/)
        {
            InitializeComponent();
            /*_cedula= cedula;
            _nombre=nombre;
            _apellidos= apellidos;
            _direccion= direccion;
            _correo= correo;
            _telefono=telefono;
            _ciudad= ciudad;
            _descripcion= descripcion;*/
        }
        
        public void btn_buscar_inventario_Click(object sender, EventArgs e)
        {

            fac.actualizarCombo(logica.consultar("select nombre from ciudad"));

            //fac.actualizarCombo(Datos.consultarDatos("select nombre from ciudad"));
            ///logica.consultar("select nombre from ciudad");
            fac.ShowDialog();
        }

        private void form_inventario_Load(object sender, EventArgs e)
        {
            
        }

        public void cliente()
        { 
            dgw_inventario_inventario.DataSource=Datos.llenarDgw();
        }

        private void dgw_inventario_inventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (dgw_inventario_inventario.SelectedRows != null)
            {
                this._cedula=dgw_inventario_inventario.CurrentRow.Cells[0].Value.ToString();
                this._nombre= dgw_inventario_inventario.CurrentRow.Cells[1].Value.ToString();
                this._apellidos= dgw_inventario_inventario.CurrentRow.Cells[2].Value.ToString();
                this._descripcion= dgw_inventario_inventario.CurrentRow.Cells[5].Value.ToString();
                this._correo= dgw_inventario_inventario.CurrentRow.Cells[4].Value.ToString();
                this._direccion= dgw_inventario_inventario.CurrentRow.Cells[3].Value.ToString();
                fac.editar(_cedula,_nombre,_apellidos,_direccion,_correo,_descripcion);
                fac.ShowDialog();

            }
        }
    }
}

