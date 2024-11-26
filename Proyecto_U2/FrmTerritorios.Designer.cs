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
            components = new System.ComponentModel.Container();
            dtgTerritory = new DataGridView();
            btnNuevoTerritory = new Button();
            lblEmployee = new Label();
            btnTerri = new Button();
            chkTerritorios = new CheckBox();
            chkRegion = new CheckBox();
            cmbTerritorio = new ComboBox();
            comboBox1 = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgTerritory).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgTerritory
            // 
            dtgTerritory.AllowUserToAddRows = false;
            dtgTerritory.AllowUserToDeleteRows = false;
            dtgTerritory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgTerritory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           
            dtgTerritory.Margin = new Padding(4, 5, 4, 5);
            dtgTerritory.ContextMenuStrip = contextMenuStrip1;
            dtgTerritory.Location = new Point(12, 111);
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(117, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(117, 22);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
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
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgTerritory;
        private Button btnNuevoTerritory;
        private Label lblEmployee;
        private Button btnTerri;
        private CheckBox chkTerritorios;
        private CheckBox chkRegion;
        private ComboBox cmbTerritorio;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
    }
}