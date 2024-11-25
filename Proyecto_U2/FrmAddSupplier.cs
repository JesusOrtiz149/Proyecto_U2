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
        FrmProveedores frmProveedores = new FrmProveedores();
        bool bandera = false;
        Datos dt = new Datos();
        int ID;

        public FrmAddSupplier()
        {
            InitializeComponent();
        }
        public FrmAddSupplier(string supplierID, string Company, string contactoNombre, string contactoCargo, string direccion, string ciudad, string region, string codigoP, string pais, string tel, string fax, string pagWeb)
        {
            InitializeComponent();
            this.ID = Convert.ToInt32(supplierID);
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
            bandera = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Los datos son correctos?", "Proveedores",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Dictionary<string, object> parametros = new Dictionary<string, object>();
                if (bandera == true)
                {
                    //string consultaUpdate = "UPDATE Suppliers SET \" +\r\n\"CompanyName = @CompanyName, ContactName = @ContactName, \" +\r\n\"ContactTitle = @ContactTitle, Address = @Address, \" +\r\n\"City = @City, Region = @Region, PostalCode = @PostalCode, \" +\r\n\"Country = @Country, Phone = @Phone, Fax = @Fax, HomePage = @HomePage \" +\r\n\"WHERE SupplierID = @SupplierID";
                    string consultaUpdate = @"UPDATE Suppliers 
                                      SET CompanyName = @CompanyName, 
                                          ContactName = @ContactName, 
                                          ContactTitle = @ContactTitle, 
                                          Address = @Address, 
                                          City = @City, 
                                          Region = @Region, 
                                          PostalCode = @PostalCode, 
                                          Country = @Country, 
                                          Phone = @Phone, 
                                          Fax = @Fax, 
                                          HomePage = @HomePage 
                                      WHERE SupplierID = @SupplierID";
                        
                    parametros.Add("@SupplierID", ID);
                    parametros.Add("@CompanyName", txtNombreCompany.Text);
                    parametros.Add("@ContactName", txtContactoNombre.Text);
                    parametros.Add("@ContactTitle", txtContactoCargo.Text);
                    parametros.Add("@Address", txtDireccion.Text);
                    parametros.Add("@City", txtCiudad.Text);
                    parametros.Add("@Region", txtEstado.Text);
                    parametros.Add("@PostalCode", mtbCodigoP.Text);
                    parametros.Add("@Country", txtPais.Text);
                    parametros.Add("@Phone", mtbTel.Text);
                    parametros.Add("@Fax", mtbFax.Text);
                    parametros.Add("@HomePage", txtPagWeb.Text);

                    bool j = dt.ejecutarABCModificado(consultaUpdate,parametros);


                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Proveedores",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmProveedores.cargarDatosSuppliers();
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
                        frmProveedores.cargarDatosSuppliers();
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
