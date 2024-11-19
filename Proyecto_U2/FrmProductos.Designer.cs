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
            dgvProducts = new DataGridView();
            btnNuevoProducto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(29, 41);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(731, 397);
            dgvProducts.TabIndex = 2;
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Location = new Point(335, 12);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(75, 23);
            btnNuevoProducto.TabIndex = 3;
            btnNuevoProducto.Text = "Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoProducto);
            Controls.Add(dgvProducts);
            Name = "FrmProductos";
            Text = "Productos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProducts;
        private Button btnNuevoProducto;
    }
}