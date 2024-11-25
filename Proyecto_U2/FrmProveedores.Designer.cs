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
            dgvSuppliers = new DataGridView();
            btnNuevoProveedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // FrmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 529);
            Controls.Add(btnNuevoProveedor);
            Controls.Add(dgvSuppliers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProveedores";
            Text = "FormProveedores";
            Load += FrmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSuppliers;
        private Button btnNuevoProveedor;
    }
}