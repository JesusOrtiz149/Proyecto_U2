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
            label8 = new Label();
            txtEstado = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label6 = new Label();
            txtPais = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAceptar = new Button();
            dtpOrderDate = new DateTimePicker();
            dtpFechaEntrega = new DateTimePicker();
            dtpFechaEmbarque = new DateTimePicker();
            label11 = new Label();
            cmbIDbarco = new ComboBox();
            mtbFlete = new MaskedTextBox();
            groupBox1 = new GroupBox();
            txtCodigoP = new TextBox();
            label12 = new Label();
            txtCiudad = new TextBox();
            label10 = new Label();
            btnCancelar = new Button();
            label13 = new Label();
            txtIDCliente = new TextBox();
            cmbEmpleado = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(9, 19);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 44;
            label9.Text = "ID barco";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 363);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 40;
            label7.Text = "Costo del Flete";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 165);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 38;
            label8.Text = "Estado";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(6, 183);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(197, 23);
            txtEstado.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 36;
            label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(6, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 23);
            txtNombre.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 264);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 34;
            label5.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(6, 282);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(197, 23);
            txtDireccion.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 112);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 32;
            label6.Text = "País";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(6, 130);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(197, 23);
            txtPais.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(332, 31);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 30;
            label3.Text = "Cliente ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 483);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 28;
            label2.Text = "Fecha de entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 122);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 26;
            label1.Text = "Fecha de la orden";
            label1.Visible = false;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(175, 558);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 24;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(332, 142);
            dtpOrderDate.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpOrderDate.MinDate = new DateTime(1800, 12, 31, 0, 0, 0, 0);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(200, 23);
            dtpOrderDate.TabIndex = 45;
            dtpOrderDate.Visible = false;
            // 
            // dtpFechaEntrega
            // 
            dtpFechaEntrega.Location = new Point(9, 501);
            dtpFechaEntrega.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpFechaEntrega.MinDate = new DateTime(1800, 12, 31, 0, 0, 0, 0);
            dtpFechaEntrega.Name = "dtpFechaEntrega";
            dtpFechaEntrega.Size = new Size(200, 23);
            dtpFechaEntrega.TabIndex = 46;
            // 
            // dtpFechaEmbarque
            // 
            dtpFechaEmbarque.Location = new Point(9, 447);
            dtpFechaEmbarque.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dtpFechaEmbarque.MinDate = new DateTime(1800, 12, 31, 0, 0, 0, 0);
            dtpFechaEmbarque.Name = "dtpFechaEmbarque";
            dtpFechaEmbarque.Size = new Size(200, 23);
            dtpFechaEmbarque.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 423);
            label11.Name = "label11";
            label11.Size = new Size(111, 15);
            label11.TabIndex = 47;
            label11.Text = "Fecha de embarque";
            // 
            // cmbIDbarco
            // 
            cmbIDbarco.FormattingEnabled = true;
            cmbIDbarco.Location = new Point(6, 37);
            cmbIDbarco.Name = "cmbIDbarco";
            cmbIDbarco.Size = new Size(121, 23);
            cmbIDbarco.TabIndex = 50;
            // 
            // mtbFlete
            // 
            mtbFlete.Location = new Point(9, 382);
            mtbFlete.Mask = "000.00";
            mtbFlete.Name = "mtbFlete";
            mtbFlete.Size = new Size(100, 23);
            mtbFlete.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCodigoP);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtCiudad);
            groupBox1.Controls.Add(dtpFechaEmbarque);
            groupBox1.Controls.Add(dtpFechaEntrega);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(mtbFlete);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbIDbarco);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPais);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 540);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del barco";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtCodigoP
            // 
            txtCodigoP.Location = new Point(6, 337);
            txtCodigoP.Name = "txtCodigoP";
            txtCodigoP.Size = new Size(197, 23);
            txtCodigoP.TabIndex = 55;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 314);
            label12.Name = "label12";
            label12.Size = new Size(81, 15);
            label12.TabIndex = 54;
            label12.Text = "Código Postal";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(6, 234);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(197, 23);
            txtCiudad.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 216);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 52;
            label10.Text = "Ciudad";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(341, 558);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 53;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(332, 79);
            label13.Name = "label13";
            label13.Size = new Size(74, 15);
            label13.TabIndex = 55;
            label13.Text = "Empleado ID";
            // 
            // txtIDCliente
            // 
            txtIDCliente.Location = new Point(335, 53);
            txtIDCliente.Name = "txtIDCliente";
            txtIDCliente.Size = new Size(197, 23);
            txtIDCliente.TabIndex = 56;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(335, 97);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(121, 23);
            cmbEmpleado.TabIndex = 57;
            // 
            // FrmAddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 627);
            Controls.Add(cmbEmpleado);
            Controls.Add(txtIDCliente);
            Controls.Add(label13);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(dtpOrderDate);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Name = "FrmAddOrder";
            Text = "Agregar Orden";
            Load += FrmAddOrder_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label7;
        private Label label8;
        private TextBox txtEstado;
        private Label label4;
        private TextBox txtNombre;
        private Label label5;
        private TextBox txtDireccion;
        private Label label6;
        private TextBox txtPais;
        private Label label3;
        private TextBox txtContactoCargo;
        private Label label2;
        private Label label1;
        private Button btnAceptar;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpFechaEntrega;
        private DateTimePicker dtpFechaEmbarque;
        private Label label11;
        private ComboBox cmbIDbarco;
        private MaskedTextBox mtbFlete;
        private GroupBox groupBox1;
        private TextBox txtCiudad;
        private Label label10;
        private Label label12;
        private Button btnCancelar;
        private Label label13;
        private TextBox textBox3;
        private TextBox txtCodigoP;
        private TextBox txtIDCliente;
        private ComboBox cmbEmpleado;
    }
}