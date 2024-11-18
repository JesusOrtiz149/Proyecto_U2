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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
            frmAddEmployee.ShowDialog();

        }
    }
}
