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
    public partial class FrmEmbarcaderos : Form
    {
        DataSet ds;
        public FrmEmbarcaderos()
        {
            InitializeComponent();
        }

        private void btnNuevoEmbarcadero_Click(object sender, EventArgs e)
        {
            FrmAddShippers frmAddShippers = new FrmAddShippers();
            frmAddShippers.ShowDialog();
        }



        private void FrmEmbarcaderos_Load(object sender, EventArgs e)
        {
            cargarDatosShippers();
        }

        public void cargarDatosShippers()
        {
            dgvShippers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvShippers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Shippers");

            if (ds != null)
            {
                dgvShippers.DataSource = ds.Tables[0];
                //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }
    }
}
