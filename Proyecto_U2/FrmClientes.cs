using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_U2
{
    public partial class FrmClientes : Form
    {
        Datos dt = new Datos();
        DataSet ds;
        public FrmClientes()
        {
            InitializeComponent();
            cargarDatosCustomers("Select * From Customers");
        }

        public void cargarDatosCustomers(String comando)
        {
            Datos dt = new Datos();
            ds = dt.ejecutarConsulta(comando);
            if (ds != null)
            {
                dtgCustomers.DataSource = ds.Tables[0];
            }

        }
        private void Customers_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarDatosCustomers("Select * From Customers");
        }


        private void btnNuevoCustomer_Click(object sender, EventArgs e)
        {
            FrmAddCustomers customers = new FrmAddCustomers();
            customers.FormClosed += Customers_FormClosed;
            customers.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string x = dtgCustomers[0, dtgCustomers.SelectedRows[0].Index].Value.ToString();
            //dtgCustomers[0]

            if (MessageBox.Show("Deseas Eliminar a " +
                dtgCustomers[1, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                "Sistema",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                MessageBox.Show(x + " lol");
                bool s = dt.ejecutarABC("Delete from Customers Where CustomerID = '" + x + "'");
                if (s)
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //eliminarToolStripMenuItem.Click += new EventHandler(eliminarToolStripMenuItem_Click);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dtgCustomers.SelectedRows.Count > 0)
            {
                FrmAddCustomers edit = new FrmAddCustomers(
                    dtgCustomers[0, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[1, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[2, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[3, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[4, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[5, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[6, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[7, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[8, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[9, dtgCustomers.SelectedRows[0].Index].Value.ToString(),
                    dtgCustomers[10, dtgCustomers.SelectedRows[0].Index].Value.ToString());
                edit.ShowDialog();
                cargarDatosCustomers("Select * From Customers");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
