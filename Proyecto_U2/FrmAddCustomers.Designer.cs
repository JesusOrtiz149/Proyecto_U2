namespace Proyecto_U2
{
    partial class FrmAddCustomers
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
            label1 = new Label();
            txtNombreCompany = new TextBox();
            btnAceptar = new Button();
            label2 = new Label();
            txtContactoNombre = new TextBox();
            label3 = new Label();
            txtContactoCargo = new TextBox();
            label4 = new Label();
            txtEstado = new TextBox();
            label5 = new Label();
            txtCiudad = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            label7 = new Label();
            txtPais = new TextBox();
            label8 = new Label();
            txtCodigoP = new TextBox();
            label9 = new Label();
            txtFax = new TextBox();
            label10 = new Label();
            txtTel = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre de la compañía";
            // 
            // txtNombreCompany
            // 
            txtNombreCompany.Location = new Point(15, 35);
            txtNombreCompany.Name = "txtNombreCompany";
            txtNombreCompany.Size = new Size(197, 23);
            txtNombreCompany.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(214, 270);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 62);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre de contacto";
            // 
            // txtContactoNombre
            // 
            txtContactoNombre.Location = new Point(15, 80);
            txtContactoNombre.Name = "txtContactoNombre";
            txtContactoNombre.Size = new Size(197, 23);
            txtContactoNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 108);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 9;
            label3.Text = "Cargo del contacto";
            // 
            // txtContactoCargo
            // 
            txtContactoCargo.Location = new Point(15, 126);
            txtContactoCargo.Name = "txtContactoCargo";
            txtContactoCargo.Size = new Size(197, 23);
            txtContactoCargo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 62);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 15;
            label4.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(296, 80);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(197, 23);
            txtEstado.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 108);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 13;
            label5.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(296, 126);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(197, 23);
            txtCiudad.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 202);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 11;
            label6.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(296, 220);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 23);
            txtDireccion.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 17);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 19;
            label7.Text = "País";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(296, 35);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(197, 23);
            txtPais.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(296, 158);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 17;
            label8.Text = "Código Postal";
            // 
            // txtCodigoP
            // 
            txtCodigoP.Location = new Point(296, 176);
            txtCodigoP.Name = "txtCodigoP";
            txtCodigoP.Size = new Size(197, 23);
            txtCodigoP.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 202);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 23;
            label9.Text = "Fax";
            // 
            // txtFax
            // 
            txtFax.Location = new Point(15, 220);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(197, 23);
            txtFax.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 158);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 21;
            label10.Text = "Teléfono";
            // 
            // txtTel
            // 
            txtTel.Location = new Point(15, 176);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(197, 23);
            txtTel.TabIndex = 4;
            // 
            // FrmAddCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 309);
            Controls.Add(label9);
            Controls.Add(txtFax);
            Controls.Add(label10);
            Controls.Add(txtTel);
            Controls.Add(label7);
            Controls.Add(txtPais);
            Controls.Add(label8);
            Controls.Add(txtCodigoP);
            Controls.Add(label4);
            Controls.Add(txtEstado);
            Controls.Add(label5);
            Controls.Add(txtCiudad);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtContactoCargo);
            Controls.Add(label2);
            Controls.Add(txtContactoNombre);
            Controls.Add(label1);
            Controls.Add(txtNombreCompany);
            Controls.Add(btnAceptar);
            Name = "FrmAddCustomers";
            Text = "Agregar Cliente";
            Load += FrmCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCompany;
        private Button btnAceptar;
        private Label label2;
        private TextBox txtContactoNombre;
        private Label label3;
        private TextBox txtContactoCargo;
        private Label label4;
        private TextBox txtEstado;
        private Label label5;
        private TextBox txtCiudad;
        private Label label6;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtPais;
        private Label label8;
        private TextBox txtCodigoP;
        private Label label9;
        private TextBox txtFax;
        private Label label10;
        private TextBox txtTel;
    }
}