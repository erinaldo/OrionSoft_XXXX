namespace lanredes
{
    partial class form_Empleados
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
            this.btn_NuevoEmpleado = new System.Windows.Forms.Button();
            this.dgw_Empleado_Empleados = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Empleado_Empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NuevoEmpleado
            // 
            this.btn_NuevoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NuevoEmpleado.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_NuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_NuevoEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoEmpleado.Location = new System.Drawing.Point(649, 2);
            this.btn_NuevoEmpleado.Name = "btn_NuevoEmpleado";
            this.btn_NuevoEmpleado.Size = new System.Drawing.Size(139, 54);
            this.btn_NuevoEmpleado.TabIndex = 2;
            this.btn_NuevoEmpleado.Text = "Agregar Empleado";
            this.btn_NuevoEmpleado.UseVisualStyleBackColor = false;
            this.btn_NuevoEmpleado.Click += new System.EventHandler(this.btn_NuevoEmpleado_Click);
            // 
            // dgw_Empleado_Empleados
            // 
            this.dgw_Empleado_Empleados.AllowUserToAddRows = false;
            this.dgw_Empleado_Empleados.AllowUserToDeleteRows = false;
            this.dgw_Empleado_Empleados.AllowUserToOrderColumns = true;
            this.dgw_Empleado_Empleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Empleado_Empleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Empleado_Empleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgw_Empleado_Empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Empleado_Empleados.Location = new System.Drawing.Point(3, 2);
            this.dgw_Empleado_Empleados.Name = "dgw_Empleado_Empleados";
            this.dgw_Empleado_Empleados.ReadOnly = true;
            this.dgw_Empleado_Empleados.Size = new System.Drawing.Size(640, 446);
            this.dgw_Empleado_Empleados.TabIndex = 3;
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(649, 62);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(139, 54);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // form_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgw_Empleado_Empleados);
            this.Controls.Add(this.btn_NuevoEmpleado);
            this.Name = "form_Empleados";
            this.Text = "form_Empleados";
            this.Load += new System.EventHandler(this.form_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Empleado_Empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_NuevoEmpleado;
        private System.Windows.Forms.DataGridView dgw_Empleado_Empleados;
        private System.Windows.Forms.Button btn_editar;
    }
}