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
    public partial class FrmOrdenes : Form
    {
        DataSet ds;
        public FrmOrdenes()
        {
            InitializeComponent();
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            FrmAddOrder frmAddOrder = new FrmAddOrder();
            frmAddOrder.Show();

        }

        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            cargarDatosOrders("Select * From Orders");
        }
        public void cargarDatosOrders(String comando)
        {

            dtgOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            Datos dt = new Datos();
            ds = dt.ejecutarConsulta(comando);
            if (ds != null)
            {
                dtgOrders.DataSource = ds.Tables[0];
            }
        }


    }
}
