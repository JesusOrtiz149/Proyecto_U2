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
            dtgTerritory = new DataGridView();
            btnNuevoTerritory = new Button();
            chkTerritorios = new CheckBox();
            chkRegion = new CheckBox();
            cmbTerritorio = new ComboBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgTerritory).BeginInit();
            SuspendLayout();
            // 
            // dtgTerritory
            // 
            dtgTerritory.AllowUserToAddRows = false;
            dtgTerritory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgTerritory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTerritory.Location = new Point(12, 111);
            dtgTerritory.Name = "dtgTerritory";
            dtgTerritory.RowHeadersWidth = 51;
            dtgTerritory.Size = new Size(776, 327);
            dtgTerritory.TabIndex = 1;
            // 
            // btnNuevoTerritory
            // 
            btnNuevoTerritory.Location = new Point(395, 51);
            btnNuevoTerritory.Margin = new Padding(3, 2, 3, 2);
            btnNuevoTerritory.Name = "btnNuevoTerritory";
            btnNuevoTerritory.Size = new Size(66, 23);
            btnNuevoTerritory.TabIndex = 14;
            btnNuevoTerritory.Text = "Nuevo";
            btnNuevoTerritory.UseVisualStyleBackColor = true;
            btnNuevoTerritory.Click += btnNuevoTerritory_Click;
            // 
            // chkTerritorios
            // 
            chkTerritorios.AutoSize = true;
            chkTerritorios.Location = new Point(724, 59);
            chkTerritorios.Margin = new Padding(3, 2, 3, 2);
            chkTerritorios.Name = "chkTerritorios";
            chkTerritorios.Size = new Size(78, 19);
            chkTerritorios.TabIndex = 13;
            chkTerritorios.Text = "Territorios";
            chkTerritorios.UseVisualStyleBackColor = true;
            // 
            // chkRegion
            // 
            chkRegion.AutoSize = true;
            chkRegion.Location = new Point(234, 55);
            chkRegion.Margin = new Padding(3, 2, 3, 2);
            chkRegion.Name = "chkRegion";
            chkRegion.Size = new Size(63, 19);
            chkRegion.TabIndex = 12;
            chkRegion.Text = "Region";
            chkRegion.UseVisualStyleBackColor = true;
            // 
            // cmbTerritorio
            // 
            cmbTerritorio.FormattingEnabled = true;
            cmbTerritorio.Location = new Point(585, 55);
            cmbTerritorio.Margin = new Padding(3, 2, 3, 2);
            cmbTerritorio.Name = "cmbTerritorio";
            cmbTerritorio.Size = new Size(133, 23);
            cmbTerritorio.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 53);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 10;
            // 
            // FrmTerritorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoTerritory);
            Controls.Add(chkTerritorios);
            Controls.Add(chkRegion);
            Controls.Add(cmbTerritorio);
            Controls.Add(comboBox1);
            Controls.Add(dtgTerritory);
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
        private CheckBox chkTerritorios;
        private CheckBox chkRegion;
        private ComboBox cmbTerritorio;
        private ComboBox comboBox1;
    }
}