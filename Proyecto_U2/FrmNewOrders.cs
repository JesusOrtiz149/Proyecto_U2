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
    public partial class FrmNewOrders : Form
    {
        public FrmNewOrders()
        {
            InitializeComponent();
        }

        private void FrmNewOrders_Load(object sender, EventArgs e)
        {
            dtgNewOrders.DataSource = FrmAddOrder.orders;
        }
    }
}
