namespace Proyecto_U2
{
    partial class FrmOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenes));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dtgOrders = new DataGridView();
            btnNuevaOrden = new Button();
            btnRegresar = new Button();
            cmbEmployeeID = new ComboBox();
            txtEmployeeName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tabOrders = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            chtOrde = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dtgOrders).BeginInit();
            tabOrders.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chtOrde).BeginInit();
            SuspendLayout();
            // 
            // dtgOrders
            // 
            dtgOrders.AllowUserToAddRows = false;
            dtgOrders.AllowUserToDeleteRows = false;
            dtgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgOrders.Location = new Point(18, 125);
            dtgOrders.Name = "dtgOrders";
            dtgOrders.ReadOnly = true;
            dtgOrders.RowHeadersWidth = 51;
            dtgOrders.Size = new Size(1211, 401);
            dtgOrders.TabIndex = 1;
            dtgOrders.CellDoubleClick += dtgOrders_CellDoubleClick;
            // 
            // btnNuevaOrden
            // 
            btnNuevaOrden.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaOrden.Location = new Point(1069, 83);
            btnNuevaOrden.Margin = new Padding(3, 4, 3, 4);
            btnNuevaOrden.Name = "btnNuevaOrden";
            btnNuevaOrden.Size = new Size(147, 35);
            btnNuevaOrden.TabIndex = 2;
            btnNuevaOrden.Text = "Nueva orden";
            btnNuevaOrden.UseVisualStyleBackColor = true;
            btnNuevaOrden.Click += btnNuevaOrden_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.IndianRed;
            btnRegresar.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.ControlText;
            btnRegresar.Image = (Image)resources.GetObject("btnRegresar.Image");
            btnRegresar.Location = new Point(-2, 0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(110, 33);
            btnRegresar.TabIndex = 3;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // cmbEmployeeID
            // 
            cmbEmployeeID.FormattingEnabled = true;
            cmbEmployeeID.Location = new Point(28, 76);
            cmbEmployeeID.Name = "cmbEmployeeID";
            cmbEmployeeID.Size = new Size(151, 28);
            cmbEmployeeID.TabIndex = 4;
            cmbEmployeeID.SelectedIndexChanged += cmbEmployeeID_SelectedIndexChanged;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(374, 76);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(237, 27);
            txtEmployeeName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 77);
            label1.Name = "label1";
            label1.Size = new Size(106, 24);
            label1.TabIndex = 6;
            label1.Text = "Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 41);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 7;
            label2.Text = "IDEmpleado:";
            // 
            // tabOrders
            // 
            tabOrders.Controls.Add(tabPage1);
            tabOrders.Controls.Add(tabPage2);
            tabOrders.Location = new Point(12, 39);
            tabOrders.Name = "tabOrders";
            tabOrders.SelectedIndex = 0;
            tabOrders.Size = new Size(1336, 639);
            tabOrders.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtEmployeeName);
            tabPage1.Controls.Add(btnNuevaOrden);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dtgOrders);
            tabPage1.Controls.Add(cmbEmployeeID);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1328, 606);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Orders";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chtOrde);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1328, 606);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chtOrde
            // 
            chartArea1.Name = "ChartArea1";
            chtOrde.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chtOrde.Legends.Add(legend1);
            chtOrde.Location = new Point(34, 29);
            chtOrde.Name = "chtOrde";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "OrderCount";
            chtOrde.Series.Add(series1);
            chtOrde.Size = new Size(1214, 549);
            chtOrde.TabIndex = 0;
            chtOrde.Text = "OrderCount";
            // 
            // FrmOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 685);
            Controls.Add(tabOrders);
            Controls.Add(btnRegresar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmOrdenes";
            Text = "Ordenes";
            Load += FrmOrdenes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgOrders).EndInit();
            tabOrders.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chtOrde).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgOrders;
        private Button btnNuevaOrden;
        private Button btnRegresar;
        private ComboBox cmbEmployeeID;
        private TextBox txtEmployeeName;
        private Label label1;
        private Label label2;
        private TabControl tabOrders;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtOrde;
    }
}