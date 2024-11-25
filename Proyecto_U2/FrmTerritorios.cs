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
        Datos dt = new Datos();
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

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgTerritory.SelectedRows.Count > 0)
            {
                FrmAddTerritory edit = new FrmAddTerritory(
                    dtgTerritory[0, dtgTerritory.SelectedRows[0].Index].Value.ToString(),
                    dtgTerritory[1, dtgTerritory.SelectedRows[0].Index].Value.ToString(),
                    dtgTerritory[2, dtgTerritory.SelectedRows[0].Index].Value.ToString());
                edit.ShowDialog();
                cargarDatos("Select * From Territories"); 
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgTerritory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string x = dtgTerritory[0, dtgTerritory.SelectedRows[0].Index].Value.ToString();

            // Confirmar eliminación
            if (MessageBox.Show("¿Deseas eliminar a " +
                dtgTerritory[1, dtgTerritory.SelectedRows[0].Index].Value.ToString() + "?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string consulta = "DELETE FROM Territories WHERE TerritoryID = @TerritoryID";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@TerritoryID", x }
                };

                bool s = dt.ejecutarABCModificado(consulta, parametros);

                if (s)
                {
                    MessageBox.Show("Registro eliminado con éxito.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargarDatos("Select * from Territories");
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
