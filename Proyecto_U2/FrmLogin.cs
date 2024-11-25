using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_U2
{


    public partial class FrmLogin : Form
    {
        public static int key;
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
                    int employeeIDInput = 0;
                    int supplierIDInput = 0;
                    string customerIDInput = txtCustomers.Text.Trim();
                    string firstNameInput = txtUsuario.Text.Trim(); 

                    bool isEmployeeValid = int.TryParse(txtContra.Text, out employeeIDInput);
                    bool isSupplierValid = int.TryParse(txtSupplier.Text, out supplierIDInput);

                    conexion.Open();

                    // Verificar credenciales de empleado
                    if (isEmployeeValid && employeeIDInput != 0)
                    {
                        string query = "SELECT EmployeeID, Title, FirstName FROM Employees WHERE EmployeeID = @EmployeeID";
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@EmployeeID", employeeIDInput);
                            using (SqlDataReader lector = comando.ExecuteReader())
                            {
                                if (lector.Read())
                                {
                                    string firstNameFromDb = lector["FirstName"].ToString();

                                    
                                    if (!string.Equals(firstNameInput, firstNameFromDb, StringComparison.OrdinalIgnoreCase))
                                    {
                                        MessageBox.Show("El nombre no coincide con el ID del empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        txtUsuario.Clear();
                                        txtContra.Clear();
                                        return;
                                    }

                                    string role = lector["Title"].ToString();
                                    string userName = $"Empleado {employeeIDInput}";

                                    
                                    UserSession.Role = role;
                                    UserSession.UserName = userName;

                                    
                                    DialogResult result = MessageBox.Show($"¡Bienvenido, {userName}! Rol: {role}", "Acceso Empleado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                    if (result == DialogResult.Cancel)
                                    {
                                        this.Hide();
                                        txtUsuario.Clear();
                                        txtContra.Clear();
                                        return;
                                    }

                                    this.Hide();
                                    FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                                    frmMenu.ShowDialog();
                                    this.Close();
                                    return;
                                }
                            }
                        }
                    }

                   
                    if (isSupplierValid && supplierIDInput != 0)
                    {
                        string query = "SELECT ContactName FROM Suppliers WHERE SupplierID = @SupplierID";
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@SupplierID", supplierIDInput);
                            using (SqlDataReader lector = comando.ExecuteReader())
                            {
                                if (lector.Read())
                                {
                                    string role = "Proveedor";
                                    string userName = lector["ContactName"].ToString();

                                    UserSession.Role = role;
                                    UserSession.UserName = userName;

                                    DialogResult result = MessageBox.Show($"¡Bienvenido, {userName}! Rol: {role}", "Acceso Proveedor", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                    if (result == DialogResult.Cancel)
                                    {
                                        this.Hide();
                                        txtUsuario.Clear();
                                        txtSupplier.Clear();
                                        return;
                                    }
                                    this.Hide();
                                    FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                                    frmMenu.ShowDialog();
                                    this.Close();
                                    return;
                                }
                            }
                        }
                    }

                    
                    if (!string.IsNullOrEmpty(customerIDInput))
                    {
                        string query = "SELECT CompanyName FROM Customers WHERE CustomerID = @CustomerID";
                        using (SqlCommand comando = new SqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@CustomerID", customerIDInput);
                            using (SqlDataReader lector = comando.ExecuteReader())
                            {
                                if (lector.Read())
                                {
                                    string role = "Cliente";
                                    string userName = lector["CompanyName"].ToString();

                                    UserSession.Role = role;
                                    UserSession.UserName = userName;

                                    DialogResult result = MessageBox.Show($"¡Bienvenido, {userName}! Rol: {role}", "Acceso Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                                    if (result == DialogResult.Cancel)
                                    {
                                        this.Hide();
                                        txtUsuario.Clear();
                                        txtCustomers.Clear();
                                        return;
                                    }
                                    this.Hide();
                                    FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                                    frmMenu.ShowDialog();
                                    this.Close();
                                    return;
                                }
                            }
                        }
                    }

                    // Si no se encuentran credenciales válidas
                    MessageBox.Show("Credenciales no válidas. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


            /* private void ShowWelcomeMessage(string userName, string employeeID)
                 {
                     DialogResult result = MessageBox.Show($"Bienvenido {userName}", "Home", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                     if (result == DialogResult.OK)
                     {
                         this.Hide();
                         FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                         frmMenu.ShowDialog();
                     }
                 }*/
            private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmData frmData = new FrmData();
            frmData.Show();
        }
        private void chkSupplier_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSupplier.Checked)
            {
                txtContra.Visible = false;
                txtSupplier.Visible = true;
                txtCustomers.Visible = false;
            }
            else
            {
                txtContra.Visible = true;
                txtSupplier.Visible = false;
                txtCustomers.Visible = false;
            }
        }
        private void chkCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomers.Checked)
            {
                txtContra.Visible = false;
                txtSupplier.Visible = false;
                txtCustomers.Visible = true;
            }
            else
            {
                txtContra.Visible = true;
                txtSupplier.Visible = false;
                txtCustomers.Visible = false;
            }
        }
    }
}
    







