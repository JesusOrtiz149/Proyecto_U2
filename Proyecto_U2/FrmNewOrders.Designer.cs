namespace Proyecto_U2
{
    partial class FrmNewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewOrders));
            dtgNewOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgNewOrders).BeginInit();
            SuspendLayout();
            // 
            // dtgNewOrders
            // 
            dtgNewOrders.AllowUserToAddRows = false;
            dtgNewOrders.AllowUserToDeleteRows = false;
            dtgNewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgNewOrders.Location = new Point(2, 131);
            dtgNewOrders.Name = "dtgNewOrders";
            dtgNewOrders.ReadOnly = true;
            dtgNewOrders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgNewOrders.Size = new Size(381, 517);
            dtgNewOrders.TabIndex = 0;
            // 
            // FrmNewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 695);
            Controls.Add(dtgNewOrders);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmNewOrders";
            Text = "NewOrders";
            Load += FrmNewOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dtgNewOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgNewOrders;
    }
}