namespace lanredes
{
    partial class form_CambioContraseña
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Nuevacontraseña_CambioContraseña = new System.Windows.Forms.TextBox();
            this.txt_RepetirContraseña_CambioContraseña = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ContraseñaCorta_CambioContraseña = new System.Windows.Forms.Label();
            this.lbl_ContraseñaNoCoincide_CambioContraseña = new System.Windows.Forms.Label();
            this.btn_ModificarContraseña_CambioContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir contraseña";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // txt_Nuevacontraseña_CambioContraseña
            // 
            this.txt_Nuevacontraseña_CambioContraseña.Location = new System.Drawing.Point(154, 55);
            this.txt_Nuevacontraseña_CambioContraseña.Multiline = true;
            this.txt_Nuevacontraseña_CambioContraseña.Name = "txt_Nuevacontraseña_CambioContraseña";
            this.txt_Nuevacontraseña_CambioContraseña.PasswordChar = '*';
            this.txt_Nuevacontraseña_CambioContraseña.Size = new System.Drawing.Size(190, 20);
            this.txt_Nuevacontraseña_CambioContraseña.TabIndex = 4;
            this.txt_Nuevacontraseña_CambioContraseña.UseSystemPasswordChar = true;
            // 
            // txt_RepetirContraseña_CambioContraseña
            // 
            this.txt_RepetirContraseña_CambioContraseña.Location = new System.Drawing.Point(154, 99);
            this.txt_RepetirContraseña_CambioContraseña.Multiline = true;
            this.txt_RepetirContraseña_CambioContraseña.Name = "txt_RepetirContraseña_CambioContraseña";
            this.txt_RepetirContraseña_CambioContraseña.PasswordChar = '*';
            this.txt_RepetirContraseña_CambioContraseña.Size = new System.Drawing.Size(190, 20);
            this.txt_RepetirContraseña_CambioContraseña.TabIndex = 5;
            this.txt_RepetirContraseña_CambioContraseña.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(157, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "contraseña incorrecta";
            this.label4.Visible = false;
            // 
            // lbl_ContraseñaCorta_CambioContraseña
            // 
            this.lbl_ContraseñaCorta_CambioContraseña.AutoSize = true;
            this.lbl_ContraseñaCorta_CambioContraseña.ForeColor = System.Drawing.Color.Red;
            this.lbl_ContraseñaCorta_CambioContraseña.Location = new System.Drawing.Point(157, 39);
            this.lbl_ContraseñaCorta_CambioContraseña.Name = "lbl_ContraseñaCorta_CambioContraseña";
            this.lbl_ContraseñaCorta_CambioContraseña.Size = new System.Drawing.Size(141, 13);
            this.lbl_ContraseñaCorta_CambioContraseña.TabIndex = 7;
            this.lbl_ContraseñaCorta_CambioContraseña.Text = "contraseña demasiado corta";
            this.lbl_ContraseñaCorta_CambioContraseña.Visible = false;
            // 
            // lbl_ContraseñaNoCoincide_CambioContraseña
            // 
            this.lbl_ContraseñaNoCoincide_CambioContraseña.AutoSize = true;
            this.lbl_ContraseñaNoCoincide_CambioContraseña.ForeColor = System.Drawing.Color.Red;
            this.lbl_ContraseñaNoCoincide_CambioContraseña.Location = new System.Drawing.Point(157, 83);
            this.lbl_ContraseñaNoCoincide_CambioContraseña.Name = "lbl_ContraseñaNoCoincide_CambioContraseña";
            this.lbl_ContraseñaNoCoincide_CambioContraseña.Size = new System.Drawing.Size(149, 13);
            this.lbl_ContraseñaNoCoincide_CambioContraseña.TabIndex = 8;
            this.lbl_ContraseñaNoCoincide_CambioContraseña.Text = "Las contraseñas no coinciden";
            this.lbl_ContraseñaNoCoincide_CambioContraseña.Visible = false;
            // 
            // btn_ModificarContraseña_CambioContraseña
            // 
            this.btn_ModificarContraseña_CambioContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarContraseña_CambioContraseña.Location = new System.Drawing.Point(169, 143);
            this.btn_ModificarContraseña_CambioContraseña.Name = "btn_ModificarContraseña_CambioContraseña";
            this.btn_ModificarContraseña_CambioContraseña.Size = new System.Drawing.Size(113, 33);
            this.btn_ModificarContraseña_CambioContraseña.TabIndex = 9;
            this.btn_ModificarContraseña_CambioContraseña.Text = "Modificar";
            this.btn_ModificarContraseña_CambioContraseña.UseVisualStyleBackColor = true;
            this.btn_ModificarContraseña_CambioContraseña.Click += new System.EventHandler(this.button1_Click);
            // 
            // form_CambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 234);
            this.Controls.Add(this.btn_ModificarContraseña_CambioContraseña);
            this.Controls.Add(this.lbl_ContraseñaNoCoincide_CambioContraseña);
            this.Controls.Add(this.lbl_ContraseñaCorta_CambioContraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_RepetirContraseña_CambioContraseña);
            this.Controls.Add(this.txt_Nuevacontraseña_CambioContraseña);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "form_CambioContraseña";
            this.Text = "form_CambioContraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_Nuevacontraseña_CambioContraseña;
        private System.Windows.Forms.TextBox txt_RepetirContraseña_CambioContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ContraseñaCorta_CambioContraseña;
        private System.Windows.Forms.Label lbl_ContraseñaNoCoincide_CambioContraseña;
        private System.Windows.Forms.Button btn_ModificarContraseña_CambioContraseña;
    }
}