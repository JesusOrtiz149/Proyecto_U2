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

namespace Proyecto_U2
{
    public partial class FrmAddOrder : Form
    {
        private List<Product> carrito = new List<Product>();
        private decimal total = 0;
        private int orderId = 0;
        public FrmAddOrder()
        {
            InitializeComponent();
        }



        private void FrmAddOrder_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            btnAgrOrder.Enabled = false;

            using (SqlConnection conn = new SqlConnection(/*"Data Source = LAPTOP-9P0KPF56\\SQLEXPRESS04;Integrated Security=true;Initial Catalog = Northwind"*/@"Data Source = DESKTOP-3KGVR4J\SQLEXPRESS;Integrated Security=true;Initial Catalog = Northwind"))
            {
                conn.Open();


                SqlCommand cmd = new SqlCommand("SELECT ProductID, ProductName, UnitPrice ,UnitsInStock,UnitsOnOrder FROM Products", conn);
                SqlDataReader reader = cmd.ExecuteReader();


                List<Product> productos = new List<Product>();

                while (reader.Read())
                {
                    productos.Add(new Product
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        UnitPrice = reader.GetDecimal(2)
                    });
                }


                cmbProductos.DataSource = productos;
                cmbProductos.DisplayMember = "ProductName";
                cmbProductos.ValueMember = "ProductID";

                
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            orderId = random.Next(1000, 9999);
            lblOrder.Text = $"OrdenID: {orderId}";
            btnAgregar.Enabled = true;
            btnAgrOrder.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (orderId == 0)
            {
                MessageBox.Show("Por favor, genera un número de orden antes de continuar.");
                return;
            }
            if (cmbProductos.SelectedItem != null)
            {
                Product selectedProduct = (Product)cmbProductos.SelectedItem;


                MessageBox.Show($"Producto seleccionado: {selectedProduct.ProductName}\nPrecio: {selectedProduct.UnitPrice:C}");
            }

            if (cmbProductos.SelectedItem != null)
            {
                Product selectedProduct = (Product)cmbProductos.SelectedItem;


                var productoEnCarrito = carrito.Find(p => p.ProductID == selectedProduct.ProductID);

                if (productoEnCarrito != null)
                {

                    productoEnCarrito.Quantity++;
                }
                else
                {

                    selectedProduct.Quantity = 1;
                    carrito.Add(selectedProduct);
                }


                dtgCarrito.DataSource = null;
                dtgCarrito.DataSource = carrito;


                total += selectedProduct.UnitPrice;
                lblTotal.Text = $"Total: {total:C}";
            }
            
            else
            {
                MessageBox.Show("Por favor, selecciona un producto.");
            }
            }

        private void btnAgrOrder_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source = LAPTOP-9P0KPF56\\SQLEXPRESS04;Integrated Security=true;Initial Catalog = Northwind"))
            {
                conn.Open();

                
                SqlCommand cmdOrder = new SqlCommand(
                    "INSERT INTO Orders (OrderDate) VALUES (@OrderDate); SELECT SCOPE_IDENTITY();", conn);
                cmdOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);

                int orderId = Convert.ToInt32(cmdOrder.ExecuteScalar());

                
               

                foreach (var product in carrito)
                {
                    SqlCommand cmdDetail = new SqlCommand(
                        "INSERT INTO [Order Details] ([OrderID], [ProductID], [Quantity], [UnitPrice]) " +
                        "VALUES (@OrderID, @ProductID, @Quantity, @UnitPrice)", conn);

                    cmdDetail.Parameters.AddWithValue("@OrderID", orderId);
                    cmdDetail.Parameters.AddWithValue("@ProductID", product.ProductID);
                    cmdDetail.Parameters.AddWithValue("@Quantity", product.Quantity);
                    cmdDetail.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);

                    cmdDetail.ExecuteNonQuery();
                }

                
                SqlCommand cmdSearchOrder = new SqlCommand(
                    "SELECT * FROM Orders WHERE OrderID = @OrderID", conn);
                cmdSearchOrder.Parameters.AddWithValue("@OrderID", orderId);

                SqlDataReader reader = cmdSearchOrder.ExecuteReader();

                if (reader.Read())
                {
                    DateTime orderDate = reader.GetDateTime(reader.GetOrdinal("OrderDate"));
                    MessageBox.Show($"Orden ID: {orderId}\nFecha de la Orden: {orderDate}");
                }
                else
                {
                    MessageBox.Show("No se encontró la orden.");
                }
            }


            MessageBox.Show("Orden agregada correctamente.");

            
            carrito.Clear();
            dtgCarrito.DataSource = null;
            lblTotal.Text = "Total: $0.00";
        }




        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem != null)
            {
                Product selectedProduct = (Product)cmbProductos.SelectedItem;
                //MessageBox.Show($"Producto seleccionado: {selectedProduct.ProductName}\nPrecio: {selectedProduct.UnitPrice:C}");
            }
        }
    }
}
