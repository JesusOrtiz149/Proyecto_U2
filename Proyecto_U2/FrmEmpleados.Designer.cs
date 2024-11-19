namespace Proyecto_U2
{
    partial class FrmEmpleados
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
            dgvEmployees = new DataGridView();
            btnNuevoEmpleado = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 41);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(776, 397);
            dgvEmployees.TabIndex = 1;
            // 
            // btnNuevoEmpleado
            // 
            btnNuevoEmpleado.Location = new Point(312, 12);
            btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            btnNuevoEmpleado.Size = new Size(129, 23);
            btnNuevoEmpleado.TabIndex = 2;
            btnNuevoEmpleado.Text = "Nuevo Empleado";
            btnNuevoEmpleado.UseVisualStyleBackColor = true;
            btnNuevoEmpleado.Click += btnNuevoEmpleado_Click;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevoEmpleado);
            Controls.Add(dgvEmployees);
            Name = "FrmEmpleados";
            Text = "Empleados";
            Load += FrmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmployees;
        private Button btnNuevoEmpleado;
    }
}