namespace lanredes
{
    partial class form_nuevaVenta_Ventas
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
       /* private void InitializeComponent()
        {
            this.lbl_Categoria_NuevaVenta = new System.Windows.Forms.Label();
            this.lbl_NoVenta_Nuevaventa = new System.Windows.Forms.Label();
            this.lbl_Cliente_Nuevaventa = new System.Windows.Forms.Label();
            this.lbl_Direccion_Nuevaventa = new System.Windows.Forms.Label();
            this.lbl_Manode__Nuevaventa = new System.Windows.Forms.Label();
            this.lbl_fecha_Nuevaventa = new System.Windows.Forms.Label();
            this.lbl_servicio_Nuevaventa = new System.Windows.Forms.Label();
            this.dgw_servicio_Nuevaventa = new System.Windows.Forms.DataGridView();
            this.lbl_Descripcion_Nuevaventa = new System.Windows.Forms.Label();
            this.txt_Descripcion_Nuevaventa = new System.Windows.Forms.TextBox();
            this.btn_Agregar_Nuevaventa = new System.Windows.Forms.Button();
            this.btn_FinalizarVenta_Nuevaventa = new System.Windows.Forms.Button();
            this.cb_Servicio_nuevaVenta = new System.Windows.Forms.ComboBox();
            this.cb_Dia = new System.Windows.Forms.ComboBox();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.cb_Mes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Año = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Cedula_NuevaVenta = new System.Windows.Forms.Label();
            this.txt_direccion_Nuevaventa = new System.Windows.Forms.TextBox();
            this.lbl_NombreCliente_NuevaVenta = new System.Windows.Forms.Label();
            this.txt_ValorManoObra_Nuevaventa = new System.Windows.Forms.TextBox();
            this.lbl_Valor_Nuevaventa = new System.Windows.Forms.Label();
            this.lbl_ValorTotal_Nuevaventa = new System.Windows.Forms.Label();
            this.txt_Cedula_NuevaVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_servicio_Nuevaventa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Categoria_NuevaVenta
            // 
            this.lbl_Categoria_NuevaVenta.AutoSize = true;
            this.lbl_Categoria_NuevaVenta.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Categoria_NuevaVenta.Location = new System.Drawing.Point(18, 9);
            this.lbl_Categoria_NuevaVenta.Name = "lbl_Categoria_NuevaVenta";
            this.lbl_Categoria_NuevaVenta.Size = new System.Drawing.Size(78, 23);
            this.lbl_Categoria_NuevaVenta.TabIndex = 5;
            this.lbl_Categoria_NuevaVenta.Text = "N° Venta:";
            this.lbl_Categoria_NuevaVenta.Click += new System.EventHandler(this.lbl_Categoria_NuevaVenta_Click);
            // 
            // lbl_NoVenta_Nuevaventa
            // 
            this.lbl_NoVenta_Nuevaventa.AutoSize = true;
            this.lbl_NoVenta_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_NoVenta_Nuevaventa.Location = new System.Drawing.Point(98, 9);
            this.lbl_NoVenta_Nuevaventa.Name = "lbl_NoVenta_Nuevaventa";
            this.lbl_NoVenta_Nuevaventa.Size = new System.Drawing.Size(50, 23);
            this.lbl_NoVenta_Nuevaventa.TabIndex = 6;
            this.lbl_NoVenta_Nuevaventa.Text = "#####";
            this.lbl_NoVenta_Nuevaventa.Click += new System.EventHandler(this.lbl_NoVenta_Nuevaventa_Click);
            // 
            // lbl_Cliente_Nuevaventa
            // 
            this.lbl_Cliente_Nuevaventa.AutoSize = true;
            this.lbl_Cliente_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Cliente_Nuevaventa.Location = new System.Drawing.Point(35, 61);
            this.lbl_Cliente_Nuevaventa.Name = "lbl_Cliente_Nuevaventa";
            this.lbl_Cliente_Nuevaventa.Size = new System.Drawing.Size(61, 23);
            this.lbl_Cliente_Nuevaventa.TabIndex = 7;
            this.lbl_Cliente_Nuevaventa.Text = "Cliente:";
            this.lbl_Cliente_Nuevaventa.Click += new System.EventHandler(this.lbl_Cliente_Nuevaventa_Click);
            // 
            // lbl_Direccion_Nuevaventa
            // 
            this.lbl_Direccion_Nuevaventa.AutoSize = true;
            this.lbl_Direccion_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Direccion_Nuevaventa.Location = new System.Drawing.Point(17, 87);
            this.lbl_Direccion_Nuevaventa.Name = "lbl_Direccion_Nuevaventa";
            this.lbl_Direccion_Nuevaventa.Size = new System.Drawing.Size(79, 23);
            this.lbl_Direccion_Nuevaventa.TabIndex = 9;
            this.lbl_Direccion_Nuevaventa.Text = "Direccion:";
            this.lbl_Direccion_Nuevaventa.Click += new System.EventHandler(this.lbl_Direccion_Nuevaventa_Click);
            // 
            // lbl_Manode__Nuevaventa
            // 
            this.lbl_Manode__Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Manode__Nuevaventa.Location = new System.Drawing.Point(1, 139);
            this.lbl_Manode__Nuevaventa.Name = "lbl_Manode__Nuevaventa";
            this.lbl_Manode__Nuevaventa.Size = new System.Drawing.Size(95, 58);
            this.lbl_Manode__Nuevaventa.TabIndex = 11;
            this.lbl_Manode__Nuevaventa.Text = "Valor mano \r\nde obra:";
            this.lbl_Manode__Nuevaventa.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_fecha_Nuevaventa
            // 
            this.lbl_fecha_Nuevaventa.AutoSize = true;
            this.lbl_fecha_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_fecha_Nuevaventa.Location = new System.Drawing.Point(37, 113);
            this.lbl_fecha_Nuevaventa.Name = "lbl_fecha_Nuevaventa";
            this.lbl_fecha_Nuevaventa.Size = new System.Drawing.Size(59, 23);
            this.lbl_fecha_Nuevaventa.TabIndex = 12;
            this.lbl_fecha_Nuevaventa.Text = "Fecha:";
            this.lbl_fecha_Nuevaventa.Click += new System.EventHandler(this.lbl_fecha_Nuevaventa_Click);
            // 
            // lbl_servicio_Nuevaventa
            // 
            this.lbl_servicio_Nuevaventa.AutoSize = true;
            this.lbl_servicio_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_servicio_Nuevaventa.Location = new System.Drawing.Point(28, 197);
            this.lbl_servicio_Nuevaventa.Name = "lbl_servicio_Nuevaventa";
            this.lbl_servicio_Nuevaventa.Size = new System.Drawing.Size(68, 23);
            this.lbl_servicio_Nuevaventa.TabIndex = 17;
            this.lbl_servicio_Nuevaventa.Text = "Servicio:";
            // 
            // dgw_servicio_Nuevaventa
            // 
            this.dgw_servicio_Nuevaventa.AllowUserToOrderColumns = true;
            this.dgw_servicio_Nuevaventa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_servicio_Nuevaventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_servicio_Nuevaventa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_servicio_Nuevaventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_servicio_Nuevaventa.Location = new System.Drawing.Point(12, 227);
            this.dgw_servicio_Nuevaventa.Name = "dgw_servicio_Nuevaventa";
            this.dgw_servicio_Nuevaventa.Size = new System.Drawing.Size(445, 129);
            this.dgw_servicio_Nuevaventa.TabIndex = 18;
            // 
            // lbl_Descripcion_Nuevaventa
            // 
            this.lbl_Descripcion_Nuevaventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Descripcion_Nuevaventa.AutoSize = true;
            this.lbl_Descripcion_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Descripcion_Nuevaventa.Location = new System.Drawing.Point(14, 385);
            this.lbl_Descripcion_Nuevaventa.Name = "lbl_Descripcion_Nuevaventa";
            this.lbl_Descripcion_Nuevaventa.Size = new System.Drawing.Size(96, 23);
            this.lbl_Descripcion_Nuevaventa.TabIndex = 19;
            this.lbl_Descripcion_Nuevaventa.Text = "Descripcion:";
            // 
            // txt_Descripcion_Nuevaventa
            // 
            this.txt_Descripcion_Nuevaventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Descripcion_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion_Nuevaventa.Location = new System.Drawing.Point(12, 411);
            this.txt_Descripcion_Nuevaventa.Multiline = true;
            this.txt_Descripcion_Nuevaventa.Name = "txt_Descripcion_Nuevaventa";
            this.txt_Descripcion_Nuevaventa.Size = new System.Drawing.Size(445, 62);
            this.txt_Descripcion_Nuevaventa.TabIndex = 20;
            // 
            // btn_Agregar_Nuevaventa
            // 
            this.btn_Agregar_Nuevaventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Agregar_Nuevaventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_Nuevaventa.Location = new System.Drawing.Point(12, 481);
            this.btn_Agregar_Nuevaventa.Name = "btn_Agregar_Nuevaventa";
            this.btn_Agregar_Nuevaventa.Size = new System.Drawing.Size(173, 34);
            this.btn_Agregar_Nuevaventa.TabIndex = 21;
            this.btn_Agregar_Nuevaventa.Text = "Agregar producto";
            this.btn_Agregar_Nuevaventa.UseVisualStyleBackColor = true;
            this.btn_Agregar_Nuevaventa.Click += new System.EventHandler(this.btn_Agregar_Nuevaventa_Click);
            // 
            // btn_FinalizarVenta_Nuevaventa
            // 
            this.btn_FinalizarVenta_Nuevaventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FinalizarVenta_Nuevaventa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FinalizarVenta_Nuevaventa.Location = new System.Drawing.Point(323, 479);
            this.btn_FinalizarVenta_Nuevaventa.Name = "btn_FinalizarVenta_Nuevaventa";
            this.btn_FinalizarVenta_Nuevaventa.Size = new System.Drawing.Size(134, 36);
            this.btn_FinalizarVenta_Nuevaventa.TabIndex = 22;
            this.btn_FinalizarVenta_Nuevaventa.Text = "Finalizar venta";
            this.btn_FinalizarVenta_Nuevaventa.UseVisualStyleBackColor = true;
            this.btn_FinalizarVenta_Nuevaventa.Click += new System.EventHandler(this.btn_FinalizarVenta_Nuevaventa_Click);
            // 
            // cb_Servicio_nuevaVenta
            // 
            this.cb_Servicio_nuevaVenta.FormattingEnabled = true;
            this.cb_Servicio_nuevaVenta.Location = new System.Drawing.Point(102, 200);
            this.cb_Servicio_nuevaVenta.Name = "cb_Servicio_nuevaVenta";
            this.cb_Servicio_nuevaVenta.Size = new System.Drawing.Size(225, 21);
            this.cb_Servicio_nuevaVenta.TabIndex = 23;
            this.cb_Servicio_nuevaVenta.SelectedIndexChanged += new System.EventHandler(this.cb_Servicio_nuevaVenta_SelectedIndexChanged);
            // 
            // cb_Dia
            // 
            this.cb_Dia.FormattingEnabled = true;
            this.cb_Dia.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            this.cb_Dia.Location = new System.Drawing.Point(102, 116);
            this.cb_Dia.Name = "cb_Dia";
            this.cb_Dia.Size = new System.Drawing.Size(39, 21);
            this.cb_Dia.TabIndex = 24;
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Dia.Location = new System.Drawing.Point(147, 116);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(33, 23);
            this.lbl_Dia.TabIndex = 25;
            this.lbl_Dia.Text = "Dia";
            // 
            // cb_Mes
            // 
            this.cb_Mes.FormattingEnabled = true;
            this.cb_Mes.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cb_Mes.Location = new System.Drawing.Point(186, 116);
            this.cb_Mes.Name = "cb_Mes";
            this.cb_Mes.Size = new System.Drawing.Size(40, 21);
            this.cb_Mes.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label1.Location = new System.Drawing.Point(232, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mes";
            // 
            // cb_Año
            // 
            this.cb_Año.FormattingEnabled = true;
            this.cb_Año.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cb_Año.Location = new System.Drawing.Point(273, 116);
            this.cb_Año.Name = "cb_Año";
            this.cb_Año.Size = new System.Drawing.Size(56, 21);
            this.cb_Año.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label2.Location = new System.Drawing.Point(335, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Año";
            // 
            // lbl_Cedula_NuevaVenta
            // 
            this.lbl_Cedula_NuevaVenta.AutoSize = true;
            this.lbl_Cedula_NuevaVenta.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Cedula_NuevaVenta.Location = new System.Drawing.Point(32, 35);
            this.lbl_Cedula_NuevaVenta.Name = "lbl_Cedula_NuevaVenta";
            this.lbl_Cedula_NuevaVenta.Size = new System.Drawing.Size(64, 23);
            this.lbl_Cedula_NuevaVenta.TabIndex = 26;
            this.lbl_Cedula_NuevaVenta.Text = "Cedula:";
            // 
            // txt_direccion_Nuevaventa
            // 
            this.txt_direccion_Nuevaventa.Location = new System.Drawing.Point(102, 90);
            this.txt_direccion_Nuevaventa.Name = "txt_direccion_Nuevaventa";
            this.txt_direccion_Nuevaventa.Size = new System.Drawing.Size(227, 20);
            this.txt_direccion_Nuevaventa.TabIndex = 28;
            // 
            // lbl_NombreCliente_NuevaVenta
            // 
            this.lbl_NombreCliente_NuevaVenta.AutoSize = true;
            this.lbl_NombreCliente_NuevaVenta.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_NombreCliente_NuevaVenta.Location = new System.Drawing.Point(98, 61);
            this.lbl_NombreCliente_NuevaVenta.Name = "lbl_NombreCliente_NuevaVenta";
            this.lbl_NombreCliente_NuevaVenta.Size = new System.Drawing.Size(75, 23);
            this.lbl_NombreCliente_NuevaVenta.TabIndex = 29;
            this.lbl_NombreCliente_NuevaVenta.Text = "No Existe";
            this.lbl_NombreCliente_NuevaVenta.Click += new System.EventHandler(this.lbl_NombreCliente_NuevaVenta_Click);
            // 
            // txt_ValorManoObra_Nuevaventa
            // 
            this.txt_ValorManoObra_Nuevaventa.Location = new System.Drawing.Point(102, 154);
            this.txt_ValorManoObra_Nuevaventa.Name = "txt_ValorManoObra_Nuevaventa";
            this.txt_ValorManoObra_Nuevaventa.Size = new System.Drawing.Size(139, 20);
            this.txt_ValorManoObra_Nuevaventa.TabIndex = 31;
            this.txt_ValorManoObra_Nuevaventa.TextChanged += new System.EventHandler(this.txt_ValorManoObra_Nuevaventa_TextChanged_1);
            // 
            // lbl_Valor_Nuevaventa
            // 
            this.lbl_Valor_Nuevaventa.AutoSize = true;
            this.lbl_Valor_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Valor_Nuevaventa.Location = new System.Drawing.Point(98, 360);
            this.lbl_Valor_Nuevaventa.Name = "lbl_Valor_Nuevaventa";
            this.lbl_Valor_Nuevaventa.Size = new System.Drawing.Size(42, 23);
            this.lbl_Valor_Nuevaventa.TabIndex = 33;
            this.lbl_Valor_Nuevaventa.Text = "####";
            // 
            // lbl_ValorTotal_Nuevaventa
            // 
            this.lbl_ValorTotal_Nuevaventa.AutoSize = true;
            this.lbl_ValorTotal_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_ValorTotal_Nuevaventa.Location = new System.Drawing.Point(14, 359);
            this.lbl_ValorTotal_Nuevaventa.Name = "lbl_ValorTotal_Nuevaventa";
            this.lbl_ValorTotal_Nuevaventa.Size = new System.Drawing.Size(82, 23);
            this.lbl_ValorTotal_Nuevaventa.TabIndex = 32;
            this.lbl_ValorTotal_Nuevaventa.Text = "Valor total:";
            // 
            // txt_Cedula_NuevaVenta
            // 
            this.txt_Cedula_NuevaVenta.Location = new System.Drawing.Point(102, 38);
            this.txt_Cedula_NuevaVenta.Name = "txt_Cedula_NuevaVenta";
            this.txt_Cedula_NuevaVenta.Size = new System.Drawing.Size(124, 20);
            this.txt_Cedula_NuevaVenta.TabIndex = 34;
            this.txt_Cedula_NuevaVenta.TextChanged += new System.EventHandler(this.txt_Cedula_NuevaVenta_TextChanged);
            // 
            // form_nuevaVenta_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(469, 527);
            this.Controls.Add(this.txt_Cedula_NuevaVenta);
            this.Controls.Add(this.lbl_Valor_Nuevaventa);
            this.Controls.Add(this.lbl_ValorTotal_Nuevaventa);
            this.Controls.Add(this.txt_ValorManoObra_Nuevaventa);
            this.Controls.Add(this.lbl_NombreCliente_NuevaVenta);
            this.Controls.Add(this.txt_direccion_Nuevaventa);
            this.Controls.Add(this.lbl_Cedula_NuevaVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Dia);
            this.Controls.Add(this.cb_Año);
            this.Controls.Add(this.cb_Mes);
            this.Controls.Add(this.cb_Dia);
            this.Controls.Add(this.cb_Servicio_nuevaVenta);
            this.Controls.Add(this.btn_FinalizarVenta_Nuevaventa);
            this.Controls.Add(this.btn_Agregar_Nuevaventa);
            this.Controls.Add(this.txt_Descripcion_Nuevaventa);
            this.Controls.Add(this.lbl_Descripcion_Nuevaventa);
            this.Controls.Add(this.dgw_servicio_Nuevaventa);
            this.Controls.Add(this.lbl_servicio_Nuevaventa);
            this.Controls.Add(this.lbl_fecha_Nuevaventa);
            this.Controls.Add(this.lbl_Manode__Nuevaventa);
            this.Controls.Add(this.lbl_Direccion_Nuevaventa);
            this.Controls.Add(this.lbl_Cliente_Nuevaventa);
            this.Controls.Add(this.lbl_NoVenta_Nuevaventa);
            this.Controls.Add(this.lbl_Categoria_NuevaVenta);
            this.MaximizeBox = false;
            this.Name = "form_nuevaVenta_Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORION-Nueva venta";
            this.Load += new System.EventHandler(this.form_nuevaVenta_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_servicio_Nuevaventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }*/

