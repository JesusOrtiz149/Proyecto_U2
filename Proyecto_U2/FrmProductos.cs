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
        Datos dt = new Datos();
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void Productos_FormClosed(Object sender, FormClosedEventArgs e)
        {
            cargarDatosProducts();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            //frmAddProduct.FormClosed += Productos_FormClosed;
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

        /*private void FrmProductos_Load(object sender, EventArgs e)
        {

            cargarDatosProducts();
        }*/
        /*public void cargarDatosProducts()
        {
            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Products");
            if (ds != null)
            {
                dgvProducts.DataSource = ds.Tables[0];
            }
        }*/

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                FrmAddProduct edit = new FrmAddProduct(
                    dgvProducts[0, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[1, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[2, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[3, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[4, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[5, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[6, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[7, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[8, dgvProducts.SelectedRows[0].Index].Value.ToString(),
                    dgvProducts[9, dgvProducts.SelectedRows[0].Index].Value.ToString());
                edit.ShowDialog();
           //     cargarDatosProducts();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string x = dgvProducts[0, dgvProducts.SelectedRows[0].Index].Value.ToString();

            // Confirmar eliminación
            if (MessageBox.Show("¿Deseas eliminar a " +
                dgvProducts[1, dgvProducts.SelectedRows[0].Index].Value.ToString() + "?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string consulta = "DELETE FROM Products WHERE ProductID = @ProductID";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@ProductID", x }
                };

                bool s = dt.ejecutarABCModificado(consulta, parametros);

                if (s)
                {
                    MessageBox.Show("Registro eliminado con éxito.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargarDatosProducts();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}