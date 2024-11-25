namespace Proyecto_U2
{
    partial class FrmClientes
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
            dtgCustomers = new DataGridView();
            btnNuevoCustomer = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgCustomers
            // 
            dtgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomers.ContextMenuStrip = contextMenuStrip1;
            dtgCustomers.Location = new Point(3, 39);
            dtgCustomers.Margin = new Padding(3, 2, 3, 2);
            dtgCustomers.Name = "dtgCustomers";
            dtgCustomers.RowHeadersWidth = 51;
            dtgCustomers.Size = new Size(1087, 372);
            dtgCustomers.TabIndex = 1;
            // 
            // btnNuevoCustomer
            // 
            btnNuevoCustomer.Location = new Point(514, 11);
            btnNuevoCustomer.Margin = new Padding(3, 2, 3, 2);
            btnNuevoCustomer.Name = "btnNuevoCustomer";
            btnNuevoCustomer.Size = new Size(66, 24);
            btnNuevoCustomer.TabIndex = 6;
            btnNuevoCustomer.Text = "Nuevo";
            btnNuevoCustomer.UseVisualStyleBackColor = true;
            btnNuevoCustomer.Click += btnNuevoCustomer_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(117, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 413);
            Controls.Add(btnNuevoCustomer);
            Controls.Add(dtgCustomers);
            Name = "FrmClientes";
            Text = "Clientes";
            Load += FrmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgCustomers;
        private Button btnNuevoCustomer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}