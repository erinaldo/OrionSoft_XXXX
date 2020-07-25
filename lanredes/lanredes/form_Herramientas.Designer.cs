namespace lanredes
{
    partial class form_Herramientas
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
            this.dgw_Herramientas = new System.Windows.Forms.DataGridView();
            this.btn_AgregarHerramienta = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Herramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Herramientas
            // 
            this.dgw_Herramientas.AllowUserToAddRows = false;
            this.dgw_Herramientas.AllowUserToDeleteRows = false;
            this.dgw_Herramientas.AllowUserToOrderColumns = true;
            this.dgw_Herramientas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Herramientas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Herramientas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_Herramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Herramientas.Location = new System.Drawing.Point(2, 2);
            this.dgw_Herramientas.Name = "dgw_Herramientas";
            this.dgw_Herramientas.ReadOnly = true;
            this.dgw_Herramientas.Size = new System.Drawing.Size(640, 446);
            this.dgw_Herramientas.TabIndex = 0;
            // 
            // btn_AgregarHerramienta
            // 
            this.btn_AgregarHerramienta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgregarHerramienta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_AgregarHerramienta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AgregarHerramienta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarHerramienta.Location = new System.Drawing.Point(648, 9);
            this.btn_AgregarHerramienta.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AgregarHerramienta.Name = "btn_AgregarHerramienta";
            this.btn_AgregarHerramienta.Size = new System.Drawing.Size(173, 38);
            this.btn_AgregarHerramienta.TabIndex = 3;
            this.btn_AgregarHerramienta.Text = "Agregar";
            this.btn_AgregarHerramienta.UseVisualStyleBackColor = false;
            this.btn_AgregarHerramienta.Click += new System.EventHandler(this.btn_AgregarHerramienta_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(648, 57);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(173, 38);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // form_Herramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_AgregarHerramienta);
            this.Controls.Add(this.dgw_Herramientas);
            this.Name = "form_Herramientas";
            this.Text = "form_Herramientas";
            this.Load += new System.EventHandler(this.form_Herramientas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Herramientas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Herramientas;
        public System.Windows.Forms.Button btn_AgregarHerramienta;
        public System.Windows.Forms.Button btn_editar;
    }
}