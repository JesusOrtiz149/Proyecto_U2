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
    public partial class FrmLogin : Form
    {
        DataSet ds;
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {



            using (SqlConnection conexion = new SqlConnection(/*@"Data Source = LAPTOP-9P0KPF56\SQLEXPRESS04;Integrated Security=true;Initial Catalog = Northwind"*/@"Data Source = DESKTOP-3KGVR4J\SQLEXPRESS;Integrated Security=true;Initial Catalog = Northwind"))
            {
                try
                {

                    conexion.Open();


                    string consulta = "SELECT * FROM Employees WHERE FirstName = @FirstName AND EmployeeID = @EmployeeID";
                    SqlCommand comando = new SqlCommand(consulta, conexion);


                    comando.Parameters.AddWithValue("@FirstName", txtUsuario.Text);
                    comando.Parameters.AddWithValue("@EmployeeID", txtContra.Text);


                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        MessageBox.Show("Bienvenido");
                        this.Hide();
                        FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                        frmMenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o ID incorrectos");
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
                conexion.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

    




