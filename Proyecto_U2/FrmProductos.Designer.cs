namespace Proyecto_U2
{
    partial class FrmProductos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            dgvProducts = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            btnNuevoProducto = new Button();
            cmbSuppliers = new ComboBox();
            lblSupplier = new Label();
            txtProName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.ContextMenuStrip = contextMenuStrip1;
            dgvProducts.Location = new Point(21, 112);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(955, 260);
            dgvProducts.TabIndex = 2;
            dgvProducts.CellContentDoubleClick += dgvProducts_CellContentDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(117, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoProducto.Location = new Point(883, 70);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(93, 24);
            btnNuevoProducto.TabIndex = 3;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.Location = new Point(21, 69);
            cmbSuppliers.Margin = new Padding(3, 2, 3, 2);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(133, 23);
            cmbSuppliers.TabIndex = 4;
            cmbSuppliers.SelectedIndexChanged += cmbSuppliers_SelectedIndexChanged;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSupplier.Location = new Point(21, 42);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(85, 18);
            lblSupplier.TabIndex = 5;
            lblSupplier.Text = "SupplierID:";
            // 
            // txtProName
            // 
            txtProName.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProName.Location = new Point(281, 71);
            txtProName.Margin = new Padding(3, 2, 3, 2);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(456, 23);
            txtProName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(233, 51);
            label2.Name = "label2";
            label2.Size = new Size(111, 18);
            label2.TabIndex = 7;
            label2.Text = "ProductName:";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 410);
            Controls.Add(label2);
            Controls.Add(txtProName);
            Controls.Add(lblSupplier);
            Controls.Add(cmbSuppliers);
            Controls.Add(btnNuevoProducto);
            Controls.Add(dgvProducts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmProductos";
            Text = "Productos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnNuevoProducto;
        private ComboBox cmbSuppliers;
        private Label lblSupplier;
        private TextBox txtProName;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}