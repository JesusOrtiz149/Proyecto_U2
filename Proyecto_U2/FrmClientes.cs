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
    public partial class FrmClientes : Form
    {
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
    }
}
