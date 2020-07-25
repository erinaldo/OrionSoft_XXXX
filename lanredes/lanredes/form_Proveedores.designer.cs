namespace lanredes
{
    partial class form_Proveedores
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
            this.dgw_Proveedor_Proveedores = new System.Windows.Forms.DataGridView();
            this.btn_NuevoEmpleado = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Proveedor_Proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Proveedor_Proveedores
            // 
            this.dgw_Proveedor_Proveedores.AllowUserToAddRows = false;
            this.dgw_Proveedor_Proveedores.AllowUserToDeleteRows = false;
            this.dgw_Proveedor_Proveedores.AllowUserToOrderColumns = true;
            this.dgw_Proveedor_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Proveedor_Proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Proveedor_Proveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_Proveedor_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Proveedor_Proveedores.Location = new System.Drawing.Point(1, 1);
            this.dgw_Proveedor_Proveedores.Name = "dgw_Proveedor_Proveedores";
            this.dgw_Proveedor_Proveedores.ReadOnly = true;
            this.dgw_Proveedor_Proveedores.Size = new System.Drawing.Size(640, 446);
            this.dgw_Proveedor_Proveedores.TabIndex = 4;
            // 
            // btn_NuevoEmpleado
            // 
            this.btn_NuevoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NuevoEmpleado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_NuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NuevoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoEmpleado.Location = new System.Drawing.Point(649, 1);
            this.btn_NuevoEmpleado.Name = "btn_NuevoEmpleado";
            this.btn_NuevoEmpleado.Size = new System.Drawing.Size(139, 54);
            this.btn_NuevoEmpleado.TabIndex = 5;
            this.btn_NuevoEmpleado.Text = "Agregar Proveedor";
            this.btn_NuevoEmpleado.UseVisualStyleBackColor = false;
            this.btn_NuevoEmpleado.Click += new System.EventHandler(this.btn_NuevoEmpleado_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(649, 61);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(139, 54);
            this.btn_editar.TabIndex = 6;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // form_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_NuevoEmpleado);
            this.Controls.Add(this.dgw_Proveedor_Proveedores);
            this.Name = "form_Proveedores";
            this.Text = "form_Proveedores";
            this.Load += new System.EventHandler(this.form_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Proveedor_Proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Proveedor_Proveedores;
        private System.Windows.Forms.Button btn_NuevoEmpleado;
        private System.Windows.Forms.Button btn_editar;
    }
}