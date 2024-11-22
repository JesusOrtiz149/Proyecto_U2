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
    public partial class FrmAddOrder : Form
    {
        Datos dt = new Datos();
        int OrderID;
        bool bandera = false;
        string hora = DateTime.Now.ToString();

        public FrmAddOrder()
        {
            InitializeComponent();
        }
        public FrmAddOrder(int orderID, string IDCliente, int IDEmpleado,DateTime orderDate, 
                            DateTime requiredDate, DateTime shippedDate, int IDbarco, double flete, 
                            string barcoNombre, string barcoDireccion, string barcoCiudad, 
                            string barcoRegion, string barcoCodigoP, string barcoPais)
        {

            InitializeComponent();
            poblarCmb(cmbIDbarco, "Select CompanyName from Shippers");
            poblarCmb(cmbEmpleado, "Select FirstName, LastName from Employees ");
            OrderID = orderID;
            txtIDCliente.Text = IDCliente;
            cmbEmpleado.SelectedIndex = IDEmpleado;
            hora = orderDate.ToString();
            dtpFechaEntrega.Text = requiredDate.ToString();
            dtpFechaEmbarque.Text = shippedDate.ToString();
            cmbIDbarco.SelectedIndex = IDbarco;
            mtbFlete.Text = flete.ToString();
            txtNombre.Text = barcoNombre;
            txtDireccion.Text = barcoDireccion;
            txtCiudad.Text = barcoCiudad;
            txtEstado.Text = barcoRegion;
            txtCodigoP.Text = barcoCodigoP;
            txtPais.Text = barcoPais;


        }
        public void poblarCmb(ComboBox cmb, string consulta)
        {
            try
            {
                //string consulta = "Select CompanyName from Shippers";
                DataSet ds;
                ds = dt.ejecutarConsulta(consulta);

                if (ds != null && ds.Tables.Count > 0)
                {
                    // Limpia el ComboBox antes de llenarlo
                    cmb.Items.Clear();

                    // Itera sobre los datos y los agrega al ComboBox
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        cmb.Items.Add(row[0].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para llenar el ComboBox.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void FrmAddOrder_Load(object sender, EventArgs e)
        {
            poblarCmb(cmbIDbarco, "Select CompanyName from Shippers");
            poblarCmb(cmbEmpleado, "Select FirstName, LastName from Employees ");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("¿Los datos son correctos?", "Orders",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {

                    bool j = dt.ejecutarABC("Update Orders Set " +
                        "                           CustomerID = " + txtIDCliente.Text +
                                                ",  EmployeeID = " + cmbEmpleado.Text +
                                                ",  OrderDate = '" + hora +
                                                "', RequiredDate = '" + dtpFechaEntrega.Text +
                                                "', ShippedDate = '" + dtpFechaEmbarque.Text +
                                                "', ShipVia = " + cmbIDbarco.Text +
                                                ", Freight = " + mtbFlete.Text +
                                                ",  ShipName  = '" + txtNombre.Text +
                                                "', ShipAddress = '" + txtDireccion.Text +
                                                "', ShipCity = '" + txtDireccion.Text +
                                                "', ShipRegion = '" + txtEstado.Text +
                                                "', ShipPostalCode = '" + txtCodigoP.Text +
                                                "', ShipCountry = '" + txtPais.Text +
                        " Where OrderID = " + OrderID 
                        );

                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Products",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Error", "Products", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {

                        DateTime fechaActual = dtpOrderDate.Value;
                        string fecha = fechaActual.ToString("dd-MM-yyyy");

                        DateTime fechaRequerida = dtpFechaEntrega.Value;
                        string fechaEntrega = fechaRequerida.ToString("dd-MM-yyyy");

                        DateTime fechaEmb = dtpFechaEmbarque.Value;
                        string fechaEmbarque = fechaEmb.ToString("dd-MM-yyyy");




                        string consulta = "Insert Into Orders (CustomerID, EmployeeID, OrderDate, RequiredDate" +
                                                 ",ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity," +
                                                 "ShipRegion, ShipPostalCode, ShipCountry ) " +
                                                         "Values ('" + txtIDCliente.Text + "',"
                                                            + (cmbEmpleado.SelectedIndex + 1) + ",'"
                                                            + fecha + "','"
                                                            + fechaEntrega + "','"
                                                            + fechaEmbarque + "',"
                                                            + (cmbIDbarco.SelectedIndex + 1) + ","
                                                            + Convert.ToDecimal(mtbFlete.Text) + ",'"
                                                            + txtNombre.Text + "','"
                                                            + txtDireccion.Text + "','"
                                                            + txtCiudad.Text + "','"
                                                            + txtEstado.Text + "','"
                                                            + txtCodigoP.Text + "','"
                                                            + txtPais.Text + "')";


                        bool j = dt.ejecutarABC(/*"Insert Into Orders (CustomerID, EmployeeID, OrderDate, RequiredDate" +
                                             ",ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity," +
                                             "ShipRegion, ShipPostalCode, ShipCountry ) " +
                                                     "Values ('" + txtIDCliente.Text + "',"
                                                        + (cmbEmpleado.SelectedIndex+1) + ",'"
                                                        + fecha + "','"
                                                        + fechaEntrega + "','"
                                                        + fechaEmbarque + "',"
                                                        + (cmbIDbarco.SelectedIndex+1) + ","
                                                        + double.Parse(mtbFlete.Text) + ",'"
                                                        + txtNombre.Text + "','"
                                                        + txtDireccion.Text + "','"
                                                        + txtCiudad.Text + "','"
                                                        + txtEstado.Text + "','"
                                                        + txtCodigoP.Text + "','"
                                                        + txtPais.Text + "')"*/consulta);
                        MessageBox.Show(consulta);

                        if (j == true)
                        {
                            MessageBox.Show("Producto añadido", "Orders",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNombre.Clear();
                            txtPais.Clear();
                            txtEstado.Clear();
                            txtCiudad.Clear();
                            txtDireccion.Clear();
                            txtCodigoP.Clear();
                            mtbFlete.Clear();
                            txtIDCliente.Clear();


                        }
                        else
                        {
                            MessageBox.Show("Error", "Orders", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
