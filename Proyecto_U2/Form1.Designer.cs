namespace Proyecto_U2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgTerritory = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            chkTerritorios = new CheckBox();
            chkRegion = new CheckBox();
            cmbTerritorio = new ComboBox();
            comboBox1 = new ComboBox();
            tabPage2 = new TabPage();
            cmbPais = new ComboBox();
            rbtCiudad = new RadioButton();
            dtgEmployees = new DataGridView();
            tabPage3 = new TabPage();
            dtgCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgTerritory).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmployees).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).BeginInit();
            SuspendLayout();
            // 
            // dtgTerritory
            // 
            dtgTerritory.AllowUserToAddRows = false;
            dtgTerritory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgTerritory.Location = new Point(27, 93);
            dtgTerritory.Margin = new Padding(3, 4, 3, 4);
            dtgTerritory.Name = "dtgTerritory";
            dtgTerritory.RowHeadersWidth = 51;
            dtgTerritory.Size = new Size(438, 436);
            dtgTerritory.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1270, 588);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkTerritorios);
            tabPage1.Controls.Add(chkRegion);
            tabPage1.Controls.Add(dtgTerritory);
            tabPage1.Controls.Add(cmbTerritorio);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1262, 555);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabTerritory";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkTerritorios
            // 
            chkTerritorios.AutoSize = true;
            chkTerritorios.Location = new Point(874, 37);
            chkTerritorios.Name = "chkTerritorios";
            chkTerritorios.Size = new Size(98, 24);
            chkTerritorios.TabIndex = 8;
            chkTerritorios.Text = "Territorios";
            chkTerritorios.UseVisualStyleBackColor = true;
            // 
            // chkRegion
            // 
            chkRegion.AutoSize = true;
            chkRegion.Location = new Point(242, 33);
            chkRegion.Name = "chkRegion";
            chkRegion.Size = new Size(78, 24);
            chkRegion.TabIndex = 7;
            chkRegion.Text = "Region";
            chkRegion.UseVisualStyleBackColor = true;
            // 
            // cmbTerritorio
            // 
            cmbTerritorio.FormattingEnabled = true;
            cmbTerritorio.Location = new Point(657, 33);
            cmbTerritorio.Name = "cmbTerritorio";
            cmbTerritorio.Size = new Size(151, 28);
            cmbTerritorio.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(27, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbPais);
            tabPage2.Controls.Add(rbtCiudad);
            tabPage2.Controls.Add(dtgEmployees);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1262, 555);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(44, 53);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(179, 28);
            cmbPais.TabIndex = 3;
            // 
            // rbtCiudad
            // 
            rbtCiudad.AutoSize = true;
            rbtCiudad.Location = new Point(272, 53);
            rbtCiudad.Name = "rbtCiudad";
            rbtCiudad.Size = new Size(77, 24);
            rbtCiudad.TabIndex = 2;
            rbtCiudad.TabStop = true;
            rbtCiudad.Text = "Ciudad";
            rbtCiudad.UseVisualStyleBackColor = true;
            rbtCiudad.CheckedChanged += rbtCiudad_CheckedChanged;
            // 
            // dtgEmployees
            // 
            dtgEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmployees.Location = new Point(25, 243);
            dtgEmployees.Name = "dtgEmployees";
            dtgEmployees.RowHeadersWidth = 51;
            dtgEmployees.Size = new Size(1176, 294);
            dtgEmployees.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dtgCustomers);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1262, 555);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgCustomers
            // 
            dtgCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCustomers.Location = new Point(29, 211);
            dtgCustomers.Name = "dtgCustomers";
            dtgCustomers.RowHeadersWidth = 51;
            dtgCustomers.Size = new Size(896, 306);
            dtgCustomers.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 705);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Northwind";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgTerritory).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgEmployees).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgTerritory;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dtgEmployees;
        private RadioButton rbtCiudad;
        private ComboBox cmbPais;
        private ComboBox comboBox1;
        private ComboBox cmbTerritorio;
        private DataGridView dtgCustomers;
        private TabPage tabPage3;
        private CheckBox chkTerritorios;
        private CheckBox chkRegion;
    }
}
