namespace lanredes
{
    partial class form_AgregarHerramienta
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Vaciomarca = new System.Windows.Forms.Label();
            this.lbl_Vacioserial = new System.Windows.Forms.Label();
            this.lbl_Vacionombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "MARCA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SERIAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ESTADO:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(110, 13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(41, 20);
            this.lbl_id.TabIndex = 5;
            this.lbl_id.Text = "####";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(114, 34);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(315, 27);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(114, 67);
            this.txt_marca.Multiline = true;
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(315, 27);
            this.txt_marca.TabIndex = 7;
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(114, 100);
            this.txt_serial.Multiline = true;
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(195, 27);
            this.txt_serial.TabIndex = 8;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.BackColor = System.Drawing.Color.Lime;
            this.lbl_estado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(114, 138);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(86, 20);
            this.lbl_estado.TabIndex = 9;
            this.lbl_estado.Text = "DISPONIBLE";
            this.lbl_estado.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Vaciomarca
            // 
            this.lbl_Vaciomarca.AutoSize = true;
            this.lbl_Vaciomarca.ForeColor = System.Drawing.Color.Red;
            this.lbl_Vaciomarca.Location = new System.Drawing.Point(441, 74);
            this.lbl_Vaciomarca.Name = "lbl_Vaciomarca";
            this.lbl_Vaciomarca.Size = new System.Drawing.Size(69, 13);
            this.lbl_Vaciomarca.TabIndex = 12;
            this.lbl_Vaciomarca.Text = "Campo vacio";
            this.lbl_Vaciomarca.Visible = false;
            // 
            // lbl_Vacioserial
            // 
            this.lbl_Vacioserial.AutoSize = true;
            this.lbl_Vacioserial.ForeColor = System.Drawing.Color.Red;
            this.lbl_Vacioserial.Location = new System.Drawing.Point(315, 107);
            this.lbl_Vacioserial.Name = "lbl_Vacioserial";
            this.lbl_Vacioserial.Size = new System.Drawing.Size(69, 13);
            this.lbl_Vacioserial.TabIndex = 13;
            this.lbl_Vacioserial.Text = "Campo vacio";
            this.lbl_Vacioserial.Visible = false;
            // 
            // lbl_Vacionombre
            // 
            this.lbl_Vacionombre.AutoSize = true;
            this.lbl_Vacionombre.ForeColor = System.Drawing.Color.Red;
            this.lbl_Vacionombre.Location = new System.Drawing.Point(441, 37);
            this.lbl_Vacionombre.Name = "lbl_Vacionombre";
            this.lbl_Vacionombre.Size = new System.Drawing.Size(69, 13);
            this.lbl_Vacionombre.TabIndex = 14;
            this.lbl_Vacionombre.Text = "Campo vacio";
            this.lbl_Vacionombre.Visible = false;
            // 
            // form_AgregarHerramienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 270);
            this.Controls.Add(this.lbl_Vacionombre);
            this.Controls.Add(this.lbl_Vacioserial);
            this.Controls.Add(this.lbl_Vaciomarca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.txt_serial);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "form_AgregarHerramienta";
            this.Text = "ORION-AGREGAR HERRAMIENTA";
            this.Load += new System.EventHandler(this.form_AgregarHerramienta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Vaciomarca;
        private System.Windows.Forms.Label lbl_Vacioserial;
        private System.Windows.Forms.Label lbl_Vacionombre;
    }
}