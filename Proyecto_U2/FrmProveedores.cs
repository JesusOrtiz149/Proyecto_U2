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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }
        public void CargarProv()
        {
            Datos dt = new Datos();
            DataSet ds = dt.ejecutarConsulta("SELECT * FROM Suppliers");
            if (ds != null)
            {
                dgvSuppliers.DataSource = ds.Tables[0];
            }
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmAddSupplier frmAddSupplier = new FrmAddSupplier();
            frmAddSupplier.ShowDialog();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarProv();
        }
    }


}
