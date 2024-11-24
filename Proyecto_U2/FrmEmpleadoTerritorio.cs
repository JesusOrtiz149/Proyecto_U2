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
    public partial class FrmEmpleadoTerritorio : Form
    {
        public FrmEmpleadoTerritorio()
        {
            InitializeComponent();
        }

        private void FrmEmpleadoTerritorio_Load(object sender, EventArgs e)
        {
            cargarDatosEmpT();
        }
        public void cargarDatosEmpT()
        {

            dgvEmployeeTerritories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeTerritories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            Datos dt = new Datos();
            DataSet ds;
            string consulta = "Select Territories.TerritoryID, TerritoryDescription, Employees.EmployeeID, LastName, FirstName\r\nfrom EmployeeTerritories\r\nJOIN Employees ON EmployeeTerritories.EmployeeID = Employees.EmployeeID \r\njoin Territories ON Territories.TerritoryID = EmployeeTerritories.TerritoryID";
            ds = dt.ejecutarConsulta(consulta);

            if (ds != null)
            {
                dgvEmployeeTerritories.DataSource = ds.Tables[0];
                //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }


    }
}
