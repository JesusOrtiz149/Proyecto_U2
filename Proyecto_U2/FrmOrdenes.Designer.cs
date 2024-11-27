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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenes));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dtgOrders = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem1 = new ToolStripMenuItem();
            btnNuevaOrden = new Button();
            btnRegresar = new Button();
            cmbEmployeeID = new ComboBox();
            txtEmployeeName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tabOrders = new TabControl();
            tabPage1 = new TabPage();
            lklOrdenes = new LinkLabel();
            btnBuscar = new Button();
            txtOrderID = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            chtOrde = new System.Windows.Forms.DataVisualization.Charting.Chart();
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dtgOrders).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            dtgOrders.ContextMenuStrip = contextMenuStrip1;
            dtgOrders.Location = new Point(24, 93);
            dtgOrders.Margin = new Padding(3, 2, 3, 2);
            dtgOrders.Name = "dtgOrders";
            dtgOrders.ReadOnly = true;
            dtgOrders.RowHeadersWidth = 51;
            dtgOrders.Size = new Size(1060, 301);
            dtgOrders.TabIndex = 1;
            dtgOrders.CellDoubleClick += dtgOrders_CellDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem1, eliminarToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(118, 48);
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.Size = new Size(117, 22);
            editarToolStripMenuItem1.Text = "Editar";
            editarToolStripMenuItem1.Click += editarToolStripMenuItem1_Click;
            // 
            // eliminarToolStripMenuItem1
            // 
            eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            eliminarToolStripMenuItem1.Size = new Size(117, 22);
            eliminarToolStripMenuItem1.Text = "Eliminar";
            eliminarToolStripMenuItem1.Click += eliminarToolStripMenuItem1_Click;
            // 
            // btnNuevaOrden
            // 
            btnNuevaOrden.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaOrden.Location = new Point(1165, 86);
            btnNuevaOrden.Margin = new Padding(3, 4, 3, 4);
            btnNuevaOrden.Name = "btnNuevaOrden";
            btnNuevaOrden.Size = new Size(129, 26);
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
            btnRegresar.Margin = new Padding(3, 2, 3, 2);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(96, 25);
            btnRegresar.TabIndex = 3;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // cmbEmployeeID
            // 
            cmbEmployeeID.FormattingEnabled = true;
            cmbEmployeeID.Location = new Point(18, 48);
            cmbEmployeeID.Name = "cmbEmployeeID";
            cmbEmployeeID.Size = new Size(133, 23);
            cmbEmployeeID.TabIndex = 4;
            cmbEmployeeID.SelectedIndexChanged += cmbEmployeeID_SelectedIndexChanged;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Font = new Font("Georgia", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeName.Location = new Point(342, 13);
            txtEmployeeName.Margin = new Padding(3, 2, 3, 2);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(208, 23);
            txtEmployeeName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 13);
            label1.Name = "label1";
            label1.Size = new Size(83, 18);
            label1.TabIndex = 6;
            label1.Text = "Empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 13);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 7;
            label2.Text = "IDEmpleado:";
            // 
            // tabOrders
            // 
            tabOrders.Controls.Add(tabPage1);
            tabOrders.Controls.Add(tabPage2);
            tabOrders.Location = new Point(10, 29);
            tabOrders.Margin = new Padding(3, 2, 3, 2);
            tabOrders.Name = "tabOrders";
            tabOrders.SelectedIndex = 0;
            tabOrders.Size = new Size(1169, 479);
            tabOrders.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lklOrdenes);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(txtOrderID);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtEmployeeName);
            tabPage1.Controls.Add(btnNuevaOrden);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dtgOrders);
            tabPage1.Controls.Add(cmbEmployeeID);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(1161, 451);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Orders";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lklOrdenes
            // 
            lklOrdenes.AutoSize = true;
            lklOrdenes.Location = new Point(1129, 533);
            lklOrdenes.Name = "lklOrdenes";
            lklOrdenes.Size = new Size(123, 15);
            lklOrdenes.TabIndex = 11;
            lklOrdenes.TabStop = true;
            lklOrdenes.Text = "Ver Ordenes Recientes";
            lklOrdenes.LinkClicked += lklOrdenes_LinkClicked;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(912, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(87, 30);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(757, 67);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(149, 23);
            txtOrderID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(578, 67);
            label3.Name = "label3";
            label3.Size = new Size(173, 18);
            label3.TabIndex = 8;
            label3.Text = "Ingresa la orden deseada";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chtOrde);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(1161, 451);
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
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(32, 19);
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(32, 19);
            // 
            // FrmOrdenes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 514);
            Controls.Add(tabOrders);
            Controls.Add(btnRegresar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmOrdenes";
            Text = "Ordenes";
            ((System.ComponentModel.ISupportInitialize)dtgOrders).EndInit();
            contextMenuStrip1.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private Button btnRegresar;
        private ComboBox cmbEmployeeID;
        private TextBox txtEmployeeName;
        private Label label1;
        private Label label2;
        private TabControl tabOrders;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtOrde;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem1;
        //  private ContextMenuStrip contextMenuStrip2;
        //   private ToolStripMenuItem editarToolStripMenuItem1;
        //   private ToolStripMenuItem eliminarToolStripMenuItem1;
        private Label label3;
        private Button btnBuscar;
        private TextBox txtOrderID;
        private LinkLabel lklOrdenes;
    }
}