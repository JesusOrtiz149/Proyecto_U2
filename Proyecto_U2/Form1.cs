using System.Data;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Proyecto_U2
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos("Select * From Territories");
            cargarDatos1("Select * From Employees");
            cargarDatosCustomers("Select * From Customers");
            cargarDatosOrders("Select * From Orders");
            cargarDatosOrderDetails();
            cargarDatosCategories();
            cargarDatosProducts();
            cargarDatosSuppliers();
            cargarDatosShippers();
            cargarDatosEmpT();
            cargarDatosCustomerDemo();
            cargarDatosCustomerCustomerDemo();


        }
        public void cargarDatos1(String comando)
        {
            Datos dt = new Datos();
            ds = dt.ejecutarConsulta(comando);
            if (ds != null)
            {
                dtgEmployees.DataSource = ds.Tables[0];
            }


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
        public void cargarDatosOrders(String comando)
        {

            dtgOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            Datos dt = new Datos();
            ds = dt.ejecutarConsulta(comando);
            if (ds != null)
            {
                dtgOrders.DataSource = ds.Tables[0];
            }
        }

        public void cargarDatosOrderDetails()
        {
            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from [Order Details]");
            if (ds != null)
            {
                dgvOrderDetails.DataSource = ds.Tables[0];
            }
        }

        public void cargarDatosProducts()
        {
            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Products");
            if (ds != null)
            {
                dgvProducts.DataSource = ds.Tables[0];
            }
        }

        public void cargarDatosCategories()
        {
            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Categories");

            if (ds != null)
            {
                dgvCategories.DataSource = ds.Tables[0];

                // dgvCategories.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }

        private void AjustarTamañoConPreferido()
        {
            dgvCategories.AutoResizeColumns();
            dgvCategories.AutoResizeRows();

            dgvCategories.Width = dgvCategories.PreferredSize.Width;
            dgvCategories.Height = dgvCategories.PreferredSize.Height;
        }


        public void cargarDatosSuppliers()
        {
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSuppliers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Suppliers");

            if (ds != null)
            {
                dgvSuppliers.DataSource = ds.Tables[0];
                //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
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

        public void cargarDatosEmpT()
        {
            dgvEmpT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmpT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from EmployeeTerritories");

            if (ds != null)
            {
                dgvEmpT.DataSource = ds.Tables[0];
                //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }

        public void cargarDatosCustomerDemo()
        {
            dgvCustomerDemographics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomerDemographics.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from CustomerDemographics");

            if (ds != null)
            {
                dgvCustomerDemographics.DataSource = ds.Tables[0];
                //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }
        public void cargarDatosCustomerCustomerDemo()
        {
            dgvCustomerCustomerDemo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomerCustomerDemo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from CustomerCustomerDemo");

            if (ds != null)
            {
                dgvCustomerCustomerDemo.DataSource = ds.Tables[0];
                //dgvSuppliers.DataBindingComplete += dgvCategories_DataBindingComplete;
            }
        }

        public void ajustarCategories()
        {
            // Establece el alto en función de las filas, por ejemplo:
            int alturaFila = dgvCategories.RowTemplate.Height;
            int numFilas = dgvCategories.Rows.Count;
            int margen = dgvCategories.ColumnHeadersHeight;

            dgvCategories.Height = (alturaFila * numFilas) + margen;

        }



        /*public void cargarDatosOrders()
        {
            Datos dt = new Datos();
            DataSet ds;
            ds = dt.ejecutarConsulta("Select * from Orders");
            if (ds != null)
            {
                dgvOrders.DataSource = ds.Tables[0];
            }
        }*/



        private void rbtCiudad_CheckedChanged(object sender, EventArgs e)
        {
            DataTable da;
            Datos dt = new Datos();
            if (rbtCiudad.Checked)
            {
                cmbPais.Enabled = true;
                DataSet ds = dt.ejecutarConsulta("Select City From Employees");
                if (ds != null)
                {
                    da = ds.Tables[0];
                    cmbPais.DataSource = ds.Tables[0];
                    cmbPais.DisplayMember = "City";
                    //cmbPais.ValueMember = "EmployeeID";
                }
                dt.ejecutarConsulta("SELECT   Nortwind.FirstName,Employees.City " +
                    "FROM     Northwind INNER JOIN Employees ON Northwind.EmployeeID =  " +
                    "\r\nWhere Employees.City='"
                    + cmbPais.Text + "'");
            }
            else
            {
                cmbPais.Enabled = false;
            }
        }
        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ME FALTA QUE SE ACOMODE POR CIUDAD ,O SEA QUE CUANDO ELIJAMOS UNA CIUDAD SALGAN EN SOLO LOS DE ESA CIUDAD
            // DEPENDE DE COMO LO VEAS TU POR QUE SON 9 SON POCOS , TAMBIEN AHI PODEMOS IMPLEMENTAR OTRA TABLA EN ESE TAB 
            if (rbtCiudad.Checked)
            {
                cargarDatos1("SELECT   Nortwind.FirstName,Employees.City " +
                    "FROM     Northwind INNER JOIN Employees ON Northwind.EmployeeID =  " +
                    "\r\nWhere Employees.City='"
                    + cmbPais.Text + "'");
            }

        }
        private void chkTerritorios_CheckedChanged(object sender, EventArgs e)
        {
            //INTENTE CONECTAR LA TABLA DE EMPLOYEETERRITORY PARA CUANDO SELECCIONEMOS UN EMPLOYEEID NOS MARQUE QUE TERRITORIOS SON 
            //PERO NO PUDE CONECTARLO
            DataTable da;
            Datos dt = new Datos();
            if (chkTerritorios.Checked)
            {
                cmbTerritorio.Enabled = true;
                DataSet ds = dt.ejecutarConsulta("Select TerritoryID From Territory");
                if (ds != null)
                {
                    da = ds.Tables[0];
                    cmbTerritorio.DataSource = ds.Tables[0];
                    cmbTerritorio.DisplayMember = "Territory";
                    cmbTerritorio.ValueMember = "TerritoryID";
                }
                dt.ejecutarConsulta("SELECT   Northwind.NOMBRE, Territory.TerritoryID  " +
                    "FROM     Northwind INNER JOIN Territory ON Nortwind.TerrytoryID = " +
                    "Where Territory.TerritoryID='" + cmbTerritorio.Text + "'");
            }
            else
            {
                cmbTerritorio.Enabled = false;
            }
        }



        //FALTA EL DE REGION ,IGUAL QUERIA QUE CUANDO SELECCIONEMOS UNA DE LAS CUATRO REGIONES TE ARROJE QUE TERRITORIOS ESTAN
        private void dgvCategories_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ajustarCategories();
        }

        private void Territory_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargarDatos("Select * From Territories");
        }

        private void btnNuevoTerritory_Click(object sender, EventArgs e)
        {
            FrmTerritory territory = new FrmTerritory();

            territory.FormClosed += Territory_FormClosed;

            territory.Show();

        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {

        }
    }

}


