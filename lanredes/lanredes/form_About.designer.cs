namespace lanredes
{
    partial class form_About
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especificacionesTecnicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoUniversitarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.especificacionesTecnicasToolStripMenuItem,
            this.proyectoUniversitarioToolStripMenuItem,
            this.desarrolladoresToolStripMenuItem,
            this.codigoFuenteToolStripMenuItem,
            this.soporteTecnicoToolStripMenuItem,
            this.ActualizarToolStripMenuItem,
            this.graficosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // especificacionesTecnicasToolStripMenuItem
            // 
            this.especificacionesTecnicasToolStripMenuItem.Name = "especificacionesTecnicasToolStripMenuItem";
            this.especificacionesTecnicasToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.especificacionesTecnicasToolStripMenuItem.Text = "Especificaciones tecnicas ";
            // 
            // proyectoUniversitarioToolStripMenuItem
            // 
            this.proyectoUniversitarioToolStripMenuItem.Name = "proyectoUniversitarioToolStripMenuItem";
            this.proyectoUniversitarioToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.proyectoUniversitarioToolStripMenuItem.Text = "Proyecto universitario";
            // 
            // desarrolladoresToolStripMenuItem
            // 
            this.desarrolladoresToolStripMenuItem.Name = "desarrolladoresToolStripMenuItem";
            this.desarrolladoresToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.desarrolladoresToolStripMenuItem.Text = "Desarrolladores";
            this.desarrolladoresToolStripMenuItem.Click += new System.EventHandler(this.desarrolladoresToolStripMenuItem_Click);
            // 
            // codigoFuenteToolStripMenuItem
            // 
            this.codigoFuenteToolStripMenuItem.Name = "codigoFuenteToolStripMenuItem";
            this.codigoFuenteToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.codigoFuenteToolStripMenuItem.Text = "Codigo fuente";
            // 
            // soporteTecnicoToolStripMenuItem
            // 
            this.soporteTecnicoToolStripMenuItem.Name = "soporteTecnicoToolStripMenuItem";
            this.soporteTecnicoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.soporteTecnicoToolStripMenuItem.Text = "Soporte tecnico";
            // 
            // ActualizarToolStripMenuItem
            // 
            this.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem";
            this.ActualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ActualizarToolStripMenuItem.Text = "Actualizar";
            this.ActualizarToolStripMenuItem.Click += new System.EventHandler(this.ActualizarToolStripMenuItem_Click);
            // 
            // graficosToolStripMenuItem
            // 
            this.graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.graficosToolStripMenuItem.Text = "Graficos";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 24);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(849, 390);
            this.panelContenedor.TabIndex = 1;
            // 
            // form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 414);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_About";
            this.Text = "form_About";
            this.Load += new System.EventHandler(this.form_About_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especificacionesTecnicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectoUniversitarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desarrolladoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ActualizarToolStripMenuItem;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolStripMenuItem graficosToolStripMenuItem;
    }
}