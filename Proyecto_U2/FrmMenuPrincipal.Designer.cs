namespace Proyecto_U2
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnEmpleados = new Button();
            btnTerritorios = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnMostrar = new Button();
            btnSuppliers = new Button();
            btnEmbarca = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1529, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Image = (Image)resources.GetObject("archivoToolStripMenuItem.Image");
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(80, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = (Image)resources.GetObject("salirToolStripMenuItem.Image");
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(95, 22);
            salirToolStripMenuItem.Text = "salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1214, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(505, 115);
            label1.Name = "label1";
            label1.Size = new Size(512, 109);
            label1.TabIndex = 2;
            label1.Text = "Northwind";
            // 
            // btnEmpleados
            // 
            btnEmpleados.Font = new Font("Georgia", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = SystemColors.ActiveCaptionText;
            btnEmpleados.Image = (Image)resources.GetObject("btnEmpleados.Image");
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(561, 240);
            btnEmpleados.Margin = new Padding(3, 2, 3, 2);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(393, 115);
            btnEmpleados.TabIndex = 4;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnTerritorios
            // 
            btnTerritorios.Font = new Font("Georgia", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTerritorios.ForeColor = SystemColors.ActiveCaptionText;
            btnTerritorios.Image = (Image)resources.GetObject("btnTerritorios.Image");
            btnTerritorios.ImageAlign = ContentAlignment.MiddleLeft;
            btnTerritorios.Location = new Point(561, 381);
            btnTerritorios.Margin = new Padding(3, 2, 3, 2);
            btnTerritorios.Name = "btnTerritorios";
            btnTerritorios.Size = new Size(393, 115);
            btnTerritorios.TabIndex = 5;
            btnTerritorios.Text = "Territorios";
            btnTerritorios.UseVisualStyleBackColor = true;
            btnTerritorios.Click += btnTerritorios_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Georgia", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = SystemColors.ActiveCaptionText;
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(1067, 240);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(393, 106);
            btnClientes.TabIndex = 6;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Georgia", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = SystemColors.ActiveCaptionText;
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(1067, 381);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(393, 115);
            btnProductos.TabIndex = 7;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Georgia", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMostrar.ForeColor = SystemColors.ActiveCaptionText;
            btnMostrar.Image = (Image)resources.GetObject("btnMostrar.Image");
            btnMostrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMostrar.Location = new Point(84, 240);
            btnMostrar.Margin = new Padding(3, 2, 3, 2);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(393, 115);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Ordenes";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Font = new Font("Georgia", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuppliers.ForeColor = SystemColors.ActiveCaptionText;
            btnSuppliers.Image = (Image)resources.GetObject("btnSuppliers.Image");
            btnSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuppliers.Location = new Point(84, 381);
            btnSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(393, 115);
            btnSuppliers.TabIndex = 8;
            btnSuppliers.Text = "Provedores";
            btnSuppliers.UseVisualStyleBackColor = true;
            btnSuppliers.Click += btnSuppliers_Click;
            // 
            // btnEmbarca
            // 
            btnEmbarca.Font = new Font("Georgia", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmbarca.ForeColor = SystemColors.ActiveCaptionText;
            btnEmbarca.Image = (Image)resources.GetObject("btnEmbarca.Image");
            btnEmbarca.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmbarca.Location = new Point(561, 532);
            btnEmbarca.Margin = new Padding(3, 2, 3, 2);
            btnEmbarca.Name = "btnEmbarca";
            btnEmbarca.Size = new Size(393, 115);
            btnEmbarca.TabIndex = 9;
            btnEmbarca.Text = "Embarcaderos";
            btnEmbarca.UseVisualStyleBackColor = true;
            btnEmbarca.Click += btnEmbarca_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1529, 704);
            Controls.Add(btnEmbarca);
            Controls.Add(btnSuppliers);
            Controls.Add(btnMostrar);
            Controls.Add(btnProductos);
            Controls.Add(btnClientes);
            Controls.Add(btnTerritorios);
            Controls.Add(btnEmpleados);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenuPrincipal";
            Text = "MenuPrincipal";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem órdenesToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem detallesDeLasÓrdenesToolStripMenuItem;
        private Button btnEmbarca;
        private Button button2;
        private Button btnTerritorios;
        private Button btnClientes;
        private Button btnProductos;
        private Button button6;
        private Button btnEmpleados;
        private Button btnMostrar;
        private Button btnSuppliers;
    }
}