namespace Proyecto_U2
{
    partial class FrmDetallesOrdenes
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
            dgvOrderDetails = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(24, 91);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.Size = new Size(555, 347);
            dgvOrderDetails.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(24, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmDetallesOrdenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 450);
            Controls.Add(button1);
            Controls.Add(dgvOrderDetails);
            Name = "FrmDetallesOrdenes";
            Text = "Detalles";
            Load += FrmDetallesOrdenes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrderDetails;
        private Button button1;
    }
}