using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_U2
{
    public partial class FrmAddProduct : Form
    {
        Datos dt = new Datos();
        bool bandera;
        int productID;
        FrmProductos productos = new FrmProductos();
        public FrmAddProduct()
        {
            InitializeComponent();
        }    
        public FrmAddProduct(int ProductID, string NombreProducto, int supplierID, int categoryID,
                            string unidadxCantidad, double unidadPrecio, int unidadStock,
                            int unidadSobPedido, int nivelPedidos, int descontinuado)
        {

            InitializeComponent();
            poblarComboCategory();
           // int checkdesc = chkDescotinuado.Checked ? 1 : 0;
            this.productID = ProductID;
            txtNombreProduct.Text = NombreProducto;
            mtbSuppID.Text = supplierID.ToString();
            cmbCategoria.SelectedIndex = categoryID;
            txtUnidadxCantidad.Text = unidadxCantidad;
            mtbPrecio.Text = unidadPrecio.ToString();
            mtbUnInv.Text = unidadStock.ToString();
            mtbUnOnOrder.Text = unidadSobPedido.ToString();
            mtbNivelReorder.Text = nivelPedidos.ToString();
            cmbDescontinuado.Text = descontinuado.ToString();

        }
        public void poblarComboCategory()
        {
            try
            {
                string consulta = "Select CategoryName from Categories";
                DataSet ds;
                ds = dt.ejecutarConsulta(consulta);

                if (ds != null && ds.Tables.Count > 0)
                {
                    // Limpia el ComboBox antes de llenarlo
                    cmbCategoria.Items.Clear();

                    // Itera sobre los datos y los agrega al ComboBox
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        cmbCategoria.Items.Add(row[0].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para llenar el ComboBox.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Products",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {           

                    bool j = dt.ejecutarABC("Update Products Set " +
                        "                           ProductName = '" + txtNombreProduct.Text +
                                                "', SupplierID = '" + mtbSuppID.Text +
                                                "', CateogryID = '" + cmbCategoria.SelectedIndex+1 +
                                                "', QuantityPerUnit = '" +  txtUnidadxCantidad.Text +
                                                "', UnitPrice = '" + mtbPrecio.Text +
                                                "', UnitsInStock = '" + mtbUnInv.Text +
                                                "', UnitsOnOrder  = '" + mtbUnOnOrder.Text +
                                                "', ReorderLevel = '" + mtbNivelReorder.Text +
                                                "', Discontinued = '" + cmbDescontinuado.SelectedIndex +
                        " Where ProductID = '" + productID + "'"
                        );

                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Products",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Error", "Products", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //try
                    //{
                    //MessageBox.Show(calcularID(txtNombreCompany.Text));
                    
                    bool j = dt.ejecutarABC("Insert Into Products (ProductName, SupplierID, CategoryID, QuantityPerUnit" +
                                             ",UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) " +
                                                     "Values ('" + txtNombreProduct.Text + "'," 
                                                        + int.Parse(mtbSuppID.Text) + "," 
                                                        + (cmbCategoria.SelectedIndex+1) + ",'" 
                                                        + txtUnidadxCantidad.Text + "'," 
                                                        + double.Parse(mtbPrecio.Text) + "," 
                                                        + int.Parse(mtbUnInv.Text) + "," 
                                                        + int.Parse(mtbUnOnOrder.Text) + "," 
                                                        + int.Parse(mtbNivelReorder.Text) + "," 
                                                        + cmbDescontinuado.SelectedIndex + ")");

                    if (j == true)
                    {
                        MessageBox.Show("Producto añadido", "Products",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        productos.cargarDatosProducts();
                        mtbSuppID.Clear();
                        txtNombreProduct.Clear();
                        mtbUnInv.Clear();
                        txtUnidadxCantidad.Clear();
                        mtbPrecio.Clear();
                        mtbUnOnOrder.Clear();
                        mtbNivelReorder.Clear();
                        cmbCategoria.Items.Clear();
                        cmbDescontinuado.Items.Clear(); 

                    }
                    else
                    {
                        MessageBox.Show("Error", "Products", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    /*}catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                   }*/
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            poblarComboCategory();
        }
    }
}
