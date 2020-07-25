namespace lanredes
{
    partial class form_Buscar_inventario
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
            this.lbl_Id_Buscar = new System.Windows.Forms.Label();
            this.txt_id_BuscarInventario = new System.Windows.Forms.TextBox();
            this.lbl_Nombre_buscar = new System.Windows.Forms.Label();
            this.txt_Nombre_BuscarInventario = new System.Windows.Forms.TextBox();
            this.lbl_Categoria_Buscar = new System.Windows.Forms.Label();
            this.cb_Categoria_BuscarInventario = new System.Windows.Forms.ComboBox();
            this.btn_Buscar_Buscar = new System.Windows.Forms.Button();
            this.dgw_BuscarProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_nombre = new System.Windows.Forms.CheckBox();
            this.chb_id = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_BuscarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Id_Buscar
            // 
            this.lbl_Id_Buscar.AutoSize = true;
            this.lbl_Id_Buscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_Buscar.Location = new System.Drawing.Point(13, 13);
            this.lbl_Id_Buscar.Name = "lbl_Id_Buscar";
            this.lbl_Id_Buscar.Size = new System.Drawing.Size(28, 25);
            this.lbl_Id_Buscar.TabIndex = 0;
            this.lbl_Id_Buscar.Text = "ID";
            // 
            // txt_id_BuscarInventario
            // 
            this.txt_id_BuscarInventario.Location = new System.Drawing.Point(108, 12);
            this.txt_id_BuscarInventario.Name = "txt_id_BuscarInventario";
            this.txt_id_BuscarInventario.Size = new System.Drawing.Size(79, 20);
            this.txt_id_BuscarInventario.TabIndex = 1;
            this.txt_id_BuscarInventario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Nombre_buscar
            // 
            this.lbl_Nombre_buscar.AutoSize = true;
            this.lbl_Nombre_buscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre_buscar.Location = new System.Drawing.Point(13, 48);
            this.lbl_Nombre_buscar.Name = "lbl_Nombre_buscar";
            this.lbl_Nombre_buscar.Size = new System.Drawing.Size(74, 25);
            this.lbl_Nombre_buscar.TabIndex = 2;
            this.lbl_Nombre_buscar.Text = "Nombre";
            // 
            // txt_Nombre_BuscarInventario
            // 
            this.txt_Nombre_BuscarInventario.Location = new System.Drawing.Point(108, 54);
            this.txt_Nombre_BuscarInventario.Name = "txt_Nombre_BuscarInventario";
            this.txt_Nombre_BuscarInventario.Size = new System.Drawing.Size(210, 20);
            this.txt_Nombre_BuscarInventario.TabIndex = 3;
            this.txt_Nombre_BuscarInventario.TextChanged += new System.EventHandler(this.txt_Nombre_BuscarInventario_TextChanged);
            // 
            // lbl_Categoria_Buscar
            // 
            this.lbl_Categoria_Buscar.AutoSize = true;
            this.lbl_Categoria_Buscar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria_Buscar.Location = new System.Drawing.Point(13, 91);
            this.lbl_Categoria_Buscar.Name = "lbl_Categoria_Buscar";
            this.lbl_Categoria_Buscar.Size = new System.Drawing.Size(89, 25);
            this.lbl_Categoria_Buscar.TabIndex = 4;
            this.lbl_Categoria_Buscar.Text = "Categoria";
            // 
            // cb_Categoria_BuscarInventario
            // 
            this.cb_Categoria_BuscarInventario.FormattingEnabled = true;
            this.cb_Categoria_BuscarInventario.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3"});
            this.cb_Categoria_BuscarInventario.Location = new System.Drawing.Point(108, 97);
            this.cb_Categoria_BuscarInventario.Name = "cb_Categoria_BuscarInventario";
            this.cb_Categoria_BuscarInventario.Size = new System.Drawing.Size(210, 21);
            this.cb_Categoria_BuscarInventario.TabIndex = 5;
            this.cb_Categoria_BuscarInventario.SelectedIndexChanged += new System.EventHandler(this.cb_Categoria_BuscarInventario_SelectedIndexChanged);
            // 
            // btn_Buscar_Buscar
            // 
            this.btn_Buscar_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar_Buscar.Location = new System.Drawing.Point(108, 152);
            this.btn_Buscar_Buscar.Name = "btn_Buscar_Buscar";
            this.btn_Buscar_Buscar.Size = new System.Drawing.Size(114, 38);
            this.btn_Buscar_Buscar.TabIndex = 6;
            this.btn_Buscar_Buscar.Text = "Buscar";
            this.btn_Buscar_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar_Buscar.Click += new System.EventHandler(this.btn_Buscar_Buscar_Click);
            // 
            // dgw_BuscarProducto
            // 
            this.dgw_BuscarProducto.AllowUserToAddRows = false;
            this.dgw_BuscarProducto.AllowUserToDeleteRows = false;
            this.dgw_BuscarProducto.AllowUserToOrderColumns = true;
            this.dgw_BuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_BuscarProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_BuscarProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_BuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_BuscarProducto.Location = new System.Drawing.Point(3, 221);
            this.dgw_BuscarProducto.Name = "dgw_BuscarProducto";
            this.dgw_BuscarProducto.ReadOnly = true;
            this.dgw_BuscarProducto.Size = new System.Drawing.Size(669, 244);
            this.dgw_BuscarProducto.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar auto";
            // 
            // chb_nombre
            // 
            this.chb_nombre.AutoSize = true;
            this.chb_nombre.Location = new System.Drawing.Point(176, 77);
            this.chb_nombre.Name = "chb_nombre";
            this.chb_nombre.Size = new System.Drawing.Size(15, 14);
            this.chb_nombre.TabIndex = 9;
            this.chb_nombre.UseVisualStyleBackColor = true;
            // 
            // chb_id
            // 
            this.chb_id.AutoSize = true;
            this.chb_id.Location = new System.Drawing.Point(176, 35);
            this.chb_id.Name = "chb_id";
            this.chb_id.Size = new System.Drawing.Size(15, 14);
            this.chb_id.TabIndex = 11;
            this.chb_id.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buscar auto";
            // 
            // form_Buscar_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 467);
            this.Controls.Add(this.chb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chb_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_BuscarProducto);
            this.Controls.Add(this.btn_Buscar_Buscar);
            this.Controls.Add(this.cb_Categoria_BuscarInventario);
            this.Controls.Add(this.lbl_Categoria_Buscar);
            this.Controls.Add(this.txt_Nombre_BuscarInventario);
            this.Controls.Add(this.lbl_Nombre_buscar);
            this.Controls.Add(this.txt_id_BuscarInventario);
            this.Controls.Add(this.lbl_Id_Buscar);
            this.MaximizeBox = false;
            this.Name = "form_Buscar_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar inventario";
            this.Load += new System.EventHandler(this.form_Buscar_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_BuscarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Id_Buscar;
        private System.Windows.Forms.TextBox txt_id_BuscarInventario;
        private System.Windows.Forms.Label lbl_Nombre_buscar;
        private System.Windows.Forms.TextBox txt_Nombre_BuscarInventario;
        private System.Windows.Forms.Label lbl_Categoria_Buscar;
        private System.Windows.Forms.ComboBox cb_Categoria_BuscarInventario;
        private System.Windows.Forms.Button btn_Buscar_Buscar;
        private System.Windows.Forms.DataGridView dgw_BuscarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_nombre;
        private System.Windows.Forms.CheckBox chb_id;
        private System.Windows.Forms.Label label2;
    }
}