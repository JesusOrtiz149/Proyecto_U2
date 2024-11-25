namespace Proyecto_U2
{
    partial class FrmAddShippers
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
            txtCompanyName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            mtbPhone = new MaskedTextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(22, 33);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(100, 23);
            txtCompanyName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre de la compañía";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 15);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Teléfono";
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(184, 33);
            mtbPhone.Mask = "(000) 000-0000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(86, 23);
            mtbPhone.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(72, 103);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(153, 103);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmAddShippers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 174);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(mtbPhone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCompanyName);
            Name = "FrmAddShippers";
            Text = "Agregar Embarcadero";
            Load += FrmAddShippers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCompanyName;
        private Label label1;
        private Label label2;
        private MaskedTextBox mtbPhone;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}