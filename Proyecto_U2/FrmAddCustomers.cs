using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_U2
{
    public partial class FrmAddCustomers : Form
    {
        bool bandera = false;
        Datos dt = new Datos();
        string customerID;

        public FrmAddCustomers()
        {
            InitializeComponent();
        }

        private FrmAddCustomers(string customerID, string Company, string contactoNombre, string contactoCargo, string direccion, string ciudad, string region, string codigop, string pais, string tel, string fax)
        {
            InitializeComponent();
            this.customerID = customerID;
            txtNombreCompany.Text = Company;
            txtContactoNombre.Text = contactoNombre;
            txtContactoCargo.Text = contactoCargo;
            txtDireccion.Text = direccion;
            txtCiudad.Text = ciudad;
            txtEstado.Text = region;
            mtbCodigoP.Text = codigop;
            txtPais.Text = pais;
            mtbTel.Text = tel;
            mtbFax.Text = fax;
        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {

        }

        private string calcularID(string idC)
        {
            // Divide el nombre completo en partes (asumiendo que están separados por espacio)
            string[] partes = idC.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string primerNombre = partes[0];
            string segundoNombre = partes[1];

            //  las primeras tres letras del primer nombre
            string parte1 = primerNombre.Length >= 3
                ? primerNombre.Substring(0, 3)
                : primerNombre.PadRight(3, 'X'); // Rellena con 'X' si es más corto

            //  las primeras dos letras del segundo nombre
            string parte2 = segundoNombre.Length >= 2
                ? segundoNombre.Substring(0, 2)
                : segundoNombre.PadRight(2, 'X'); // Rellena con 'X' si es más corto

            // las combina y luego las hace mayúsculas
            string id = (parte1 + parte2).ToUpper();

            return id;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Customers",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {

                    bool j = dt.ejecutarABC("Update Customers Set CompanyName = '" +
                                                                       txtNombreCompany.Text +
                                                "', ContactName = '" + txtContactoNombre.Text +
                                                "', ContactTitle = '" + txtContactoCargo.Text +
                                                "', Address = '" + txtDireccion.Text +
                                                "', City = '" + txtCiudad.Text +
                                                "', Region = '" + txtEstado.Text +
                                                "', PostalCode  = '" + mtbCodigoP.Text +
                                                "', Country = '" + txtPais.Text +
                                                "', Phone = '" + mtbTel.Text +
                                                "', Fax = '" + mtbFax.Text +
                        " Where CustomerID = '" + customerID + "'");

                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Customers",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Customers", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //try
                    //{
                    MessageBox.Show(calcularID(txtNombreCompany.Text));
                    bool j = dt.ejecutarABC("Insert Into Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address" +
                                             ",City, Region, PostalCode, Country, Phone, Fax ) " +
                        "Values ('" + calcularID(txtNombreCompany.Text) + "', '" + txtNombreCompany.Text +
                                                      "','" + txtContactoNombre.Text +
                                                      "','" + txtContactoCargo.Text +
                                                      "','" + txtDireccion.Text +
                                                      "','" + txtCiudad.Text +
                                                      "','" + txtEstado.Text +
                                                      "','" + mtbCodigoP.Text +
                                                      "','" + txtPais.Text +
                                                      "','" + mtbTel.Text +
                                                      "','" + mtbFax.Text + "')");

                    if (j == true)
                    {
                        MessageBox.Show("Cliente añadido", "Customers",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombreCompany.Clear();
                        txtContactoNombre.Clear();
                        txtContactoCargo.Clear();
                        txtDireccion.Clear();
                        txtCiudad.Clear();
                        txtEstado.Clear();
                        mtbCodigoP.Clear();
                        txtPais.Clear();
                        mtbTel.Clear();
                        mtbFax.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Error", "Customers", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    /*}catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                   }*/
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
