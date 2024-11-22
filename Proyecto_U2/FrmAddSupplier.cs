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
    public partial class FrmAddSupplier : Form
    {
        bool bandera = false;
        Datos dt = new Datos();
        int ID;

        public FrmAddSupplier()
        {
            InitializeComponent();
        }

        private FrmAddSupplier(int supplierID, string Company, string contactoNombre, string contactoCargo, string direccion, string ciudad, string region, string codigoP, string pais, string tel, string fax, string pagWeb)
        {
            this.ID = supplierID;
            txtNombreCompany.Text = Company;
            txtContactoNombre.Text = contactoNombre;
            txtContactoCargo.Text = contactoCargo;
            txtDireccion.Text = direccion;
            txtCiudad.Text = ciudad;
            txtEstado.Text = region;
            mtbCodigoP.Text = codigoP;
            txtPais.Text = pais;
            mtbTel.Text = tel;
            mtbFax.Text = fax;
            txtPagWeb.Text = pagWeb;
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Proveedores",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {
                    bool j = dt.ejecutarABC("Update Suppliers Set CompanyName = '" +
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
                                                "', HomePage = ' " + txtPagWeb.Text +
                                                " Where SupplierID = '" + ID + "'");

                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Proveedores",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Proveedores", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //try
                    //{
                   // MessageBox.Show(txtNombreCompany.Text);
                    bool j = dt.ejecutarABC("Insert Into Suppliers (CompanyName, ContactName, ContactTitle, Address" +
                                             ",City, Region, PostalCode, Country, Phone, Fax, HomePage ) " +
                                                      "Values ('" + txtNombreCompany.Text +
                                                      "','" + txtContactoNombre.Text +
                                                      "','" + txtContactoCargo.Text +
                                                      "','" + txtDireccion.Text +
                                                      "','" + txtCiudad.Text +
                                                      "','" + txtEstado.Text +
                                                      "','" + mtbCodigoP.Text +
                                                      "','" + txtPais.Text +
                                                      "','" + mtbTel.Text +
                                                      "','" + mtbFax.Text +
                                                      "','" + txtPagWeb.Text + "')");

                    if (j == true)
                    {
                        MessageBox.Show("Proveedor añadido", "Proveedores",
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
                        txtPagWeb.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Proveedores", MessageBoxButtons.OK,
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

        private void FrmAddSupplier_Load(object sender, EventArgs e)
        {
           
        }

    }
}
