namespace Proyecto_U2
{
    partial class FrmAddOrder
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
            label9 = new Label();
            label7 = new Label();
            txtPais = new TextBox();
            label8 = new Label();
            txtCodigoP = new TextBox();
            label4 = new Label();
            txtEstado = new TextBox();
            label5 = new Label();
            txtCiudad = new TextBox();
            label6 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            txtContactoCargo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            dtpOrderDate = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label11 = new Label();
            cmbIDbarco = new ComboBox();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(120, 245);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 44;
            label9.Text = "ID barco";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 60);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 40;
            label7.Text = "País";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(401, 78);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(197, 23);
            txtPais.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(401, 201);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 38;
            label8.Text = "Código Postal";
            // 
            // txtCodigoP
            // 
            txtCodigoP.Location = new Point(401, 219);
            txtCodigoP.Name = "txtCodigoP";
            txtCodigoP.Size = new Size(197, 23);
            txtCodigoP.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 105);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 36;
            label4.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(401, 123);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(197, 23);
            txtEstado.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 151);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 34;
            label5.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(401, 169);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(197, 23);
            txtCiudad.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 245);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 32;
            label6.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(401, 263);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 23);
            txtDireccion.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 60);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 30;
            label3.Text = "Cliente ID";
            // 
            // txtContactoCargo
            // 
            txtContactoCargo.Location = new Point(123, 79);
            txtContactoCargo.Name = "txtContactoCargo";
            txtContactoCargo.Size = new Size(197, 23);
            txtContactoCargo.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 151);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 28;
            label2.Text = "Fecha de entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 105);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 26;
            label1.Text = "Fecha de la orden";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(319, 313);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 24;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(120, 125);
            dtpOrderDate.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpOrderDate.MinDate = new DateTime(1800, 12, 31, 0, 0, 0, 0);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 23);
            dtpOrderDate.TabIndex = 45;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(120, 169);
            dateTimePicker1.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1800, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 46;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(117, 219);
            dateTimePicker2.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.MinDate = new DateTime(1800, 12, 31, 0, 0, 0, 0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(117, 195);
            label11.Name = "label11";
            label11.Size = new Size(111, 15);
            label11.TabIndex = 47;
            label11.Text = "Fecha de embarque";
            // 
            // cmbIDbarco
            // 
            cmbIDbarco.FormattingEnabled = true;
            cmbIDbarco.Location = new Point(117, 263);
            cmbIDbarco.Name = "cmbIDbarco";
            cmbIDbarco.Size = new Size(121, 23);
            cmbIDbarco.TabIndex = 50;
            // 
            // FrmAddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 397);
            Controls.Add(cmbIDbarco);
            Controls.Add(dateTimePicker2);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(dtpOrderDate);
            Controls.Add(label9);
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
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Name = "FrmAddOrder";
            Text = "Agregar Orden";
            Load += FrmAddOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label7;
        private TextBox txtPais;
        private Label label8;
        private TextBox txtCodigoP;
        private Label label4;
        private TextBox txtEstado;
        private Label label5;
        private TextBox txtCiudad;
        private Label label6;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtContactoCargo;
        private Label label2;
        private Label label1;
        private Button btnAceptar;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label11;
        private ComboBox cmbIDbarco;
    }
}