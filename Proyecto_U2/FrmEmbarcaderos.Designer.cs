﻿namespace Proyecto_U2
{
    partial class FrmEmbarcaderos
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
            dgvShippers = new DataGridView();
            btnNuevoEmbarcadero = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShippers).BeginInit();
            SuspendLayout();
            // 
            // dgvShippers
            // 
            dgvShippers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShippers.Location = new Point(130, 276);
            dgvShippers.Margin = new Padding(3, 4, 3, 4);
            dgvShippers.Name = "dgvShippers";
            dgvShippers.RowHeadersWidth = 51;
            dgvShippers.Size = new Size(638, 308);
            dgvShippers.TabIndex = 2;
            // 
            // btnNuevoEmbarcadero
            // 
            btnNuevoEmbarcadero.Location = new Point(335, 153);
            btnNuevoEmbarcadero.Margin = new Padding(3, 4, 3, 4);
            btnNuevoEmbarcadero.Name = "btnNuevoEmbarcadero";
            btnNuevoEmbarcadero.Size = new Size(159, 31);
            btnNuevoEmbarcadero.TabIndex = 3;
            btnNuevoEmbarcadero.Text = "Nuevo Embarcadero";
            btnNuevoEmbarcadero.UseVisualStyleBackColor = true;
            btnNuevoEmbarcadero.Click += btnNuevoEmbarcadero_Click;
            // 
            // FrmEmbarcaderos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnNuevoEmbarcadero);
            Controls.Add(dgvShippers);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEmbarcaderos";
            Text = "FrmEmbarcaderoscs";
            Load += FrmEmbarcaderos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShippers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShippers;
        private Button btnNuevoEmbarcadero;
    }
}