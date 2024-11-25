namespace Proyecto_U2
{
    partial class FrmTerritorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerritorios));
            dtgTerritory = new DataGridView();
            btnNuevoTerritory = new Button();
            lblEmployee = new Label();
            btnTerri = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgTerritory).BeginInit();
            SuspendLayout();
            // 
            // dtgTerritory
            // 
            dtgTerritory.AllowUserToAddRows = false;
            dtgTerritory.AllowUserToDeleteRows = false;
            dtgTerritory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTerritory.Location = new Point(70, 137);
            dtgTerritory.Margin = new Padding(4, 5, 4, 5);
            dtgTerritory.Name = "dtgTerritory";
            dtgTerritory.ReadOnly = true;
            dtgTerritory.RowHeadersWidth = 51;
            dtgTerritory.Size = new Size(464, 423);
            dtgTerritory.TabIndex = 1;
            // 
            // btnNuevoTerritory
            // 
            btnNuevoTerritory.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoTerritory.Location = new Point(498, 13);
            btnNuevoTerritory.Margin = new Padding(4);
            btnNuevoTerritory.Name = "btnNuevoTerritory";
            btnNuevoTerritory.Size = new Size(112, 37);
            btnNuevoTerritory.TabIndex = 14;
            btnNuevoTerritory.Text = "Nuevo";
            btnNuevoTerritory.UseVisualStyleBackColor = true;
            btnNuevoTerritory.Click += btnNuevoTerritory_Click;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmployee.Location = new Point(18, 23);
            lblEmployee.Margin = new Padding(4, 0, 4, 0);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(122, 27);
            lblEmployee.TabIndex = 15;
            lblEmployee.Text = "Empleado:";
            // 
            // btnTerri
            // 
            btnTerri.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTerri.Location = new Point(458, 91);
            btnTerri.Margin = new Padding(4);
            btnTerri.Name = "btnTerri";
            btnTerri.Size = new Size(172, 37);
            btnTerri.TabIndex = 16;
            btnTerri.Text = "Territorios";
            btnTerri.UseVisualStyleBackColor = true;
            btnTerri.Click += btnTerri_Click;
            // 
            // FrmTerritorios
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 610);
            Controls.Add(btnTerri);
            Controls.Add(lblEmployee);
            Controls.Add(btnNuevoTerritory);
            Controls.Add(dtgTerritory);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmTerritorios";
            Text = "Territorios";
            Load += FrmTerritorios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTerritory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgTerritory;
        private Button btnNuevoTerritory;
        private Label lblEmployee;
        private Button btnTerri;
    }
}