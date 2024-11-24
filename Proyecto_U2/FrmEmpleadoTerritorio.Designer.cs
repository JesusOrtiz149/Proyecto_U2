namespace Proyecto_U2
{
    partial class FrmEmpleadoTerritorio
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
            dgvEmployeeTerritories = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeTerritories).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployeeTerritories
            // 
            dgvEmployeeTerritories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeTerritories.Location = new Point(43, 92);
            dgvEmployeeTerritories.Name = "dgvEmployeeTerritories";
            dgvEmployeeTerritories.Size = new Size(373, 150);
            dgvEmployeeTerritories.TabIndex = 0;
            // 
            // FrmEmpleadoTerritorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 355);
            Controls.Add(dgvEmployeeTerritories);
            Name = "FrmEmpleadoTerritorio";
            Text = "Empleado por Territorio";
            Load += FrmEmpleadoTerritorio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeTerritories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployeeTerritories;
    }
}