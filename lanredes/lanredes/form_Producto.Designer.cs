namespace lanredes
{
    partial class form_Productos
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
            this.dgw_Productos = new System.Windows.Forms.DataGridView();
            this.btn_BuscarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Productos
            // 
            this.dgw_Productos.AllowUserToAddRows = false;
            this.dgw_Productos.AllowUserToDeleteRows = false;
            this.dgw_Productos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Productos.Location = new System.Drawing.Point(2, 2);
            this.dgw_Productos.Name = "dgw_Productos";
            this.dgw_Productos.ReadOnly = true;
            this.dgw_Productos.Size = new System.Drawing.Size(640, 446);
            this.dgw_Productos.TabIndex = 0;
            this.dgw_Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Productos_CellContentClick);
            // 
            // btn_BuscarProductos
            // 
            this.btn_BuscarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BuscarProductos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_BuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_BuscarProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarProductos.Location = new System.Drawing.Point(648, 9);
            this.btn_BuscarProductos.Margin = new System.Windows.Forms.Padding(0);
            this.btn_BuscarProductos.Name = "btn_BuscarProductos";
            this.btn_BuscarProductos.Size = new System.Drawing.Size(173, 38);
            this.btn_BuscarProductos.TabIndex = 2;
            this.btn_BuscarProductos.Text = "Buscar";
            this.btn_BuscarProductos.UseVisualStyleBackColor = false;
            this.btn_BuscarProductos.Click += new System.EventHandler(this.btn_BuscarProductos_Click);
            // 
            // form_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.btn_BuscarProductos);
            this.Controls.Add(this.dgw_Productos);
            this.Name = "form_Productos";
            this.Text = "Orion-Productos";
            this.Load += new System.EventHandler(this.form_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Productos;
        private System.Windows.Forms.Button btn_BuscarProductos;
    }
}