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
        Datos dt = new Datos();
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvEmployeeTerritories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string x = dgvEmployeeTerritories[0, dgvEmployeeTerritories.SelectedRows[0].Index].Value.ToString();

            // Confirmar eliminación
            if (MessageBox.Show("¿Deseas eliminar a " +
                dgvEmployeeTerritories[1, dgvEmployeeTerritories.SelectedRows[0].Index].Value.ToString() + "?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string consulta = "DELETE FROM EmployeeTerritories WHERE TerritoryID = @TerritoryID";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@TerritoryID", x }
                };

                bool s = dt.ejecutarABCModificado(consulta, parametros);

                if (s)
                {
                    MessageBox.Show("Registro eliminado con éxito.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargarDatosEmpT();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
