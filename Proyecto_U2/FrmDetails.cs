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
    public partial class FrmDetails : Form
    {
        private string orderID;
        private decimal totalSum;

        public FrmDetails(string orderID)
        {
            InitializeComponent();
            this.orderID = orderID;
        }

        private void cargarDetallesOrden()
        {
            string comando = "SELECT Orders.OrderID, Customers.CompanyName " +
                             "FROM Orders " +
                             "INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID " +
                             "WHERE Orders.OrderID = @OrderID";

           
            var parametros = new Dictionary<string, object>
    {
        { "@OrderID", this.orderID }
    };

           
            Datos dt = new Datos();
            DataSet ds = dt.ejecutarConsultaConParametros(comando, parametros); // Pasa la consulta y los parámetros

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string orderIDValue = ds.Tables[0].Rows[0]["OrderID"].ToString();
                string companyNameValue = ds.Tables[0].Rows[0]["CompanyName"].ToString();
                //MessageBox.Show($"Order ID: {orderIDValue}, Company: {companyNameValue}");

                lblOrderID.Text = "OrderID: " + orderIDValue;
                lblCompanyName.Text = "CompanyName: \n"+ companyNameValue;
            }
            else
            {
                MessageBox.Show("No se encontró la orden o el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cargarDatosRelacionados()
        {

            string comando = $"SELECT ProductID, Quantity, UnitPrice, Discount, Total FROM [Order Details] WHERE OrderID = '{this.orderID}'";

            Datos dt = new Datos();
            DataSet ds = dt.ejecutarConsulta(comando);

            if (ds != null)
            {
                dtgDetails.DataSource = ds.Tables[0];


                foreach (DataGridViewRow row in dtgDetails.Rows)
                {
                    if (row.Cells["Quantity"].Value != DBNull.Value &&
                        row.Cells["UnitPrice"].Value != DBNull.Value &&
                        row.Cells["Discount"].Value != DBNull.Value)
                    {
                        decimal quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                        decimal unitPrice = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                        decimal discount = Convert.ToDecimal(row.Cells["Discount"].Value);


                        decimal total = quantity * unitPrice * (1 - discount);
                        row.Cells["Total"].Value = total;
                        totalSum += total;
                    }

                }
            
        

       
        lblTotal.Text = $"Total General: {totalSum:C}";
            }
        }




        private void FrmDetails_Load_1(object sender, EventArgs e)
        {
            cargarDetallesOrden(); 
            cargarDatosRelacionados(); 
        }

        private void dtgDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

