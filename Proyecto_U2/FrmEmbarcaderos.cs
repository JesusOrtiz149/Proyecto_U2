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

        private void btnNuevoEmbarcadero_Click(object sender, EventArgs e)
        {
            FrmAddShippers frmAddShippers = new FrmAddShippers();   
            frmAddShippers.ShowDialog();
        }
    }
}
