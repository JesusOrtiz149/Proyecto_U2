﻿using System;
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
        public void CargarEmpleados()
        {
            Datos dt = new Datos();
            DataSet ds = dt.ejecutarConsulta("SELECT * FROM Employees");
            if (ds != null)
            {
                dgvEmployees.DataSource = ds.Tables[0];
            }
        }
        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
            frmAddEmployee.ShowDialog();

        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }
    }
}
