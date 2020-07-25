namespace lanredes
{
    partial class form_NuevaCompra_Compras
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
            this.lbl_Nro_NuevaCompra = new System.Windows.Forms.Label();
            this.lbl_Proveedor_NuevaCompra = new System.Windows.Forms.Label();
            this.lbl_Categoria_NuevaCompra = new System.Windows.Forms.Label();
            this.lbl_Unidad_NuevaCompra = new System.Windows.Forms.Label();
            this.lbl_Cantidad_NuevaCompra = new System.Windows.Forms.Label();
            this.lbl_ValorUnidad_NuevaCompra = new System.Windows.Forms.Label();
            this.dgw_Productos_NuevaCompra = new System.Windows.Forms.DataGridView();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.cb_Categoria_NuevaCompra = new System.Windows.Forms.ComboBox();
            this.lbl_Unidad = new System.Windows.Forms.Label();
            this.txt_Cantidad_NuevaCompra = new System.Windows.Forms.TextBox();
            this.txt_ValorUnidad_NuevaCompra = new System.Windows.Forms.TextBox();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.lbl_ValorTotal_NuevaCompra = new System.Windows.Forms.Label();
            this.brn_AgregarProducto_NuevaCompra = new System.Windows.Forms.Button();
            this.btn_FinalizarCompra_NuevaCompra = new System.Windows.Forms.Button();
            this.lbl_Producto_NuevaCompra = new System.Windows.Forms.Label();
            this.cb_Producto_NuevaCompra = new System.Windows.Forms.ComboBox();
            this.cb_Proveedor_NuevaCompra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nombre_NuevaCompra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.cb_Año = new System.Windows.Forms.ComboBox();
            this.cb_Mes = new System.Windows.Forms.ComboBox();
            this.cb_Dia = new System.Windows.Forms.ComboBox();
            this.lbl_fecha_Nuevaventa = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Productos_NuevaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Nro_NuevaCompra
            // 
            this.lbl_Nro_NuevaCompra.AutoSize = true;
            this.lbl_Nro_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Nro_NuevaCompra.Location = new System.Drawing.Point(33, 9);
            this.lbl_Nro_NuevaCompra.Name = "lbl_Nro_NuevaCompra";
            this.lbl_Nro_NuevaCompra.Size = new System.Drawing.Size(93, 23);
            this.lbl_Nro_NuevaCompra.TabIndex = 6;
            this.lbl_Nro_NuevaCompra.Text = "N° Compra:";
            // 
            // lbl_Proveedor_NuevaCompra
            // 
            this.lbl_Proveedor_NuevaCompra.AutoSize = true;
            this.lbl_Proveedor_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Proveedor_NuevaCompra.Location = new System.Drawing.Point(40, 69);
            this.lbl_Proveedor_NuevaCompra.Name = "lbl_Proveedor_NuevaCompra";
            this.lbl_Proveedor_NuevaCompra.Size = new System.Drawing.Size(86, 23);
            this.lbl_Proveedor_NuevaCompra.TabIndex = 7;
            this.lbl_Proveedor_NuevaCompra.Text = "Proveedor:";
            // 
            // lbl_Categoria_NuevaCompra
            // 
            this.lbl_Categoria_NuevaCompra.AutoSize = true;
            this.lbl_Categoria_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Categoria_NuevaCompra.Location = new System.Drawing.Point(45, 128);
            this.lbl_Categoria_NuevaCompra.Name = "lbl_Categoria_NuevaCompra";
            this.lbl_Categoria_NuevaCompra.Size = new System.Drawing.Size(81, 23);
            this.lbl_Categoria_NuevaCompra.TabIndex = 8;
            this.lbl_Categoria_NuevaCompra.Text = "Categoria:";
            // 
            // lbl_Unidad_NuevaCompra
            // 
            this.lbl_Unidad_NuevaCompra.AutoSize = true;
            this.lbl_Unidad_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Unidad_NuevaCompra.Location = new System.Drawing.Point(62, 184);
            this.lbl_Unidad_NuevaCompra.Name = "lbl_Unidad_NuevaCompra";
            this.lbl_Unidad_NuevaCompra.Size = new System.Drawing.Size(64, 23);
            this.lbl_Unidad_NuevaCompra.TabIndex = 9;
            this.lbl_Unidad_NuevaCompra.Text = "Unidad:";
            this.lbl_Unidad_NuevaCompra.Click += new System.EventHandler(this.lbl_Unidad_NuevaCompra_Click);
            // 
            // lbl_Cantidad_NuevaCompra
            // 
            this.lbl_Cantidad_NuevaCompra.AutoSize = true;
            this.lbl_Cantidad_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Cantidad_NuevaCompra.Location = new System.Drawing.Point(50, 212);
            this.lbl_Cantidad_NuevaCompra.Name = "lbl_Cantidad_NuevaCompra";
            this.lbl_Cantidad_NuevaCompra.Size = new System.Drawing.Size(76, 23);
            this.lbl_Cantidad_NuevaCompra.TabIndex = 10;
            this.lbl_Cantidad_NuevaCompra.Text = "Cantidad:";
            // 
            // lbl_ValorUnidad_NuevaCompra
            // 
            this.lbl_ValorUnidad_NuevaCompra.AutoSize = true;
            this.lbl_ValorUnidad_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_ValorUnidad_NuevaCompra.Location = new System.Drawing.Point(21, 241);
            this.lbl_ValorUnidad_NuevaCompra.Name = "lbl_ValorUnidad_NuevaCompra";
            this.lbl_ValorUnidad_NuevaCompra.Size = new System.Drawing.Size(105, 23);
            this.lbl_ValorUnidad_NuevaCompra.TabIndex = 11;
            this.lbl_ValorUnidad_NuevaCompra.Text = "Valor Unidad:";
            // 
            // dgw_Productos_NuevaCompra
            // 
            this.dgw_Productos_NuevaCompra.AllowUserToOrderColumns = true;
            this.dgw_Productos_NuevaCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Productos_NuevaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Productos_NuevaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.ValorProducto});
            this.dgw_Productos_NuevaCompra.Location = new System.Drawing.Point(12, 308);
            this.dgw_Productos_NuevaCompra.Name = "dgw_Productos_NuevaCompra";
            this.dgw_Productos_NuevaCompra.Size = new System.Drawing.Size(521, 114);
            this.dgw_Productos_NuevaCompra.TabIndex = 24;
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Numero.Location = new System.Drawing.Point(132, 9);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(42, 23);
            this.lbl_Numero.TabIndex = 26;
            this.lbl_Numero.Text = "####";
            // 
            // cb_Categoria_NuevaCompra
            // 
            this.cb_Categoria_NuevaCompra.FormattingEnabled = true;
            this.cb_Categoria_NuevaCompra.Location = new System.Drawing.Point(132, 130);
            this.cb_Categoria_NuevaCompra.Name = "cb_Categoria_NuevaCompra";
            this.cb_Categoria_NuevaCompra.Size = new System.Drawing.Size(129, 21);
            this.cb_Categoria_NuevaCompra.TabIndex = 28;
            this.cb_Categoria_NuevaCompra.SelectedIndexChanged += new System.EventHandler(this.cb_Categoria_NuevaCompra_SelectedIndexChanged);
            // 
            // lbl_Unidad
            // 
            this.lbl_Unidad.AutoSize = true;
            this.lbl_Unidad.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Unidad.Location = new System.Drawing.Point(132, 184);
            this.lbl_Unidad.Name = "lbl_Unidad";
            this.lbl_Unidad.Size = new System.Drawing.Size(30, 23);
            this.lbl_Unidad.TabIndex = 29;
            this.lbl_Unidad.Text = "     ";
            // 
            // txt_Cantidad_NuevaCompra
            // 
            this.txt_Cantidad_NuevaCompra.Location = new System.Drawing.Point(132, 215);
            this.txt_Cantidad_NuevaCompra.Name = "txt_Cantidad_NuevaCompra";
            this.txt_Cantidad_NuevaCompra.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad_NuevaCompra.TabIndex = 30;
            // 
            // txt_ValorUnidad_NuevaCompra
            // 
            this.txt_ValorUnidad_NuevaCompra.Location = new System.Drawing.Point(132, 244);
            this.txt_ValorUnidad_NuevaCompra.Name = "txt_ValorUnidad_NuevaCompra";
            this.txt_ValorUnidad_NuevaCompra.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorUnidad_NuevaCompra.TabIndex = 31;
            this.txt_ValorUnidad_NuevaCompra.TextChanged += new System.EventHandler(this.txt_ValorUnidad_NuevaCompra_TextChanged);
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.AutoSize = true;
            this.lbl_ValorTotal.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_ValorTotal.Location = new System.Drawing.Point(128, 427);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(19, 23);
            this.lbl_ValorTotal.TabIndex = 38;
            this.lbl_ValorTotal.Text = "0";
            this.lbl_ValorTotal.Click += new System.EventHandler(this.lbl_ValorTotal_Click);
            // 
            // lbl_ValorTotal_NuevaCompra
            // 
            this.lbl_ValorTotal_NuevaCompra.AutoSize = true;
            this.lbl_ValorTotal_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_ValorTotal_NuevaCompra.Location = new System.Drawing.Point(26, 425);
            this.lbl_ValorTotal_NuevaCompra.Name = "lbl_ValorTotal_NuevaCompra";
            this.lbl_ValorTotal_NuevaCompra.Size = new System.Drawing.Size(96, 23);
            this.lbl_ValorTotal_NuevaCompra.TabIndex = 37;
            this.lbl_ValorTotal_NuevaCompra.Text = "Valor Total:";
            // 
            // brn_AgregarProducto_NuevaCompra
            // 
            this.brn_AgregarProducto_NuevaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brn_AgregarProducto_NuevaCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_AgregarProducto_NuevaCompra.Location = new System.Drawing.Point(12, 266);
            this.brn_AgregarProducto_NuevaCompra.Name = "brn_AgregarProducto_NuevaCompra";
            this.brn_AgregarProducto_NuevaCompra.Size = new System.Drawing.Size(238, 36);
            this.brn_AgregarProducto_NuevaCompra.TabIndex = 36;
            this.brn_AgregarProducto_NuevaCompra.Text = "Agregar Producto";
            this.brn_AgregarProducto_NuevaCompra.UseVisualStyleBackColor = true;
            this.brn_AgregarProducto_NuevaCompra.Click += new System.EventHandler(this.brn_AgregarProducto_NuevaCompra_Click);
            // 
            // btn_FinalizarCompra_NuevaCompra
            // 
            this.btn_FinalizarCompra_NuevaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FinalizarCompra_NuevaCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FinalizarCompra_NuevaCompra.Location = new System.Drawing.Point(309, 460);
            this.btn_FinalizarCompra_NuevaCompra.Name = "btn_FinalizarCompra_NuevaCompra";
            this.btn_FinalizarCompra_NuevaCompra.Size = new System.Drawing.Size(224, 36);
            this.btn_FinalizarCompra_NuevaCompra.TabIndex = 35;
            this.btn_FinalizarCompra_NuevaCompra.Text = "Finalizar Compra";
            this.btn_FinalizarCompra_NuevaCompra.UseVisualStyleBackColor = true;
            this.btn_FinalizarCompra_NuevaCompra.Click += new System.EventHandler(this.btn_FinalizarCompra_NuevaCompra_Click);
            // 
            // lbl_Producto_NuevaCompra
            // 
            this.lbl_Producto_NuevaCompra.AutoSize = true;
            this.lbl_Producto_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Producto_NuevaCompra.Location = new System.Drawing.Point(50, 156);
            this.lbl_Producto_NuevaCompra.Name = "lbl_Producto_NuevaCompra";
            this.lbl_Producto_NuevaCompra.Size = new System.Drawing.Size(76, 23);
            this.lbl_Producto_NuevaCompra.TabIndex = 39;
            this.lbl_Producto_NuevaCompra.Text = "Producto:";
            // 
            // cb_Producto_NuevaCompra
            // 
            this.cb_Producto_NuevaCompra.FormattingEnabled = true;
            this.cb_Producto_NuevaCompra.Location = new System.Drawing.Point(132, 158);
            this.cb_Producto_NuevaCompra.Name = "cb_Producto_NuevaCompra";
            this.cb_Producto_NuevaCompra.Size = new System.Drawing.Size(129, 21);
            this.cb_Producto_NuevaCompra.TabIndex = 40;
            this.cb_Producto_NuevaCompra.SelectedIndexChanged += new System.EventHandler(this.cb_Producto_NuevaCompra_SelectedIndexChanged);
            // 
            // cb_Proveedor_NuevaCompra
            // 
            this.cb_Proveedor_NuevaCompra.FormattingEnabled = true;
            this.cb_Proveedor_NuevaCompra.Items.AddRange(new object[] {
            "Elija una opcion"});
            this.cb_Proveedor_NuevaCompra.Location = new System.Drawing.Point(132, 71);
            this.cb_Proveedor_NuevaCompra.Name = "cb_Proveedor_NuevaCompra";
            this.cb_Proveedor_NuevaCompra.Size = new System.Drawing.Size(138, 21);
            this.cb_Proveedor_NuevaCompra.TabIndex = 27;
            this.cb_Proveedor_NuevaCompra.SelectedIndexChanged += new System.EventHandler(this.cb_Proveedor_NuevaCompra_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label1.Location = new System.Drawing.Point(56, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nombre:";
            // 
            // lbl_Nombre_NuevaCompra
            // 
            this.lbl_Nombre_NuevaCompra.AutoSize = true;
            this.lbl_Nombre_NuevaCompra.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Nombre_NuevaCompra.Location = new System.Drawing.Point(132, 100);
            this.lbl_Nombre_NuevaCompra.Name = "lbl_Nombre_NuevaCompra";
            this.lbl_Nombre_NuevaCompra.Size = new System.Drawing.Size(30, 23);
            this.lbl_Nombre_NuevaCompra.TabIndex = 42;
            this.lbl_Nombre_NuevaCompra.Text = "     ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label2.Location = new System.Drawing.Point(366, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 47;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.label3.Location = new System.Drawing.Point(263, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Mes";
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_Dia.Location = new System.Drawing.Point(178, 43);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(33, 23);
            this.lbl_Dia.TabIndex = 49;
            this.lbl_Dia.Text = "Dia";
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
            this.cb_Año.Location = new System.Drawing.Point(304, 43);
            this.cb_Año.Name = "cb_Año";
            this.cb_Año.Size = new System.Drawing.Size(56, 21);
            this.cb_Año.TabIndex = 44;
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
            this.cb_Mes.Location = new System.Drawing.Point(217, 43);
            this.cb_Mes.Name = "cb_Mes";
            this.cb_Mes.Size = new System.Drawing.Size(40, 21);
            this.cb_Mes.TabIndex = 45;
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
            this.cb_Dia.Location = new System.Drawing.Point(133, 43);
            this.cb_Dia.Name = "cb_Dia";
            this.cb_Dia.Size = new System.Drawing.Size(39, 21);
            this.cb_Dia.TabIndex = 46;
            // 
            // lbl_fecha_Nuevaventa
            // 
            this.lbl_fecha_Nuevaventa.AutoSize = true;
            this.lbl_fecha_Nuevaventa.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.lbl_fecha_Nuevaventa.Location = new System.Drawing.Point(68, 40);
            this.lbl_fecha_Nuevaventa.Name = "lbl_fecha_Nuevaventa";
            this.lbl_fecha_Nuevaventa.Size = new System.Drawing.Size(59, 23);
            this.lbl_fecha_Nuevaventa.TabIndex = 43;
            this.lbl_fecha_Nuevaventa.Text = "Fecha:";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // ValorProducto
            // 
            this.ValorProducto.HeaderText = "Valor Producto";
            this.ValorProducto.Name = "ValorProducto";
            // 
            // form_NuevaCompra_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 508);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Dia);
            this.Controls.Add(this.cb_Año);
            this.Controls.Add(this.cb_Mes);
            this.Controls.Add(this.cb_Dia);
            this.Controls.Add(this.lbl_fecha_Nuevaventa);
            this.Controls.Add(this.lbl_Nombre_NuevaCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Producto_NuevaCompra);
            this.Controls.Add(this.lbl_Producto_NuevaCompra);
            this.Controls.Add(this.lbl_ValorTotal);
            this.Controls.Add(this.lbl_ValorTotal_NuevaCompra);
            this.Controls.Add(this.brn_AgregarProducto_NuevaCompra);
            this.Controls.Add(this.btn_FinalizarCompra_NuevaCompra);
            this.Controls.Add(this.txt_ValorUnidad_NuevaCompra);
            this.Controls.Add(this.txt_Cantidad_NuevaCompra);
            this.Controls.Add(this.lbl_Unidad);
            this.Controls.Add(this.cb_Categoria_NuevaCompra);
            this.Controls.Add(this.cb_Proveedor_NuevaCompra);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.dgw_Productos_NuevaCompra);
            this.Controls.Add(this.lbl_ValorUnidad_NuevaCompra);
            this.Controls.Add(this.lbl_Cantidad_NuevaCompra);
            this.Controls.Add(this.lbl_Unidad_NuevaCompra);
            this.Controls.Add(this.lbl_Categoria_NuevaCompra);
            this.Controls.Add(this.lbl_Proveedor_NuevaCompra);
            this.Controls.Add(this.lbl_Nro_NuevaCompra);
            this.Name = "form_NuevaCompra_Compras";
            this.Text = "form_NuevaCompra_Compras";
            this.Load += new System.EventHandler(this.form_NuevaCompra_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Productos_NuevaCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nro_NuevaCompra;
        private System.Windows.Forms.Label lbl_Proveedor_NuevaCompra;
        private System.Windows.Forms.Label lbl_Categoria_NuevaCompra;
        private System.Windows.Forms.Label lbl_Unidad_NuevaCompra;
        private System.Windows.Forms.Label lbl_Cantidad_NuevaCompra;
        private System.Windows.Forms.Label lbl_ValorUnidad_NuevaCompra;
        private System.Windows.Forms.DataGridView dgw_Productos_NuevaCompra;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.ComboBox cb_Categoria_NuevaCompra;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.TextBox txt_Cantidad_NuevaCompra;
        private System.Windows.Forms.TextBox txt_ValorUnidad_NuevaCompra;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.Label lbl_ValorTotal_NuevaCompra;
        private System.Windows.Forms.Button brn_AgregarProducto_NuevaCompra;
        private System.Windows.Forms.Button btn_FinalizarCompra_NuevaCompra;
        private System.Windows.Forms.Label lbl_Producto_NuevaCompra;
        private System.Windows.Forms.ComboBox cb_Producto_NuevaCompra;
        private System.Windows.Forms.ComboBox cb_Proveedor_NuevaCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nombre_NuevaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.ComboBox cb_Año;
        private System.Windows.Forms.ComboBox cb_Mes;
        private System.Windows.Forms.ComboBox cb_Dia;
        private System.Windows.Forms.Label lbl_fecha_Nuevaventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProducto;
    }
}