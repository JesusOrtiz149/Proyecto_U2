namespace Proyecto_U2
{
    partial class FrmOrdenes
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
            dtgOrders = new DataGridView();
            btnNuevaOrden = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgOrders).BeginInit();
            SuspendLayout();
            // 
            // dtgOrders
            // 
            dtgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOrders.Location = new Point(12, 40);
            dtgOrders.Margin = new Padding(3, 2, 3, 2);
            dtgOrders.Name = "dtgOrders";
            dtgOrders.RowHeadersWidth = 51;
            dtgOrders.Size = new Size(1073, 399);
            dtgOrders.TabIndex = 1;
            // 
            // btnNuevaOrden
            // 
            btnNuevaOrden.Location = new Point(430, 12);
            btnNuevaOrden.Name = "btnNuevaOrden";
            btnNuevaOrden.Size = new Size(116, 23);
            btnNuevaOrden.TabIndex = 2;
            btnNuevaOrden.Text = "Nueva orden";
            btnNuevaOrden.UseVisualStyleBackColor = true;
            btnNuevaOrden.Click += btnNuevaOrden_Click;
            // 
            // FrmOrdenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 450);
            Controls.Add(btnNuevaOrden);
            Controls.Add(dtgOrders);
            Name = "FrmOrdenes";
            Text = "Ordenes";
            Load += FrmOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgOrders;
        private Button btnNuevaOrden;
    }
}