namespace Proyecto_U2
{
    partial class FrmCategorias
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
            dgvCategories = new DataGridView();
            btnNuevaCategoria = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Location = new Point(19, 31);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(838, 407);
            dgvCategories.TabIndex = 1;
            // 
            // btnNuevaCategoria
            // 
            btnNuevaCategoria.Location = new Point(19, 2);
            btnNuevaCategoria.Name = "btnNuevaCategoria";
            btnNuevaCategoria.Size = new Size(119, 23);
            btnNuevaCategoria.TabIndex = 2;
            btnNuevaCategoria.Text = "Nueva Categoría";
            btnNuevaCategoria.UseVisualStyleBackColor = true;
            btnNuevaCategoria.Click += button1_Click;
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 450);
            Controls.Add(btnNuevaCategoria);
            Controls.Add(dgvCategories);
            Name = "FrmCategorias";
            Text = "Categorías";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCategories;
        private Button btnNuevaCategoria;
    }
}