namespace lanredes
{
    partial class form_AgregarEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cedula_AgregarEmpleados = new System.Windows.Forms.TextBox();
            this.txt_Nombres_AgregarEmpleados = new System.Windows.Forms.TextBox();
            this.txt_Apellido_AgregarEmpleados = new System.Windows.Forms.TextBox();
            this.cb_Alturas_AgregarEmpleados = new System.Windows.Forms.ComboBox();
            this.btn_Agregar_AgregarEmpleados = new System.Windows.Forms.Button();
            this.dia_fci_empleados = new System.Windows.Forms.ComboBox();
            this.mes_fci_empleados = new System.Windows.Forms.ComboBox();
            this.ano_fci_empleados = new System.Windows.Forms.ComboBox();
            this.dia_fcs_empleados = new System.Windows.Forms.ComboBox();
            this.mes_fcs_empleados = new System.Windows.Forms.ComboBox();
            this.ano_fcs_empleados = new System.Windows.Forms.ComboBox();
            this.lbl_ErrorCedula = new System.Windows.Forms.Label();
            this.lbl_ErrorNombre = new System.Windows.Forms.Label();
            this.lbl_ErrorApellido = new System.Windows.Forms.Label();
            this.lbl_ErrorAlturas = new System.Windows.Forms.Label();
            this.lbl_ErrorFechaIngreso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha salida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha ingreso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alturas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombres:";
            // 
            // txt_Cedula_AgregarEmpleados
            // 
            this.txt_Cedula_AgregarEmpleados.Location = new System.Drawing.Point(137, 20);
            this.txt_Cedula_AgregarEmpleados.Multiline = true;
            this.txt_Cedula_AgregarEmpleados.Name = "txt_Cedula_AgregarEmpleados";
            this.txt_Cedula_AgregarEmpleados.Size = new System.Drawing.Size(207, 20);
            this.txt_Cedula_AgregarEmpleados.TabIndex = 6;
            this.txt_Cedula_AgregarEmpleados.TextChanged += new System.EventHandler(this.txt_Cedula_AgregarEmpleados_TextChanged);
            // 
            // txt_Nombres_AgregarEmpleados
            // 
            this.txt_Nombres_AgregarEmpleados.Location = new System.Drawing.Point(137, 59);
            this.txt_Nombres_AgregarEmpleados.Multiline = true;
            this.txt_Nombres_AgregarEmpleados.Name = "txt_Nombres_AgregarEmpleados";
            this.txt_Nombres_AgregarEmpleados.Size = new System.Drawing.Size(243, 20);
            this.txt_Nombres_AgregarEmpleados.TabIndex = 7;
            // 
            // txt_Apellido_AgregarEmpleados
            // 
            this.txt_Apellido_AgregarEmpleados.Location = new System.Drawing.Point(137, 103);
            this.txt_Apellido_AgregarEmpleados.Multiline = true;
            this.txt_Apellido_AgregarEmpleados.Name = "txt_Apellido_AgregarEmpleados";
            this.txt_Apellido_AgregarEmpleados.Size = new System.Drawing.Size(243, 18);
            this.txt_Apellido_AgregarEmpleados.TabIndex = 8;
            // 
            // cb_Alturas_AgregarEmpleados
            // 
            this.cb_Alturas_AgregarEmpleados.FormattingEnabled = true;
            this.cb_Alturas_AgregarEmpleados.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cb_Alturas_AgregarEmpleados.Location = new System.Drawing.Point(137, 146);
            this.cb_Alturas_AgregarEmpleados.Name = "cb_Alturas_AgregarEmpleados";
            this.cb_Alturas_AgregarEmpleados.Size = new System.Drawing.Size(70, 21);
            this.cb_Alturas_AgregarEmpleados.TabIndex = 9;
            this.cb_Alturas_AgregarEmpleados.SelectedIndexChanged += new System.EventHandler(this.cb_Alturas_AgregarEmpleados_SelectedIndexChanged);
            // 
            // btn_Agregar_AgregarEmpleados
            // 
            this.btn_Agregar_AgregarEmpleados.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_AgregarEmpleados.Location = new System.Drawing.Point(158, 294);
            this.btn_Agregar_AgregarEmpleados.Name = "btn_Agregar_AgregarEmpleados";
            this.btn_Agregar_AgregarEmpleados.Size = new System.Drawing.Size(143, 43);
            this.btn_Agregar_AgregarEmpleados.TabIndex = 12;
            this.btn_Agregar_AgregarEmpleados.Text = "Agregar";
            this.btn_Agregar_AgregarEmpleados.UseVisualStyleBackColor = true;
            this.btn_Agregar_AgregarEmpleados.Click += new System.EventHandler(this.btn_Agregar_AgregarEmpleados_Click);
            // 
            // dia_fci_empleados
            // 
            this.dia_fci_empleados.FormattingEnabled = true;
            this.dia_fci_empleados.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dia_fci_empleados.Location = new System.Drawing.Point(137, 197);
            this.dia_fci_empleados.Name = "dia_fci_empleados";
            this.dia_fci_empleados.Size = new System.Drawing.Size(45, 21);
            this.dia_fci_empleados.TabIndex = 13;
            // 
            // mes_fci_empleados
            // 
            this.mes_fci_empleados.FormattingEnabled = true;
            this.mes_fci_empleados.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.mes_fci_empleados.Location = new System.Drawing.Point(188, 197);
            this.mes_fci_empleados.Name = "mes_fci_empleados";
            this.mes_fci_empleados.Size = new System.Drawing.Size(45, 21);
            this.mes_fci_empleados.TabIndex = 14;
            // 
            // ano_fci_empleados
            // 
            this.ano_fci_empleados.FormattingEnabled = true;
            this.ano_fci_empleados.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005"});
            this.ano_fci_empleados.Location = new System.Drawing.Point(239, 197);
            this.ano_fci_empleados.Name = "ano_fci_empleados";
            this.ano_fci_empleados.Size = new System.Drawing.Size(88, 21);
            this.ano_fci_empleados.TabIndex = 15;
            // 
            // dia_fcs_empleados
            // 
            this.dia_fcs_empleados.FormattingEnabled = true;
            this.dia_fcs_empleados.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dia_fcs_empleados.Location = new System.Drawing.Point(137, 244);
            this.dia_fcs_empleados.Name = "dia_fcs_empleados";
            this.dia_fcs_empleados.Size = new System.Drawing.Size(45, 21);
            this.dia_fcs_empleados.TabIndex = 16;
            // 
            // mes_fcs_empleados
            // 
            this.mes_fcs_empleados.FormattingEnabled = true;
            this.mes_fcs_empleados.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.mes_fcs_empleados.Location = new System.Drawing.Point(188, 244);
            this.mes_fcs_empleados.Name = "mes_fcs_empleados";
            this.mes_fcs_empleados.Size = new System.Drawing.Size(45, 21);
            this.mes_fcs_empleados.TabIndex = 17;
            // 
            // ano_fcs_empleados
            // 
            this.ano_fcs_empleados.FormattingEnabled = true;
            this.ano_fcs_empleados.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009"});
            this.ano_fcs_empleados.Location = new System.Drawing.Point(239, 244);
            this.ano_fcs_empleados.Name = "ano_fcs_empleados";
            this.ano_fcs_empleados.Size = new System.Drawing.Size(88, 21);
            this.ano_fcs_empleados.TabIndex = 18;
            // 
            // lbl_ErrorCedula
            // 
            this.lbl_ErrorCedula.AutoSize = true;
            this.lbl_ErrorCedula.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorCedula.Location = new System.Drawing.Point(350, 23);
            this.lbl_ErrorCedula.Name = "lbl_ErrorCedula";
            this.lbl_ErrorCedula.Size = new System.Drawing.Size(69, 13);
            this.lbl_ErrorCedula.TabIndex = 19;
            this.lbl_ErrorCedula.Text = "Campo vacio";
            this.lbl_ErrorCedula.Visible = false;
            // 
            // lbl_ErrorNombre
            // 
            this.lbl_ErrorNombre.AutoSize = true;
            this.lbl_ErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorNombre.Location = new System.Drawing.Point(386, 62);
            this.lbl_ErrorNombre.Name = "lbl_ErrorNombre";
            this.lbl_ErrorNombre.Size = new System.Drawing.Size(69, 13);
            this.lbl_ErrorNombre.TabIndex = 20;
            this.lbl_ErrorNombre.Text = "Campo vacio";
            this.lbl_ErrorNombre.Visible = false;
            // 
            // lbl_ErrorApellido
            // 
            this.lbl_ErrorApellido.AutoSize = true;
            this.lbl_ErrorApellido.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorApellido.Location = new System.Drawing.Point(386, 106);
            this.lbl_ErrorApellido.Name = "lbl_ErrorApellido";
            this.lbl_ErrorApellido.Size = new System.Drawing.Size(69, 13);
            this.lbl_ErrorApellido.TabIndex = 21;
            this.lbl_ErrorApellido.Text = "Campo vacio";
            this.lbl_ErrorApellido.Visible = false;
            // 
            // lbl_ErrorAlturas
            // 
            this.lbl_ErrorAlturas.AutoSize = true;
            this.lbl_ErrorAlturas.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorAlturas.Location = new System.Drawing.Point(213, 152);
            this.lbl_ErrorAlturas.Name = "lbl_ErrorAlturas";
            this.lbl_ErrorAlturas.Size = new System.Drawing.Size(69, 13);
            this.lbl_ErrorAlturas.TabIndex = 22;
            this.lbl_ErrorAlturas.Text = "Campo vacio";
            this.lbl_ErrorAlturas.Visible = false;
            // 
            // lbl_ErrorFechaIngreso
            // 
            this.lbl_ErrorFechaIngreso.AutoSize = true;
            this.lbl_ErrorFechaIngreso.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorFechaIngreso.Location = new System.Drawing.Point(333, 205);
            this.lbl_ErrorFechaIngreso.Name = "lbl_ErrorFechaIngreso";
            this.lbl_ErrorFechaIngreso.Size = new System.Drawing.Size(69, 13);
            this.lbl_ErrorFechaIngreso.TabIndex = 23;
            this.lbl_ErrorFechaIngreso.Text = "Campo vacio";
            this.lbl_ErrorFechaIngreso.Visible = false;
            // 
            // form_AgregarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 356);
            this.Controls.Add(this.lbl_ErrorFechaIngreso);
            this.Controls.Add(this.lbl_ErrorAlturas);
            this.Controls.Add(this.lbl_ErrorApellido);
            this.Controls.Add(this.lbl_ErrorNombre);
            this.Controls.Add(this.lbl_ErrorCedula);
            this.Controls.Add(this.ano_fcs_empleados);
            this.Controls.Add(this.mes_fcs_empleados);
            this.Controls.Add(this.dia_fcs_empleados);
            this.Controls.Add(this.ano_fci_empleados);
            this.Controls.Add(this.mes_fci_empleados);
            this.Controls.Add(this.dia_fci_empleados);
            this.Controls.Add(this.btn_Agregar_AgregarEmpleados);
            this.Controls.Add(this.cb_Alturas_AgregarEmpleados);
            this.Controls.Add(this.txt_Apellido_AgregarEmpleados);
            this.Controls.Add(this.txt_Nombres_AgregarEmpleados);
            this.Controls.Add(this.txt_Cedula_AgregarEmpleados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "form_AgregarEmpleado";
            this.Text = "ORION-Agregar empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Cedula_AgregarEmpleados;
        private System.Windows.Forms.TextBox txt_Nombres_AgregarEmpleados;
        private System.Windows.Forms.TextBox txt_Apellido_AgregarEmpleados;
        private System.Windows.Forms.ComboBox cb_Alturas_AgregarEmpleados;
        private System.Windows.Forms.Button btn_Agregar_AgregarEmpleados;
        private System.Windows.Forms.ComboBox dia_fci_empleados;
        private System.Windows.Forms.ComboBox mes_fci_empleados;
        private System.Windows.Forms.ComboBox ano_fci_empleados;
        private System.Windows.Forms.ComboBox dia_fcs_empleados;
        private System.Windows.Forms.ComboBox mes_fcs_empleados;
        private System.Windows.Forms.ComboBox ano_fcs_empleados;
        private System.Windows.Forms.Label lbl_ErrorCedula;
        private System.Windows.Forms.Label lbl_ErrorNombre;
        private System.Windows.Forms.Label lbl_ErrorApellido;
        private System.Windows.Forms.Label lbl_ErrorAlturas;
        private System.Windows.Forms.Label lbl_ErrorFechaIngreso;
    }
}