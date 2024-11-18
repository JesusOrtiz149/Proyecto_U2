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
    public partial class FrmTerritorios : Form
    {
        public FrmTerritorios()
        {
            InitializeComponent();
        }

        private void btnNuevoTerritory_Click(object sender, EventArgs e)
        {
            FrmAddTerritory frmAddTerritory = new FrmAddTerritory();
            frmAddTerritory.ShowDialog();
        }
    }
}
