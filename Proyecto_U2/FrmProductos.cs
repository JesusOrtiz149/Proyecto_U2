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

        private void Productos_FormClosed(Object sender, FormClosedEventArgs e)
        {
            cargarDatosProducts();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmAddProduct frmAddProduct = new FrmAddProduct();
            frmAddProduct.FormClosed += Productos_FormClosed;
            frmAddProduct.ShowDialog();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargarDatosProducts();
        }
        public void cargarDatosProducts()
        {
            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Products");
            if (ds != null)
            {
                dgvProducts.DataSource = ds.Tables[0];
            }
        }




    }
}
