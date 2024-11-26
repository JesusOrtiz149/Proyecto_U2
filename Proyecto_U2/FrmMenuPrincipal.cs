using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_U2
{
    using System;
    using System.Windows.Forms;

    public partial class FrmMenuPrincipal : Form
    {
        private string role; 
        private string userName;
        

        public FrmMenuPrincipal()
        {
            InitializeComponent();

         
            this.role = UserSession.Role;
            this.userName = UserSession.UserName;

            ConfigurarMenu();
        }

        private void ConfigurarMenu()
        {

            archivoToolStripMenuItem.Visible = false;
            salirToolStripMenuItem.Visible = false;

            btnMostrar.Visible = false;
            btnClientes.Visible = false;
            btnSuppliers.Visible = false;
            btnEmpleados.Visible = false;
            btnEmbarca.Visible = false;
            btnTerritorios.Visible = false;


            switch (role)
            {
                case "admin":
                    archivoToolStripMenuItem.Visible = true;
                    salirToolStripMenuItem.Visible = true;
                    btnMostrar.Visible = true;
                    btnClientes.Visible = true;
                    btnSuppliers.Visible = true;
                    btnEmpleados.Visible = true;
                    btnEmbarca.Visible = true;
                    btnTerritorios.Visible = true;
                    break;

                case "Sales Representative":
                    btnMostrar.Visible = true;
                    btnEmpleados.Visible = true;
                    btnTerritorios.Visible = true;
                    archivoToolStripMenuItem.Visible = true;
                    salirToolStripMenuItem.Visible = true;
                    //add
                    btnClientes.Visible= true;
                    btnSuppliers.Visible= true;
                    btnEmbarca.Visible= true;
                    btnProductos.Visible = true;
                    
                    break;

                case "Sales Manager":
                    archivoToolStripMenuItem.Visible = true;
                    salirToolStripMenuItem.Visible = true;
                    btnMostrar.Visible = true;
                    btnClientes.Visible = true;
                    btnTerritorios.Visible = true;
                    break;

                case "Inside Sales Coordinator":
                    archivoToolStripMenuItem.Visible = true;
                    salirToolStripMenuItem.Visible = true;
                    btnMostrar.Visible = true;
                    btnClientes.Visible = true;
                    btnSuppliers.Visible = false; // Opcional, según requisitos
                    btnTerritorios.Visible = true;
                    break;

                case "Proveedor":
                    archivoToolStripMenuItem.Visible = true;
                    salirToolStripMenuItem.Visible = true;
                    btnMostrar.Visible = true;
                    btnSuppliers.Visible = true;
                    break;

                case "Cliente":
                    archivoToolStripMenuItem.Visible = true;
                    salirToolStripMenuItem.Visible = true;
                    btnMostrar.Visible = true;
                    
                    break;

                default:
                    MessageBox.Show("Acceso restringido. Rol no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
        }

            private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {

            FrmOrdenes frmorder = new FrmOrdenes();
            frmorder.Show();
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show();
        }

        private void btnEmbarca_Click(object sender, EventArgs e)
        {
            FrmEmbarcaderos frmEmbarcaderos = new FrmEmbarcaderos();
            frmEmbarcaderos.Show();
        }


        private void btnTerritorios_Click(object sender, EventArgs e)
        {
            int employeeID = UserSession.EmployeeID;
            FrmTerritorios frmTerritorios = new FrmTerritorios(employeeID);
            frmTerritorios.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
        }
    }
}