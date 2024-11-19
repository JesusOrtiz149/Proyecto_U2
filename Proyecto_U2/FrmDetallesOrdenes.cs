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
    public partial class FrmDetallesOrdenes : Form
    {
        public FrmDetallesOrdenes()
        {
            InitializeComponent();
        }

        private void FrmDetallesOrdenes_Load(object sender, EventArgs e)
        {
            cargarDatosOrderDetails();
        }
        public void cargarDatosOrderDetails()
        {
            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from [Order Details]");
            if (ds != null)
            {
                dgvOrderDetails.DataSource = ds.Tables[0];
            }
        }
    }
}
