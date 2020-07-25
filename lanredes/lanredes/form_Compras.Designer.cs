namespace lanredes
{
    partial class form_Compras
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
            this.btn_Nueva_Compra = new System.Windows.Forms.Button();
            this.btn_VerCompra_compras = new System.Windows.Forms.Button();
            this.dgw_Compras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Nueva_Compra
            // 
            this.btn_Nueva_Compra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Nueva_Compra.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Nueva_Compra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Nueva_Compra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nueva_Compra.Location = new System.Drawing.Point(647, 12);
            this.btn_Nueva_Compra.Name = "btn_Nueva_Compra";
            this.btn_Nueva_Compra.Size = new System.Drawing.Size(141, 38);
            this.btn_Nueva_Compra.TabIndex = 2;
            this.btn_Nueva_Compra.Text = "Nueva Compra";
            this.btn_Nueva_Compra.UseVisualStyleBackColor = false;
            this.btn_Nueva_Compra.Click += new System.EventHandler(this.btn_Nueva_Compra_Click);
            // 
            // btn_VerCompra_compras
            // 
            this.btn_VerCompra_compras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_VerCompra_compras.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_VerCompra_compras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_VerCompra_compras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerCompra_compras.Location = new System.Drawing.Point(647, 56);
            this.btn_VerCompra_compras.Name = "btn_VerCompra_compras";
            this.btn_VerCompra_compras.Size = new System.Drawing.Size(141, 42);
            this.btn_VerCompra_compras.TabIndex = 3;
            this.btn_VerCompra_compras.Text = "Ver compra";
            this.btn_VerCompra_compras.UseVisualStyleBackColor = false;
            // 
            // dgw_Compras
            // 
            this.dgw_Compras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Compras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Compras.Location = new System.Drawing.Point(3, 1);
            this.dgw_Compras.Name = "dgw_Compras";
            this.dgw_Compras.Size = new System.Drawing.Size(638, 446);
            this.dgw_Compras.TabIndex = 4;
            // 
            // form_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_Compras);
            this.Controls.Add(this.btn_VerCompra_compras);
            this.Controls.Add(this.btn_Nueva_Compra);
            this.Name = "form_Compras";
            this.Text = "form_Compras";
            this.Load += new System.EventHandler(this.form_Compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Nueva_Compra;
        private System.Windows.Forms.Button btn_VerCompra_compras;
        private System.Windows.Forms.DataGridView dgw_Compras;
    }
}