        #endregion

        private System.Windows.Forms.Label lbl_Categoria_NuevaVenta;
        private System.Windows.Forms.Label lbl_NoVenta_Nuevaventa;
        private System.Windows.Forms.Label lbl_Cliente_Nuevaventa;
        private System.Windows.Forms.Label lbl_Direccion_Nuevaventa;
        private System.Windows.Forms.Label lbl_Manode__Nuevaventa;
        private System.Windows.Forms.Label lbl_fecha_Nuevaventa;
        private System.Windows.Forms.Label lbl_servicio_Nuevaventa;
        private System.Windows.Forms.DataGridView dgw_servicio_Nuevaventa;
        private System.Windows.Forms.Label lbl_Descripcion_Nuevaventa;
        private System.Windows.Forms.TextBox txt_Descripcion_Nuevaventa;
        private System.Windows.Forms.Button btn_Agregar_Nuevaventa;
        private System.Windows.Forms.Button btn_FinalizarVenta_Nuevaventa;
        private System.Windows.Forms.ComboBox cb_Servicio_nuevaVenta;
        private System.Windows.Forms.ComboBox cb_Dia;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.ComboBox cb_Mes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Año;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Cedula_NuevaVenta;
        private System.Windows.Forms.TextBox txt_direccion_Nuevaventa;
        private System.Windows.Forms.Label lbl_NombreCliente_NuevaVenta;
        private System.Windows.Forms.TextBox txt_ValorManoObra_Nuevaventa;
        private System.Windows.Forms.Label lbl_Valor_Nuevaventa;
        private System.Windows.Forms.Label lbl_ValorTotal_Nuevaventa;
        private System.Windows.Forms.TextBox txt_Cedula_NuevaVenta;
    }
}