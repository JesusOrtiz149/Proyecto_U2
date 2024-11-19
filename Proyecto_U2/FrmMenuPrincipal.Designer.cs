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
            northwindToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            órdenesToolStripMenuItem = new ToolStripMenuItem();
            detallesDeLasÓrdenesToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            embarcaderosToolStripMenuItem = new ToolStripMenuItem();
            territorioToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            categoríasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, northwindToolStripMenuItem });
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
            // northwindToolStripMenuItem
            // 
            northwindToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarToolStripMenuItem, empleadosToolStripMenuItem, clientesToolStripMenuItem, proveedoresToolStripMenuItem, órdenesToolStripMenuItem, productosToolStripMenuItem, embarcaderosToolStripMenuItem, territorioToolStripMenuItem });
            northwindToolStripMenuItem.Image = (Image)resources.GetObject("northwindToolStripMenuItem.Image");
            northwindToolStripMenuItem.Name = "northwindToolStripMenuItem";
            northwindToolStripMenuItem.Size = new Size(96, 24);
            northwindToolStripMenuItem.Text = "Northwind";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Image = (Image)resources.GetObject("mostrarToolStripMenuItem.Image");
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(184, 26);
            mostrarToolStripMenuItem.Text = "mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(184, 26);
            empleadosToolStripMenuItem.Text = "Empleados";
            empleadosToolStripMenuItem.Click += empleadosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(184, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(184, 26);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // órdenesToolStripMenuItem
            // 
            órdenesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detallesDeLasÓrdenesToolStripMenuItem });
            órdenesToolStripMenuItem.Name = "órdenesToolStripMenuItem";
            órdenesToolStripMenuItem.Size = new Size(184, 26);
            órdenesToolStripMenuItem.Text = "Órdenes";
            órdenesToolStripMenuItem.Click += órdenesToolStripMenuItem_Click;
            // 
            // detallesDeLasÓrdenesToolStripMenuItem
            // 
            detallesDeLasÓrdenesToolStripMenuItem.Name = "detallesDeLasÓrdenesToolStripMenuItem";
            detallesDeLasÓrdenesToolStripMenuItem.Size = new Size(193, 22);
            detallesDeLasÓrdenesToolStripMenuItem.Text = "Detalles de las órdenes";
            detallesDeLasÓrdenesToolStripMenuItem.Click += detallesDeLasÓrdenesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { categoríasToolStripMenuItem });
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(184, 26);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // embarcaderosToolStripMenuItem
            // 
            embarcaderosToolStripMenuItem.Name = "embarcaderosToolStripMenuItem";
            embarcaderosToolStripMenuItem.Size = new Size(184, 26);
            embarcaderosToolStripMenuItem.Text = "Embarcaderos";
            embarcaderosToolStripMenuItem.Click += embarcaderosToolStripMenuItem_Click;
            // 
            // territorioToolStripMenuItem
            // 
            territorioToolStripMenuItem.Name = "territorioToolStripMenuItem";
            territorioToolStripMenuItem.Size = new Size(184, 26);
            territorioToolStripMenuItem.Text = "Territorios";
            territorioToolStripMenuItem.Click += territorioToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(587, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(587, 498);
            label1.Name = "label1";
            label1.Size = new Size(512, 109);
            label1.TabIndex = 2;
            label1.Text = "Northwind";
            // 
            // categoríasToolStripMenuItem
            // 
            categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            categoríasToolStripMenuItem.Size = new Size(180, 22);
            categoríasToolStripMenuItem.Text = "Categorías";
            categoríasToolStripMenuItem.Click += categoríasToolStripMenuItem_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1529, 704);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
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
        private ToolStripMenuItem northwindToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem órdenesToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem embarcaderosToolStripMenuItem;
        private ToolStripMenuItem detallesDeLasÓrdenesToolStripMenuItem;
        private ToolStripMenuItem territorioToolStripMenuItem;
        private ToolStripMenuItem categoríasToolStripMenuItem;
    }
}