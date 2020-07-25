using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lanredes
{
    public partial class form_AgregarEmpleado : Form
    {
        Datos datos = new Datos();
        Logica logica = new Logica();
        public void constructor()
        {
            txt_Cedula_AgregarEmpleados.Text = "";
            txt_Nombres_AgregarEmpleados.Text = "";
            txt_Apellido_AgregarEmpleados.Text = "";
            cb_Alturas_AgregarEmpleados.Text = "";
            dia_fci_empleados.Text = "";
            dia_fcs_empleados.Text = "";
            mes_fci_empleados.Text = "";
            mes_fcs_empleados.Text = "";
            ano_fci_empleados.Text = "";
            ano_fcs_empleados.Text = "";
        }
        public form_AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btn_Agregar_AgregarEmpleados_Click(object sender, EventArgs e)
        {
            form_Empleados fe = new form_Empleados();
            Home home = new Home();
            if (verifivarVacio() == true)
            {
                if (txt_Cedula_AgregarEmpleados.Text != logica.comprobarSiYaExiste("cedula", "Empleado", txt_Cedula_AgregarEmpleados.Text))
                {
                    try
                    {
                        string opcion;
                        opcion = cb_Alturas_AgregarEmpleados.SelectedItem.ToString();
                        if (dia_fcs_empleados.Text == "" && mes_fcs_empleados.Text == "" && ano_fcs_empleados.Text == "")
                        {
                            datos.insertarDatos("INSERT INTO Empleado (`cedula`, `nombre`, `apellido`, `cursoAltura`,`fechaInicio`,`fechaSalida`) VALUES('" + txt_Cedula_AgregarEmpleados.Text + "','" + txt_Nombres_AgregarEmpleados.Text + "',' " + txt_Apellido_AgregarEmpleados.Text + "','" + opcion + "','" + ano_fci_empleados.Text + "/" + mes_fci_empleados.Text + "/" + dia_fci_empleados.Text + "', NULL)");
                        }
                        else
                        {
                            datos.insertarDatos("INSERT INTO Empleado (`cedula`, `nombre`, `apellido`, `cursoAltura`,`fechaInicio`,`fechaSalida`) VALUES('" + txt_Cedula_AgregarEmpleados.Text + "','" + txt_Nombres_AgregarEmpleados.Text + "',' " + txt_Apellido_AgregarEmpleados.Text + "','" + opcion + "','" + ano_fci_empleados.Text + "/" + mes_fci_empleados.Text + "/" + dia_fci_empleados.Text + "','" + ano_fcs_empleados.Text + "/" + mes_fcs_empleados.Text + "/" + dia_fcs_empleados.Text + "')");
                        }
                        constructor();
                        home.limpiarPanel();
                        fe.empleado();
                        home.AbrirFormEnPanel(fe);
                        MessageBox.Show("Correcto");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error al insertar");
                    }
                }
                else
                {
                    MessageBox.Show("El cliente " + txt_Nombres_AgregarEmpleados.Text + " " + txt_Apellido_AgregarEmpleados.Text + " ya esta registrado con cedula  " + txt_Cedula_AgregarEmpleados.Text);
                    constructor();
                }
            }
            else
            {
                constructor();
                lbl_ErrorApellido.Visible = false;
                lbl_ErrorCedula.Visible = false;
                lbl_ErrorNombre.Visible = false;
                lbl_ErrorAlturas.Visible = false;
                lbl_ErrorFechaIngreso.Visible = false;
            }
        }

        private void cb_Alturas_AgregarEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool verifivarVacio()
        {
            lbl_ErrorApellido.Visible = false;
            lbl_ErrorCedula.Visible = false;
            lbl_ErrorNombre.Visible = false;
            lbl_ErrorAlturas.Visible = false;
            lbl_ErrorFechaIngreso.Visible = false;
            bool valor = true;
            if (logica.verificarVacio(txt_Cedula_AgregarEmpleados.Text))
            {
                mostrarLabel(lbl_ErrorCedula);
                valor = false;
            }
            if (logica.verificarVacio(txt_Nombres_AgregarEmpleados.Text))
            {
                mostrarLabel(lbl_ErrorNombre);
            }
            if (logica.verificarVacio(txt_Apellido_AgregarEmpleados.Text))
            {
                mostrarLabel(lbl_ErrorApellido);
                valor = false;
            }
            if (logica.verificarVacio(cb_Alturas_AgregarEmpleados.Text))
            {
                mostrarLabel(lbl_ErrorAlturas);
                valor = false;
            }
            if (logica.verificarVacio(dia_fci_empleados.Text) && logica.verificarVacio(mes_fci_empleados.Text) && logica.verificarVacio(ano_fci_empleados.Text))
            {
                mostrarLabel(lbl_ErrorFechaIngreso);
                valor = false;
            }
            if (valor == false)
            {
                errorVacio();
            }
            return valor;
        }
        private void errorVacio()
        {
            MessageBox.Show(" Error!\nCampos vacios, verifica e intenta nuevamente");
        }
        private void mostrarLabel(Label label)
        {
            label.Visible = true;
        }

        private void txt_Cedula_AgregarEmpleados_TextChanged(object sender, EventArgs e)
        {
            if (txt_Cedula_AgregarEmpleados.Text != "")
            {
                if (logica.verificarFormatoNumerico(txt_Cedula_AgregarEmpleados.Text) == false)
                {
                    lbl_ErrorCedula.Text = "Formato de cedula incorecto!";
                    lbl_ErrorCedula.Visible = true;
                    MessageBox.Show("Error!\nFormato de cedula no reconocido");
                }
                else
                {
                    lbl_ErrorCedula.Visible = false;
                }
            }
            else
            {
                lbl_ErrorCedula.Visible = false;
            }
        }
    }
}
