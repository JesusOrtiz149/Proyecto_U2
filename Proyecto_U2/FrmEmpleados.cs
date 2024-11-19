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
        DataSet ds;
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
            frmAddEmployee.ShowDialog();

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            cargarDatos1("Select * From Employees");
        }
        public void cargarDatos1(String comando)
        {
            Datos dt = new Datos();
            ds = dt.ejecutarConsulta(comando);
            if (ds != null)
            {
                dgvEmployees.DataSource = ds.Tables[0];
            }
        }

    }
}
