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
        DataSet ds;
        public FrmTerritorios()
        {
            InitializeComponent();
        }

        private void btnNuevoTerritory_Click(object sender, EventArgs e)
        {
            FrmAddTerritory frmAddTerritory = new FrmAddTerritory();
            frmAddTerritory.ShowDialog();
        }

        private void FrmTerritorios_Load(object sender, EventArgs e)
        {
            cargarDatos("Select * From Territories");
        }

        public void cargarDatos(String comando)
        {
            Datos dt = new Datos();
            ds = dt.ejecutarConsulta(comando);
            if (ds != null)
            {
                dtgTerritory.DataSource = ds.Tables[0];
            }
        }
    }
}
