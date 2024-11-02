using System.Data;
using System.Drawing.Text;

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
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dtgTerritory.DataSource = ds.Tables[0];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos("Select * From Territories");
            cargarDatos1("Select * From Employees");
            cargarDatos2("Select * From Customers");
        }
        public void cargarDatos1(String comando)
        {
            Datos dt = new Datos();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dtgEmployees.DataSource = ds.Tables[0];
            }

        }
        public void cargarDatos2(String comando)
        {
            Datos dt = new Datos();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dtgCustomers.DataSource = ds.Tables[0];
            }

        }

        private void rbtCiudad_CheckedChanged(object sender, EventArgs e)
        {
            DataTable da;
            Datos dt = new Datos();
            if (rbtCiudad.Checked)
            {
                cmbPais.Enabled = true;
                DataSet ds = dt.Ejecutar("Select City From Employees");
                if (ds != null)
                {
                    da = ds.Tables[0];
                    cmbPais.DataSource = ds.Tables[0];
                    cmbPais.DisplayMember = "City";
                    //cmbPais.ValueMember = "EmployeeID";
                }
                cargarDatos1("SELECT   Nortwind.FirstName,Employees.City " +
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
                DataSet ds = dt.Ejecutar("Select TerritoryID From Territory");
                if (ds != null)
                {
                    da = ds.Tables[0];
                    cmbTerritorio.DataSource = ds.Tables[0];
                    cmbTerritorio.DisplayMember = "Territory";
                    cmbTerritorio.ValueMember = "TerritoryID";
                }
                cargarDatos("SELECT   Northwind.NOMBRE, Territory.TerritoryID  " +
                    "\r\nFROM     Northwind INNER JOIN Territory ON Nortwind.TerrytoryID = " +
                    "\r\nWhere Territory.TerritoryID='" + cmbTerritorio.Text + "'");
            }
            else
            {
                cmbTerritorio.Enabled = false;
            }
        }
        //FALTA EL DE REGION ,IGUAL QUERIA QUE CUANDO SELECCIONEMOS UNA DE LAS CUATRO REGIONES TE ARROJE QUE TERRITORIOS ESTAN
    }
}


