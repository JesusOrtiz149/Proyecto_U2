using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_U2
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            frmAddProduct.ShowDialog();
        }
        public void CargarDatosP()
        {
            Datos dt = new Datos();
            DataSet ds = dt.ejecutarConsulta("SELECT * FROM Products");
            if (ds != null)
            {
                dgvProducts.DataSource = ds.Tables[0];
            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDatosP();
            cargarSupplierID();
            if (cmbSuppliers.SelectedValue != null)
            {
                int selectedSupplierID = Convert.ToInt32(cmbSuppliers.SelectedValue);
            }
        }
        public void cargarNombreProducto(int SupplierID)
        {
            Datos dt = new Datos();
            string query = $@"
        SELECT STRING_AGG(ProductName, ', ') AS FullName 
        FROM Products 
        WHERE SupplierID = {SupplierID}";

            DataSet ds = dt.ejecutarConsulta(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0 && !string.IsNullOrEmpty(ds.Tables[0].Rows[0]["FullName"].ToString()))
            {
              
                txtProName.Text = ds.Tables[0].Rows[0]["FullName"].ToString();
            }
            else
            {
                txtProName.Text = "Producto no encontrado";
            }
        }

        public void cargarSupplierID()
        {
            Datos dt = new Datos();
            DataSet ds = dt.ejecutarConsulta("SELECT DISTINCT SupplierID FROM Products ORDER BY SupplierID");
            if (ds != null)
            {
                cmbSuppliers.DisplayMember = "SupplierID";
                cmbSuppliers.ValueMember = "SupplierID";
                cmbSuppliers.DataSource = ds.Tables[0];
            }
        }
        public void cargarSupplierID(int SupplierID)
        {
            Datos dt = new Datos();
            string query = $"SELECT * FROM Products WHERE SupplierID = {SupplierID}";
            DataSet ds = dt.ejecutarConsulta(query);
            if (ds != null)
            {
                dgvProducts.DataSource = ds.Tables[0];
            }
        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedValue != null)
            {
                int selectedSupplierID = Convert.ToInt32(cmbSuppliers.SelectedValue);
                cargarSupplierID(selectedSupplierID);
                cargarNombreProducto(selectedSupplierID);
            }
        }

        private void dgvProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string supplierID = dgvProducts.Rows[e.RowIndex].Cells["SupplierID"].Value.ToString();
                FrmprDetails frmPR = new FrmprDetails(supplierID);
                frmPR.ShowDialog();
           } 
        }
    }
}