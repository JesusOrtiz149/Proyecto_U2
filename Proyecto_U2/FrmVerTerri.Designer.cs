namespace Proyecto_U2
{
    partial class FrmVerTerri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerTerri));
            dtgTerri = new DataGridView();
            cmbRegion = new ComboBox();
            lblRegion = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgTerri).BeginInit();
            SuspendLayout();
            // 
            // dtgTerri
            // 
            dtgTerri.AllowUserToAddRows = false;
            dtgTerri.AllowUserToDeleteRows = false;
            dtgTerri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTerri.Location = new Point(26, 108);
            dtgTerri.Name = "dtgTerri";
            dtgTerri.ReadOnly = true;
            dtgTerri.RowHeadersWidth = 51;
            dtgTerri.Size = new Size(558, 455);
            dtgTerri.TabIndex = 0;
            // 
            // cmbRegion
            // 
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Location = new Point(26, 54);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(151, 28);
            cmbRegion.TabIndex = 1;
            cmbRegion.SelectedIndexChanged += cmbRegion_SelectedIndexChanged;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegion.Location = new Point(26, 21);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(73, 21);
            lblRegion.TabIndex = 2;
            lblRegion.Text = "Region:";
            // 
            // FrmVerTerri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 575);
            Controls.Add(lblRegion);
            Controls.Add(cmbRegion);
            Controls.Add(dtgTerri);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmVerTerri";
            Text = "VerTerri";
            Load += FrmVerTerri_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTerri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgTerri;
        private ComboBox cmbRegion;
        private Label lblRegion;
    }
}