namespace Proyecto_U2
{
    partial class FrmAddTerritory
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
            btnAceptar = new Button();
            txtTerritory = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbRegion = new ComboBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(294, 124);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtTerritory
            // 
            txtTerritory.Location = new Point(156, 54);
            txtTerritory.Name = "txtTerritory";
            txtTerritory.Size = new Size(197, 23);
            txtTerritory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 2;
            label1.Text = "Descripción del Territorio";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 62);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Región";
            // 
            // cmbRegion
            // 
            cmbRegion.FormattingEnabled = true;
            cmbRegion.Items.AddRange(new object[] { "Eastern", "Western", "Northern", "Southern" });
            cmbRegion.Location = new Point(420, 54);
            cmbRegion.Name = "cmbRegion";
            cmbRegion.Size = new Size(121, 23);
            cmbRegion.TabIndex = 4;
            // 
            // FrmAddTerritory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 167);
            Controls.Add(cmbRegion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTerritory);
            Controls.Add(btnAceptar);
            Name = "FrmAddTerritory";
            Text = "Agregar Territorio";
            Load += FrmAddTerritory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private TextBox txtTerritory;
        private Label label1;
        private Label label2;
        private ComboBox cmbRegion;
    }
}