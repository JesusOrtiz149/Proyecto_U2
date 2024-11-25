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
    public partial class FrmVerTerri : Form
    {
        public FrmVerTerri()
        {
            InitializeComponent();
        }
        public void CargarTerritorios()
        {
            Datos dt = new Datos();

            string query = @"
            SELECT t.TerritoryID, t.TerritoryDescription, r.RegionDescription
            FROM Territories t
            INNER JOIN Region r ON t.RegionID = r.RegionID";

            DataSet ds = dt.ejecutarConsulta(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                dtgTerri.DataSource = ds.Tables[0];
            }
            else
            {
                dtgTerri.DataSource = null;
                MessageBox.Show("No hay territorios disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmVerTerri_Load(object sender, EventArgs e)
        {
            CargarTerritorios();
            CargarRegion();
        }
        public void CargarRegion()
        {
            Datos dt = new Datos();

            string query = @"
            SELECT RegionID, RegionDescription 
            FROM Region 
            ORDER BY RegionDescription";

            DataSet ds = dt.ejecutarConsulta(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                cmbRegion.DataSource = ds.Tables[0];
                cmbRegion.DisplayMember = "RegionDescription";
                cmbRegion.ValueMember = "RegionID";
                cmbRegion.SelectedIndex = -1; 
            }
            else
            {
                cmbRegion.DataSource = null;
                MessageBox.Show("No se encontraron regiones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }
        public void CargarTerritorios(int? regionID = null)
        {
            Datos dt = new Datos();

            string query = @"
            SELECT t.TerritoryID, t.TerritoryDescription, r.RegionDescription
            FROM Territories t
            INNER JOIN Region r ON t.RegionID = r.RegionID";

            if (regionID.HasValue)
            {
                query += " WHERE r.RegionID = @RegionID";
            }

            DataSet ds = dt.ejecutarConsultaConParametros(query, new Dictionary<string, object>
            {
                { "@RegionID", regionID }
            });

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                dtgTerri.DataSource = ds.Tables[0];
            }
            else
            {
                dtgTerri.DataSource = null;
                MessageBox.Show("No hay territorios disponibles para esta región.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegion.SelectedValue != null && int.TryParse(cmbRegion.SelectedValue.ToString(), out int regionID))
            {
                CargarTerritorios(regionID); 
            }
            else
            {
                CargarTerritorios(); 
            }
        }
    }
}
