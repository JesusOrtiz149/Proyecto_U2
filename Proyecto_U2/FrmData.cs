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
    public partial class FrmData : Form
    {
        public FrmData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = new SqlConnection(@"Data Source = LAPTOP-9P0KPF56\SQLEXPRESS04;Integrated Security=true;Initial Catalog = Northwind"))
            {
                try
                {

                    conexion.Open();


                    string consulta = "SELECT * FROM Employees WHERE LastName = @LastName AND TitleOfCourtesy = @TitleOfCourtesy ";
                    string con = "SELECT * FROM Admin Where Apat = @Apat AND Tadmin = @Tadmin";

                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlCommand comandoAdmin = new SqlCommand(con, conexion);
                    comando.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    comando.Parameters.AddWithValue("@TitleOfCourtesy", txtTitle.Text);
                    comandoAdmin.Parameters.AddWithValue("@Apat", txtLastName.Text);
                    comandoAdmin.Parameters.AddWithValue("@Tadmin", txtTitle.Text);

                    SqlDataReader lector = comando.ExecuteReader();
                    SqlDataReader lectorA = comandoAdmin.ExecuteReader();
                    if (lectorA.HasRows)
                    {
                        while (lectorA.Read())
                        {
                            MessageBox.Show("Your Password: " + lectorA["@Password"].ToString());
                        }
                    }

                    else
                    {
                        MessageBox.Show("Su usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    lectorA.Close();


                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {

                            MessageBox.Show("Your ID: " + lector["EmployeeID"].ToString());
                        }

                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Su usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

