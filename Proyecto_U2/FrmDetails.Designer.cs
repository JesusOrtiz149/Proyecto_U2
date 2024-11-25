namespace Proyecto_U2
{
    partial class FrmDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetails));
            dtgDetails = new DataGridView();
            lblCompanyName = new Label();
            lblTotal = new Label();
            lblOrderID = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDetails).BeginInit();
            SuspendLayout();
            // 
            // dtgDetails
            // 
            dtgDetails.AllowUserToAddRows = false;
            dtgDetails.AllowUserToDeleteRows = false;
            dtgDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDetails.Location = new Point(12, 95);
            dtgDetails.Name = "dtgDetails";
            dtgDetails.ReadOnly = true;
            dtgDetails.RowHeadersWidth = 51;
            dtgDetails.Size = new Size(723, 169);
            dtgDetails.TabIndex = 0;
            dtgDetails.CellContentClick += dtgDetails_CellContentClick;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(500, 21);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(177, 27);
            lblCompanyName.TabIndex = 2;
            lblCompanyName.Text = "CompanyName:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(488, 279);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(72, 27);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderID.Location = new Point(24, 31);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(104, 27);
            lblOrderID.TabIndex = 1;
            lblOrderID.Text = "OrderID:";
            // 
            // FrmDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 348);
            Controls.Add(dtgDetails);
            Controls.Add(lblTotal);
            Controls.Add(lblOrderID);
            Controls.Add(lblCompanyName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDetails";
            Text = "Details";
            Load += FrmDetails_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDetails;
        private Label lblCompanyName;
        private Label lblTotal;
        private Label lblOrderID;
    }
}