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
            dtgCustomers = new DataGridView();
            btnNuevoCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).BeginInit();
            SuspendLayout();
            // 
            // dtgCustomers
            // 
            dtgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 413);
            Controls.Add(btnNuevoCustomer);
            Controls.Add(dtgCustomers);
            Name = "FrmClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgCustomers;
        private Button btnNuevoCustomer;
    }
}