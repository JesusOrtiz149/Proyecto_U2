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


            using (SqlConnection conexion = new SqlConnection(@"Data Source=LAPTOP-9P0KPF56\SQLEXPRESS04;Integrated Security=true;Initial Catalog=Northwind"))
            {
                try
                {
                    conexion.Open();

                    string updateAdminQuery = "UPDATE Employees SET Title = 'admin' WHERE EmployeeID = 2";
                    SqlCommand commandAdmin = new SqlCommand(updateAdminQuery, conexion);
                    commandAdmin.ExecuteNonQuery();

                    string updateUserQuery = "UPDATE Employees SET Title = 'Sales Representative' WHERE EmployeeID IN (1, 3, 4, 6, 7, 9)";
                    SqlCommand commandUser = new SqlCommand(updateUserQuery, conexion);
                    commandUser.ExecuteNonQuery();

                    string updateManagerQuery = "UPDATE Employees SET Title = 'Sales Manager' WHERE EmployeeID = 5";
                    SqlCommand commandManager = new SqlCommand(updateManagerQuery, conexion);
                    commandManager.ExecuteNonQuery();


                    int employeeIDInput;
                    if (!int.TryParse(txtContra.Text, out employeeIDInput))
                    {
                        MessageBox.Show("El ID ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    string checkRoleQuery = "SELECT EmployeeID, Title FROM Employees WHERE EmployeeID = @EmployeeID";
                    SqlCommand comando = new SqlCommand(checkRoleQuery, conexion);
                    comando.Parameters.AddWithValue("@EmployeeID", employeeIDInput);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        int employeeID = Convert.ToInt32(lector["EmployeeID"]);
                        string role = lector["Title"].ToString();
                        lector.Close();

                        if (employeeID == 2)
                        {
                            DialogResult result = MessageBox.Show("Bienvenido Dr.Andrew", "Home", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.OK)
                            {
                                this.Hide();
                                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                                frmMenu.ShowDialog();
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                return;
                            }
                        }
                        else if (employeeID == 5)
                        {
                            DialogResult result = MessageBox.Show("Bienvenido Mr.Steven", "Home", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                            if (result == DialogResult.OK)
                            {
                                this.Hide();
                                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                                frmMenu.ShowDialog();
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                return;

                            }
                        }
                        else
                        {

                            DialogResult result = MessageBox.Show("Bienvenido Usuario", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                            if (result == DialogResult.OK)
                            {
                                this.Hide();
                                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                                frmMenu.ShowDialog();

                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                

                    else
                    {
                        lector.Close();
                        MessageBox.Show("Usuario o ID incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmData frmData = new FrmData();
            frmData.Show();
        }
    }
}

    




