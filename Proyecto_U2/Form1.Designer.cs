﻿namespace Proyecto_U2
{
    partial class Form1
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
            dgtEmpleados = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgtEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgtEmpleados
            // 
            dgtEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgtEmpleados.Location = new Point(34, 217);
            dgtEmpleados.Name = "dgtEmpleados";
            dgtEmpleados.RowHeadersWidth = 51;
            dgtEmpleados.Size = new Size(712, 424);
            dgtEmpleados.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(593, 85);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 672);
            Controls.Add(button1);
            Controls.Add(dgtEmpleados);
            Name = "Form1";
            Text = "Northwind";
            ((System.ComponentModel.ISupportInitialize)dgtEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgtEmpleados;
        private Button button1;
    }
}