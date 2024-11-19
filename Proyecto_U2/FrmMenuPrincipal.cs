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
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(string contra)
        {
            InitializeComponent();
            ConfigurarMenu(contra);
        }
        //lo que hace es mostrar las opciones del menustrip dependiendo de quién inició sesión
        private void ConfigurarMenu(string contra)
        {
            if (contra == "2")
            {
                // Mostrar todas las opciones porque es el admin
                archivoToolStripMenuItem.Visible = true;
                salirToolStripMenuItem.Visible = true;
                northwindToolStripMenuItem.Visible = true;
                mostrarToolStripMenuItem.Visible = true;
                empleadosToolStripMenuItem.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                proveedoresToolStripMenuItem.Visible = true;
                órdenesToolStripMenuItem.Visible = true;
                detallesDeLasÓrdenesToolStripMenuItem.Visible = true;
                embarcaderosToolStripMenuItem.Visible = true;
                territorioToolStripMenuItem.Visible = true;

            }
            else if (contra == "1" || (int.TryParse(contra, out int passNum) && passNum >= 3 && passNum <= 7))
            {
                // Ocultar Empleados,proveedores, embarcaderos
                archivoToolStripMenuItem.Visible = true;
                salirToolStripMenuItem.Visible = true;
                northwindToolStripMenuItem.Visible = true;
                mostrarToolStripMenuItem.Visible = true;
                empleadosToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = true;
                proveedoresToolStripMenuItem.Visible = false;
                órdenesToolStripMenuItem.Visible = true;
                detallesDeLasÓrdenesToolStripMenuItem.Visible = true;
                productosToolStripMenuItem.Visible = true;
                embarcaderosToolStripMenuItem.Visible = false;
                territorioToolStripMenuItem.Visible = true;

            }
            else
            {
                // Manejo para otras contraseñas (opcional)
                MessageBox.Show("Acceso restringido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mostrar = new Form1();
            mostrar.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmEmpleados = new FrmEmpleados();
            frmEmpleados.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();

        }

        private void órdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenes orders = new FrmOrdenes();
            orders.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();

        }

        private void embarcaderosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmbarcaderos frmEmbarcaderos = new FrmEmbarcaderos();
            frmEmbarcaderos.Show();
        }

        private void territorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTerritorios frmTerritorios = new FrmTerritorios();
            frmTerritorios.Show();

        }

        private void detallesDeLasÓrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetallesOrdenes frmDetallesOrdenes = new FrmDetallesOrdenes();
            frmDetallesOrdenes.Show();
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();  
            frmCategorias.Show();
        }
    }
}
