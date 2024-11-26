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
    public partial class FrmEmbarcaderos : Form
    {
        DataSet ds;
        Datos dt = new Datos();
        public FrmEmbarcaderos()
        {
            InitializeComponent();
        }

        private void Shippers_FormClosed(Object sender, FormClosedEventArgs e)
        {
            cargarDatosShippers();
        }

        public void cargarDatosShippers()
        {
            dgvShippers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvShippers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Shippers");

            if (ds != null)
            {
                dgvShippers.DataSource = ds.Tables[0];
                //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvShippers.SelectedRows.Count > 0)
            {
                FrmAddShippers edit = new FrmAddShippers(
                    dgvShippers[0, dgvShippers.SelectedRows[0].Index].Value.ToString(),
                    dgvShippers[1, dgvShippers.SelectedRows[0].Index].Value.ToString(),
                    dgvShippers[2, dgvShippers.SelectedRows[0].Index].Value.ToString());
                edit.ShowDialog();
                cargarDatosShippers();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvShippers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string x = dgvShippers[0, dgvShippers.SelectedRows[0].Index].Value.ToString();

            // Confirmar eliminación
            if (MessageBox.Show("¿Deseas eliminar a " +
                dgvShippers[1, dgvShippers.SelectedRows[0].Index].Value.ToString() + "?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string consulta = "DELETE FROM Shippers WHERE ShipperID = @ShipperID";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@ShipperID", x }
                };

                bool s = dt.ejecutarABCModificado(consulta, parametros);

                if (s)
                {
                    MessageBox.Show("Registro eliminado con éxito.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                   // cargarDatosShippers();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevoEmbarcadero_Click(object sender, EventArgs e)
        {
            FrmAddShippers frmAddShippers = new FrmAddShippers();
            //frmAddShippers.FormClosed += Shippers_FormClosed;
            frmAddShippers.ShowDialog();
        }

        private void FrmEmbarcaderos_Load(object sender, EventArgs e)
        {
            cargarDatosShippers();
        }
    }



    /* private void btnNuevoEmbarcadero_Click(object sender, EventArgs e)
     {
         FrmAddShippers frmAddShippers = new FrmAddShippers();
         //frmAddShippers.FormClosed += Shippers_FormClosed;
         frmAddShippers.ShowDialog();
     }*/



  /*  private void FrmEmbarcaderos_Load(object sender, EventArgs e)
    {
        cargarDatosShippers();
    }*/

    /*public void cargarDatosShippers()
    {
        dgvShippers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dgvShippers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        Datos dt = new Datos();
        DataSet ds;
        ds = dt.ejecutarConsulta("Select * from Shippers");

        if (ds != null)
        {
            dgvShippers.DataSource = ds.Tables[0];
            //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
        }
    }*/


 /*   private void editarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (dgvShippers.SelectedRows.Count > 0)
        {
            FrmAddShippers edit = new FrmAddShippers(
                dgvShippers[0, dgvShippers.SelectedRows[0].Index].Value.ToString(),
                dgvShippers[1, dgvShippers.SelectedRows[0].Index].Value.ToString(),
                dgvShippers[2, dgvShippers.SelectedRows[0].Index].Value.ToString());
            edit.ShowDialog();
            cargarDatosShippers();
        }
        else
        {
            MessageBox.Show("Debe seleccionar un registro", "Sistema", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }
    }*/

   /* private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (dgvShippers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        string x = dgvShippers[0, dgvShippers.SelectedRows[0].Index].Value.ToString();

        // Confirmar eliminación
        if (MessageBox.Show("¿Deseas eliminar a " +
            dgvShippers[1, dgvShippers.SelectedRows[0].Index].Value.ToString() + "?",
            "Confirmar eliminación",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
        {

            string consulta = "DELETE FROM Shippers WHERE ShipperID = @ShipperID";

            Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@ShipperID", x }
                };

            bool s = dt.ejecutarABCModificado(consulta, parametros);

            if (s)
            {
                MessageBox.Show("Registro eliminado con éxito.", "Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarDatosShippers();
            }
            else
            {
                MessageBox.Show("Error al eliminar el registro.", "Sistema",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }*/
}
