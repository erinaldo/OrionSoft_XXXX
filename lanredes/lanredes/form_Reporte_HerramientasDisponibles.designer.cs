namespace lanredes
{
    partial class form_Reporte_HerramientasDisponibles
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
            this.dgw_Herramientas.Location = new System.Drawing.Point(3, 3);
            this.dgw_Herramientas.Name = "dgw_Herramientas";
            this.dgw_Herramientas.ReadOnly = true;
            this.dgw_Herramientas.Size = new System.Drawing.Size(795, 445);
            this.dgw_Herramientas.TabIndex = 0;
            // 
            // form_Reporte_HerramientasDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_Herramientas);
            this.Name = "form_Reporte_HerramientasDisponibles";
            this.Text = "form_Reporte_HerramientasDisponibles";
            this.Load += new System.EventHandler(this.form_Reporte_HerramientasDisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Herramientas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Herramientas;
    }
}