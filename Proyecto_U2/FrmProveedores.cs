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
        private void Proveedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarDatosSuppliers();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmAddSupplier frmAddSupplier = new FrmAddSupplier();
            frmAddSupplier.FormClosed += Proveedores_FormClosed;
            frmAddSupplier.ShowDialog();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            cargarDatosSuppliers();
        }
  

        public void cargarDatosSuppliers()
        {
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSuppliers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Suppliers");

            if (ds != null)
            {
                dgvSuppliers.DataSource = ds.Tables[0];
                //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }

    }


}
