namespace lanredes
{
    partial class form_ventas
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
            this.dgw_Ventas = new System.Windows.Forms.DataGridView();
            this.btn_Nueva_Ventas = new System.Windows.Forms.Button();
            this.btn_VerVenta_ventas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Ventas
            // 
            this.dgw_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Ventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Ventas.Location = new System.Drawing.Point(3, 2);
            this.dgw_Ventas.Name = "dgw_Ventas";
            this.dgw_Ventas.Size = new System.Drawing.Size(644, 446);
            this.dgw_Ventas.TabIndex = 0;
            this.dgw_Ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Ventas_CellContentClick);
            // 
            // btn_Nueva_Ventas
            // 
            this.btn_Nueva_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nueva_Ventas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Nueva_Ventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nueva_Ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nueva_Ventas.Location = new System.Drawing.Point(653, 12);
            this.btn_Nueva_Ventas.Name = "btn_Nueva_Ventas";
            this.btn_Nueva_Ventas.Size = new System.Drawing.Size(135, 38);
            this.btn_Nueva_Ventas.TabIndex = 1;
            this.btn_Nueva_Ventas.Text = "Nueva Venta";
            this.btn_Nueva_Ventas.UseVisualStyleBackColor = false;
            this.btn_Nueva_Ventas.Click += new System.EventHandler(this.btn_Nueva_Ventas_Click);
            // 
            // btn_VerVenta_ventas
            // 
            this.btn_VerVenta_ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VerVenta_ventas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_VerVenta_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VerVenta_ventas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerVenta_ventas.Location = new System.Drawing.Point(653, 56);
            this.btn_VerVenta_ventas.Name = "btn_VerVenta_ventas";
            this.btn_VerVenta_ventas.Size = new System.Drawing.Size(135, 42);
            this.btn_VerVenta_ventas.TabIndex = 2;
            this.btn_VerVenta_ventas.Text = "Ver venta";
            this.btn_VerVenta_ventas.UseVisualStyleBackColor = false;
            this.btn_VerVenta_ventas.Click += new System.EventHandler(this.btn_VerVenta_ventas_Click);
            // 
            // form_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_VerVenta_ventas);
            this.Controls.Add(this.btn_Nueva_Ventas);
            this.Controls.Add(this.dgw_Ventas);
            this.Name = "form_ventas";
            this.Text = "form_ventas";
            this.Load += new System.EventHandler(this.form_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Ventas;
        private System.Windows.Forms.Button btn_Nueva_Ventas;
        private System.Windows.Forms.Button btn_VerVenta_ventas;
    }
}