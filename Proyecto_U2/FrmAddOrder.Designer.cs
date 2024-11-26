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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddOrder));
            dtgCarrito = new DataGridView();
            lblOrder = new Label();
            lblProd = new Label();
            cmbProductos = new ComboBox();
            btnAgregar = new Button();
            btnOrder = new Button();
            btnAgrOrder = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgCarrito).BeginInit();
            SuspendLayout();
            // 
            // dtgCarrito
            // 
            dtgCarrito.AllowUserToAddRows = false;
            dtgCarrito.AllowUserToDeleteRows = false;
            dtgCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCarrito.Location = new Point(12, 169);
            dtgCarrito.Name = "dtgCarrito";
            dtgCarrito.ReadOnly = true;
            dtgCarrito.RowHeadersWidth = 51;
            dtgCarrito.Size = new Size(568, 241);
            dtgCarrito.TabIndex = 0;
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrder.Location = new Point(12, 50);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(0, 27);
            lblOrder.TabIndex = 1;
            // 
            // lblProd
            // 
            lblProd.AutoSize = true;
            lblProd.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProd.Location = new Point(133, 17);
            lblProd.Name = "lblProd";
            lblProd.Size = new Size(106, 24);
            lblProd.TabIndex = 2;
            lblProd.Text = "Productos:";
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(245, 14);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(257, 28);
            cmbProductos.TabIndex = 3;
            cmbProductos.SelectedIndexChanged += cmbProductos_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(539, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(12, 12);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 5;
            btnOrder.Text = "OrderID";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnAgrOrder
            // 
            btnAgrOrder.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgrOrder.Location = new Point(467, 427);
            btnAgrOrder.Name = "btnAgrOrder";
            btnAgrOrder.Size = new Size(166, 31);
            btnAgrOrder.TabIndex = 6;
            btnAgrOrder.Text = "AgrOrder";
            btnAgrOrder.UseVisualStyleBackColor = true;
            btnAgrOrder.Click += btnAgrOrder_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ImageAlign = ContentAlignment.MiddleRight;
            lblTotal.Location = new Point(440, 142);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 24);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total:";
            // 
            // FrmAddOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(645, 482);
            Controls.Add(lblTotal);
            Controls.Add(btnAgrOrder);
            Controls.Add(btnOrder);
            Controls.Add(btnAgregar);
            Controls.Add(cmbProductos);
            Controls.Add(lblProd);
            Controls.Add(lblOrder);
            Controls.Add(dtgCarrito);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmAddOrder";
            Text = "AddOrder";
            Load += FrmAddOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dtgCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgCarrito;
        private Label lblOrder;
        private Label lblProd;
        private ComboBox cmbProductos;
        private Button btnAgregar;
        private Button btnOrder;
        private Button btnAgrOrder;
        private Label lblTotal;
    }
}