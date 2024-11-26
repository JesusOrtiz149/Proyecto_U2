namespace Proyecto_U2
{
    partial class FrmProveedores
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
            dgvSuppliers = new DataGridView();
            btnNuevoProveedor = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.ContextMenuStrip = contextMenuStrip1;
            dgvSuppliers.Location = new Point(12, 41);
            dgvSuppliers.Location = new Point(14, 176);
            dgvSuppliers.Margin = new Padding(3, 4, 3, 4);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.Size = new Size(909, 308);
            dgvSuppliers.TabIndex = 1;
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoProveedor.Location = new Point(741, 114);
            btnNuevoProveedor.Margin = new Padding(3, 4, 3, 4);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(182, 31);
            btnNuevoProveedor.TabIndex = 2;
            btnNuevoProveedor.Text = "Nuevo Proveedor";
            btnNuevoProveedor.UseVisualStyleBackColor = true;
            btnNuevoProveedor.Click += btnNuevoProveedor_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(180, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(180, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 529);
            Controls.Add(btnNuevoProveedor);
            Controls.Add(dgvSuppliers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProveedores";
            Text = "Proveedores";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSuppliers;
        private Button btnNuevoProveedor;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}