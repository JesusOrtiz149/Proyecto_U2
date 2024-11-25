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
        public FrmEmbarcaderos()
        {
            InitializeComponent();
        }
        public void CargarEmbarca()
        {

        }
        private void btnNuevoEmbarcadero_Click(object sender, EventArgs e)
        {
            FrmAddShippers frmAddShippers = new FrmAddShippers();
            frmAddShippers.ShowDialog();
        }

        private void FrmEmbarcaderos_Load(object sender, EventArgs e)
        {

        }
    }
}
