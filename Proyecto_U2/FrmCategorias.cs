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
    public partial class FrmCategorias : Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            cargarDatosCategories();
        }
        public void cargarDatosCategories()
        {
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Categories");

            if (ds != null)
            {
                dgvCategories.DataSource = ds.Tables[0];

                // dgvCategories.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
