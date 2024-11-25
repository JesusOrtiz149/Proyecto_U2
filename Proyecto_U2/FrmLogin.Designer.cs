namespace Proyecto_U2
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnSalir = new Button();
            btnIngresar = new Button();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtCustomers = new TextBox();
            chkCustomers = new CheckBox();
            txtSupplier = new TextBox();
            chkSupplier = new CheckBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightCoral;
            btnSalir.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(363, 490);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(180, 39);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ControlLight;
            btnIngresar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.Location = new Point(130, 338);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(236, 39);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Log in";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(139, 209);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(80, 34);
            txtContra.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(139, 141);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(234, 34);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(74, 212);
            label2.Name = "label2";
            label2.Size = new Size(45, 27);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(20, 141);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(163, 67);
            label3.Name = "label3";
            label3.Size = new Size(394, 46);
            label3.TabIndex = 1;
            label3.Text = "Northwind Access";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(637, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomers);
            groupBox1.Controls.Add(chkCustomers);
            groupBox1.Controls.Add(txtSupplier);
            groupBox1.Controls.Add(chkSupplier);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(btnIngresar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(txtContra);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(103, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(543, 535);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los Datos Requeridos";
            // 
            // txtCustomers
            // 
            txtCustomers.Location = new Point(139, 209);
            txtCustomers.Name = "txtCustomers";
            txtCustomers.Size = new Size(125, 34);
            txtCustomers.TabIndex = 10;
            txtCustomers.Visible = false;
            // 
            // chkCustomers
            // 
            chkCustomers.AutoSize = true;
            chkCustomers.Font = new Font("Georgia", 11F);
            chkCustomers.Location = new Point(422, 91);
            chkCustomers.Name = "chkCustomers";
            chkCustomers.Size = new Size(91, 27);
            chkCustomers.TabIndex = 9;
            chkCustomers.Text = "Cliente";
            chkCustomers.UseVisualStyleBackColor = true;
            chkCustomers.CheckedChanged += chkCustomers_CheckedChanged;
            // 
            // txtSupplier
            // 
            txtSupplier.Location = new Point(139, 209);
            txtSupplier.Name = "txtSupplier";
            txtSupplier.Size = new Size(89, 34);
            txtSupplier.TabIndex = 8;
            txtSupplier.Visible = false;
            // 
            // chkSupplier
            // 
            chkSupplier.AutoSize = true;
            chkSupplier.Font = new Font("Georgia", 11F);
            chkSupplier.Location = new Point(422, 58);
            chkSupplier.Name = "chkSupplier";
            chkSupplier.Size = new Size(109, 27);
            chkSupplier.TabIndex = 7;
            chkSupplier.Text = "Provedor";
            chkSupplier.UseVisualStyleBackColor = true;
            chkSupplier.CheckedChanged += chkSupplier_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(184, 303);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Olvidaste tu id?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(773, 697);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label2;
        private Label label1;
        private Button btnIngresar;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private CheckBox chkSupplier;
        private TextBox txtSupplier;
        private CheckBox chkCustomers;
        private TextBox txtCustomers;
    }
}