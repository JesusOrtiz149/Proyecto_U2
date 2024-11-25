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
        private int employeeID;

        public FrmTerritorios(int employeeID)
        {
            InitializeComponent();
            this.employeeID = employeeID;
        }

        public void CargarTerri()
        {
            Datos dt = new Datos();


            string query = $@"
            SELECT t.TerritoryID, t.TerritoryDescription
            FROM EmployeeTerritories et
            INNER JOIN Territories t ON et.TerritoryID = t.TerritoryID
            WHERE et.EmployeeID = {employeeID}";

            DataSet ds = dt.ejecutarConsulta(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                dtgTerritory.DataSource = ds.Tables[0];
            }
            else
            {
                dtgTerritory.DataSource = null;
                MessageBox.Show("Este empleado no tiene territorios asignados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void CargarNombreEmpleado()
        {
            Datos dt = new Datos();

            string query = $@"
        SELECT FirstName, LastName
        FROM Employees
        WHERE EmployeeID = {employeeID}";

            DataSet ds = dt.ejecutarConsulta(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string firstName = ds.Tables[0].Rows[0]["FirstName"].ToString();
                string lastName = ds.Tables[0].Rows[0]["LastName"].ToString();

                lblEmployee.Text = $"Empleado:\n {firstName} {lastName}";
            }
            else
            {
                lblEmployee.Text = "Empleado no encontrado";
            }
        }

        private void FrmTerritorios_Load(object sender, EventArgs e)
        {
            CargarTerri();
            CargarNombreEmpleado();
            if (employeeID == 2)
            {
                btnTerri.Visible = true;
            }
            else
            {
                btnTerri.Visible = false;
            }
        }

        private void btnNuevoTerritory_Click(object sender, EventArgs e)
        {
            FrmAddTerritory frmAddTerritory = new FrmAddTerritory();
            frmAddTerritory.ShowDialog();
        }

        private void btnTerri_Click(object sender, EventArgs e)
        {
           FrmVerTerri frmVerTerri = new FrmVerTerri();
            frmVerTerri.ShowDialog();
                
        }
    }
}
