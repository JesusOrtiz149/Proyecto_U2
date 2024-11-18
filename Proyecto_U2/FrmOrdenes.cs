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
        public FrmOrdenes()
        {
            InitializeComponent();
        }

        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            FrmAddOrder frmAddOrder = new FrmAddOrder();
            frmAddOrder.Show();

        }
    }
}
