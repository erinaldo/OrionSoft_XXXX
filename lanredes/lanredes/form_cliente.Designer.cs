namespace lanredes
{
    partial class form_cliente
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
            this.dgw_inventario_inventario = new System.Windows.Forms.DataGridView();
            this.btn_AgregarUsuario = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_inventario_inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_inventario_inventario
            // 
            this.dgw_inventario_inventario.AllowUserToAddRows = false;
            this.dgw_inventario_inventario.AllowUserToDeleteRows = false;
            this.dgw_inventario_inventario.AllowUserToOrderColumns = true;
            this.dgw_inventario_inventario.AllowUserToResizeColumns = false;
            this.dgw_inventario_inventario.AllowUserToResizeRows = false;
            this.dgw_inventario_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_inventario_inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_inventario_inventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_inventario_inventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgw_inventario_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_inventario_inventario.Location = new System.Drawing.Point(2, 1);
            this.dgw_inventario_inventario.Name = "dgw_inventario_inventario";
            this.dgw_inventario_inventario.ReadOnly = true;
            this.dgw_inventario_inventario.Size = new System.Drawing.Size(640, 446);
            this.dgw_inventario_inventario.TabIndex = 0;
            this.dgw_inventario_inventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_inventario_inventario_CellContentClick);
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgregarUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(648, 9);
            this.btn_AgregarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(173, 38);
            this.btn_AgregarUsuario.TabIndex = 1;
            this.btn_AgregarUsuario.Text = "Agregar";
            this.btn_AgregarUsuario.UseVisualStyleBackColor = false;
            this.btn_AgregarUsuario.Click += new System.EventHandler(this.btn_buscar_inventario_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(648, 56);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(173, 38);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // form_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_AgregarUsuario);
            this.Controls.Add(this.dgw_inventario_inventario);
            this.Name = "form_cliente";
            this.Text = "Orion_Agregar Cliente";
            this.Load += new System.EventHandler(this.form_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_inventario_inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_inventario_inventario;
        private System.Windows.Forms.Button btn_AgregarUsuario;
        private System.Windows.Forms.Button btn_editar;
    }
}