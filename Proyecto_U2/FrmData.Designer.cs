namespace Proyecto_U2
{
    partial class FrmData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmData));
            txtLastName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            btnRevisar = new Button();
            txtTitle = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(190, 83);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(125, 27);
            txtLastName.TabIndex = 1;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 86);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 1;
            label1.Text = "LastName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 144);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 3;
            label3.Text = "Tilte:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlDark;
            label5.Font = new Font("Georgia", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(130, 22);
            label5.Name = "label5";
            label5.Size = new Size(225, 32);
            label5.TabIndex = 8;
            label5.Text = "Recuperacion ID";
            // 
            // btnRevisar
            // 
            btnRevisar.BackColor = Color.DarkGray;
            btnRevisar.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRevisar.Location = new Point(143, 215);
            btnRevisar.Name = "btnRevisar";
            btnRevisar.Size = new Size(112, 33);
            btnRevisar.TabIndex = 3;
            btnRevisar.Text = "Revisar";
            btnRevisar.UseVisualStyleBackColor = false;
            btnRevisar.Click += button1_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(190, 144);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSteelBlue;
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(btnRevisar);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtLastName);
            groupBox1.Location = new Point(50, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 323);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // FrmData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(494, 423);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmData";
            Text = "RecuperacionID";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLastName;
        private Label label1;
        private Label label3;
        private Label label5;
        private Button btnRevisar;
        private TextBox txtTitle;
        private GroupBox groupBox1;
    }
}