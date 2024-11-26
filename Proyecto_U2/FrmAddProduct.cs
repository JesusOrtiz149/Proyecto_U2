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
        bool bandera = false;
        int idProducto;
        int cmbIntCategoria;
        FrmProductos productos = new FrmProductos();

        public FrmAddProduct()
        {
            InitializeComponent();
        }    
        public FrmAddProduct(string ProductID, string NombreProducto, string supplierID,string categoryID,
                            string unidadxCantidad, string unidadPrecio, string unidadStock,
                            string unidadSobPedido, string nivelPedidos, string descontinuado)
        {
             
            InitializeComponent();
            poblarComboCategory();

            cmbIntCategoria = Convert.ToInt32(categoryID);
            this.idProducto = Convert.ToInt32(ProductID);
            txtNombreProduct.Text = NombreProducto;
            mtbSuppID.Text = supplierID;
            cmbCategoria.SelectedIndex = cmbIntCategoria - 1 >= 0 ? cmbIntCategoria - 1 : 0;
            txtUnidadxCantidad.Text = unidadxCantidad;
            mtbPrecio.Text = unidadPrecio;
            mtbUnInv.Text = unidadStock;
            mtbUnOnOrder.Text = unidadSobPedido;
            mtbNivelReorder.Text = nivelPedidos;
            cmbDescontinuado.SelectedIndex = descontinuado == "1" ? 1 : 0;
            bandera = true;

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
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (MessageBox.Show("¿Los datos son correctos?", "Products",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {
                    //MessageBox.Show("descontinuado "+Convert.ToInt32(cmbDescontinuado.SelectedValue).ToString());
                    // MessageBox.Show(Convert.ToInt32(cmbCategoria.SelectedValue).ToString());
                    string consultaUpdate = @"UPDATE Products 
                                      SET ProductName = @ProductName, 
                                          SupplierID = @SupplierID, 
                                          CategoryID = @CategoryID, 
                                          QuantityPerUnit = @QuantityPerUnit, 
                                          UnitPrice = @UnitPrice, 
                                          UnitsInStock = @UnitsInStock, 
                                          UnitsOnOrder = @UnitsOnOrder, 
                                          ReorderLevel = @ReorderLevel, 
                                          Discontinued = @Discontinued
                                      WHERE ProductID = @ProductID";

                    /* bool j = dt.ejecutarABC("Update Products Set " +
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
                         );*/
                    parametros.Add("@ProductID", idProducto);
                    parametros.Add("@ProductName", txtNombreProduct.Text);

                    if (!int.TryParse(mtbSuppID.Text, out int supplierID))
                    {
                        MessageBox.Show("Por favor ingrese un SupplierID válido.");
                        return;
                    }
                    parametros.Add("@SupplierID", Convert.ToInt32(mtbSuppID.Text));
                    parametros.Add("@CategoryID", Convert.ToInt32((cmbCategoria.SelectedIndex+1)));
                    parametros.Add("@QuantityPerUnit", txtUnidadxCantidad.Text);

                    if (!decimal.TryParse(mtbPrecio.Text, out decimal unitPrice))
                    {
                        MessageBox.Show("Por favor ingrese un precio válido.");
                        return;
                    }

                    parametros.Add("@UnitPrice", Convert.ToDecimal(mtbPrecio.Text));
                    parametros.Add("@UnitsInStock", Convert.ToInt32(mtbUnInv.Text));
                    parametros.Add("@UnitsOnOrder", Convert.ToInt32(mtbUnOnOrder.Text));
                    parametros.Add("@ReorderLevel", Convert.ToInt32(mtbNivelReorder.Text));
                    parametros.Add("Discontinued", cmbDescontinuado.SelectedIndex);

                    bool j = dt.ejecutarABCModificado(consultaUpdate,parametros);

                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Products",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar", "Products", MessageBoxButtons.OK,
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
                        productos.CargarDatosP();
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
