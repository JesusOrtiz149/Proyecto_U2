namespace Proyecto_U2
{
    partial class FrmAddProduct
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
            btnCancelar = new Button();
            mtbUnInv = new MaskedTextBox();
            label9 = new Label();
            label10 = new Label();
            label3 = new Label();
            txtUnidadxCantidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombreProduct = new TextBox();
            btnAceptar = new Button();
            mtbSuppID = new MaskedTextBox();
            mtbPrecio = new MaskedTextBox();
            mtbUnOnOrder = new MaskedTextBox();
            label11 = new Label();
            mtbNivelReorder = new MaskedTextBox();
            label4 = new Label();
            cmbCategoria = new ComboBox();
            label5 = new Label();
            cmbDescontinuado = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(289, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtbUnInv
            // 
            mtbUnInv.Location = new Point(36, 172);
            mtbUnInv.Mask = "0000";
            mtbUnInv.Name = "mtbUnInv";
            mtbUnInv.Size = new Size(100, 23);
            mtbUnInv.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 156);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 45;
            label9.Text = "Unidades en inventario";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(266, 11);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 44;
            label10.Text = "Precio por unidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 205);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 36;
            label3.Text = "Cantidad por unidad";
            // 
            // txtUnidadxCantidad
            // 
            txtUnidadxCantidad.Location = new Point(33, 223);
            txtUnidadxCantidad.Name = "txtUnidadxCantidad";
            txtUnidadxCantidad.Size = new Size(197, 23);
            txtUnidadxCantidad.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 11);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 34;
            label2.Text = "Supplier ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 58);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 31;
            label1.Text = "Nombre del Producto";
            // 
            // txtNombreProduct
            // 
            txtNombreProduct.Location = new Point(33, 76);
            txtNombreProduct.Name = "txtNombreProduct";
            txtNombreProduct.Size = new Size(197, 23);
            txtNombreProduct.TabIndex = 28;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(142, 272);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // mtbSuppID
            // 
            mtbSuppID.Location = new Point(34, 29);
            mtbSuppID.Mask = "000";
            mtbSuppID.Name = "mtbSuppID";
            mtbSuppID.Size = new Size(100, 23);
            mtbSuppID.TabIndex = 50;
            // 
            // mtbPrecio
            // 
            mtbPrecio.Location = new Point(266, 29);
            mtbPrecio.Mask = "0000.00";
            mtbPrecio.Name = "mtbPrecio";
            mtbPrecio.Size = new Size(100, 23);
            mtbPrecio.TabIndex = 51;
            // 
            // mtbUnOnOrder
            // 
            mtbUnOnOrder.Location = new Point(263, 76);
            mtbUnOnOrder.Mask = "0000";
            mtbUnOnOrder.Name = "mtbUnOnOrder";
            mtbUnOnOrder.Size = new Size(100, 23);
            mtbUnOnOrder.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(260, 58);
            label11.Name = "label11";
            label11.Size = new Size(129, 15);
            label11.TabIndex = 52;
            label11.Text = "Unidades Sobre Pedido";
            // 
            // mtbNivelReorder
            // 
            mtbNivelReorder.Location = new Point(260, 125);
            mtbNivelReorder.Mask = "0000";
            mtbNivelReorder.Name = "mtbNivelReorder";
            mtbNivelReorder.Size = new Size(100, 23);
            mtbNivelReorder.TabIndex = 55;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 107);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 54;
            label4.Text = "Nivel de Pedidos";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Bebidas", "Condimentos", "Confitería", "Productos diarios", "Granos/Cereales", "Carne Roja/blanca", "Alimentos procesados", "Mariscos" });
            cmbCategoria.Location = new Point(34, 125);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 107);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 59;
            label5.Text = "Categoría";
            // 
            // cmbDescontinuado
            // 
            cmbDescontinuado.FormattingEnabled = true;
            cmbDescontinuado.Items.AddRange(new object[] { "No", "Sí" });
            cmbDescontinuado.Location = new Point(260, 172);
            cmbDescontinuado.Name = "cmbDescontinuado";
            cmbDescontinuado.Size = new Size(121, 23);
            cmbDescontinuado.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 156);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 61;
            label6.Text = "Descontinuado";
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 379);
            Controls.Add(label6);
            Controls.Add(cmbDescontinuado);
            Controls.Add(label5);
            Controls.Add(cmbCategoria);
            Controls.Add(mtbNivelReorder);
            Controls.Add(label4);
            Controls.Add(mtbUnOnOrder);
            Controls.Add(label11);
            Controls.Add(mtbPrecio);
            Controls.Add(mtbSuppID);
            Controls.Add(btnCancelar);
            Controls.Add(mtbUnInv);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(txtUnidadxCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombreProduct);
            Controls.Add(btnAceptar);
            Name = "FrmAddProduct";
            Text = "Agregar Producto";
            Load += FrmAddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private MaskedTextBox mtbUnInv;
        private Label label9;
        private Label label10;
        private Label label3;
        private TextBox txtUnidadxCantidad;
        private Label label2;
        private Label label1;
        private TextBox txtNombreProduct;
        private Button btnAceptar;
        private MaskedTextBox mtbSuppID;
        private MaskedTextBox mtbPrecio;
        private MaskedTextBox mtbUnOnOrder;
        private Label label11;
        private MaskedTextBox mtbNivelReorder;
        private Label label4;
        private ComboBox cmbCategoria;
        private Label label5;
        private ComboBox cmbDescontinuado;
        private Label label6;
    }
}