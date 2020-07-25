namespace lanredes
{
    partial class form_AgregarProducto
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
            this.cb_categoria_AgregarProducto = new System.Windows.Forms.ComboBox();
            this.btn_agregar_AgregarProducto = new System.Windows.Forms.Button();
            this.lbl_Categoria_AgregarProducto = new System.Windows.Forms.Label();
            this.lbl_producto_AgregarProducto = new System.Windows.Forms.Label();
            this.cb_producto_AgregarProducto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_categoria_AgregarProducto
            // 
            this.cb_categoria_AgregarProducto.FormattingEnabled = true;
            this.cb_categoria_AgregarProducto.Location = new System.Drawing.Point(173, 31);
            this.cb_categoria_AgregarProducto.Name = "cb_categoria_AgregarProducto";
            this.cb_categoria_AgregarProducto.Size = new System.Drawing.Size(254, 21);
            this.cb_categoria_AgregarProducto.TabIndex = 0;
            // 
            // btn_agregar_AgregarProducto
            // 
            this.btn_agregar_AgregarProducto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_AgregarProducto.Location = new System.Drawing.Point(229, 171);
            this.btn_agregar_AgregarProducto.Name = "btn_agregar_AgregarProducto";
            this.btn_agregar_AgregarProducto.Size = new System.Drawing.Size(141, 41);
            this.btn_agregar_AgregarProducto.TabIndex = 1;
            this.btn_agregar_AgregarProducto.Text = "Agregar producto";
            this.btn_agregar_AgregarProducto.UseVisualStyleBackColor = true;
            // 
            // lbl_Categoria_AgregarProducto
            // 
            this.lbl_Categoria_AgregarProducto.AutoSize = true;
            this.lbl_Categoria_AgregarProducto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Categoria_AgregarProducto.Location = new System.Drawing.Point(12, 31);
            this.lbl_Categoria_AgregarProducto.Name = "lbl_Categoria_AgregarProducto";
            this.lbl_Categoria_AgregarProducto.Size = new System.Drawing.Size(89, 25);
            this.lbl_Categoria_AgregarProducto.TabIndex = 2;
            this.lbl_Categoria_AgregarProducto.Text = "Categoria";
            // 
            // lbl_producto_AgregarProducto
            // 
            this.lbl_producto_AgregarProducto.AutoSize = true;
            this.lbl_producto_AgregarProducto.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto_AgregarProducto.Location = new System.Drawing.Point(12, 75);
            this.lbl_producto_AgregarProducto.Name = "lbl_producto_AgregarProducto";
            this.lbl_producto_AgregarProducto.Size = new System.Drawing.Size(83, 25);
            this.lbl_producto_AgregarProducto.TabIndex = 3;
            this.lbl_producto_AgregarProducto.Text = "Producto";
            // 
            // cb_producto_AgregarProducto
            // 
            this.cb_producto_AgregarProducto.FormattingEnabled = true;
            this.cb_producto_AgregarProducto.Location = new System.Drawing.Point(173, 81);
            this.cb_producto_AgregarProducto.Name = "cb_producto_AgregarProducto";
            this.cb_producto_AgregarProducto.Size = new System.Drawing.Size(254, 21);
            this.cb_producto_AgregarProducto.TabIndex = 4;
            // 
            // form_AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 254);
            this.Controls.Add(this.cb_producto_AgregarProducto);
            this.Controls.Add(this.lbl_producto_AgregarProducto);
            this.Controls.Add(this.lbl_Categoria_AgregarProducto);
            this.Controls.Add(this.btn_agregar_AgregarProducto);
            this.Controls.Add(this.cb_categoria_AgregarProducto);
            this.MaximizeBox = false;
            this.Name = "form_AgregarProducto";
            this.Text = "Agregar producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_categoria_AgregarProducto;
        private System.Windows.Forms.Button btn_agregar_AgregarProducto;
        private System.Windows.Forms.Label lbl_Categoria_AgregarProducto;
        private System.Windows.Forms.Label lbl_producto_AgregarProducto;
        private System.Windows.Forms.ComboBox cb_producto_AgregarProducto;
    }
}