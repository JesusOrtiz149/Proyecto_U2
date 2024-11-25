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
        FrmOrdenes frmOrdenes = new FrmOrdenes();

        Datos dt = new Datos();
        int OrderID;
        bool bandera = false;
        string hora = DateTime.Now.ToString();
        
        int cmbIntEmpleado;
        int cmbIntBarco;

        public FrmAddOrder()
        {
            InitializeComponent();
        }
        public FrmAddOrder(string orderID, string IDCliente, string IDEmpleado,string  orderDate, 
                            string requiredDate, string shippedDate, string IDbarco, string flete, 
                            string barcoNombre, string barcoDireccion, string barcoCiudad, 
                            string barcoRegion, string barcoCodigoP, string barcoPais)
        {

            InitializeComponent();
            poblarCmb(cmbIDbarco, "Select CompanyName from Shippers");
            poblarCmb(cmbEmpleado, "Select FirstName, LastName from Employees ");

            cmbIntEmpleado = Convert.ToInt32(IDEmpleado);
            cmbIntBarco = Convert.ToInt32(IDbarco);
            dtpFechaEntrega.Format = DateTimePickerFormat.Custom;
            dtpFechaEntrega.CustomFormat = "dd-MM-yyyy";

            dtpFechaEmbarque.Format = DateTimePickerFormat.Custom;
            dtpFechaEmbarque.CustomFormat = "dd-MM-yyyy";


            OrderID = Convert.ToInt32(orderID);

            txtIDCliente.Text = IDCliente;



            cmbEmpleado.SelectedIndex = cmbIntEmpleado - 1;

         

            if (!string.IsNullOrEmpty(orderDate) && DateTime.TryParse(orderDate, out DateTime parsedOrderDate))
                hora = parsedOrderDate.ToString("dd-MM-yyyy");

            if (!string.IsNullOrEmpty(requiredDate) && DateTime.TryParse(requiredDate, out DateTime parsedRequiredDate))
            {
                dtpFechaEntrega.Value = parsedRequiredDate;
            }

            if (!string.IsNullOrEmpty(shippedDate) && DateTime.TryParse(shippedDate, out DateTime parsedShippedDate))
                dtpFechaEmbarque.Value = parsedShippedDate;



            // hora = fecha;




            //   dtpFechaEntrega.va = FECHAentrega;

            //  dtpFechaEmbarque.Text = FECHAembarque;

            /* MessageBox.Show("fecha entrega " + dtpFechaEntrega.Value.ToString("dd-MM-yyyy") + "fecha entrega ");

             MessageBox.Show("fecha embarque " + dtpFechaEmbarque.Value.ToString("dd-MM-yyyy"));*/

            cmbIDbarco.SelectedIndex = cmbIntBarco - 1;

            //MessageBox.Show("cmbbarco " + cmbIDbarco.SelectedIndex);

            mtbFlete.Text = flete;

  

            txtNombre.Text = barcoNombre;
            txtDireccion.Text = barcoDireccion;
            txtCiudad.Text = barcoCiudad;
            txtEstado.Text = barcoRegion;
            mtbCodigoP.Text = barcoCodigoP;
            txtPais.Text = barcoPais;

            bandera = true;

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
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (MessageBox.Show("¿Los datos son correctos?", "Orders",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (bandera == true)
                {
                   /* MessageBox.Show(dtpFechaEntrega.Value.ToString("dd - MM - yyyy"));
                    MessageBox.Show(dtpFechaEmbarque.Value.ToString("dd - MM - yyyy"));*/
                    //MessageBox.Show((cmbEmpleado.SelectedIndex).ToString());
                    //MessageBox.Show((cmbIDbarco.SelectedIndex).ToString());

                    string consultaUpdate = @"UPDATE Orders 
                                      SET CustomerID = @CustomerID, 
                                          EmployeeID = @EmployeeID, 
                                          OrderDate = @OrderDate, 
                                          RequiredDate = @RequiredDate, 
                                          ShippedDate = @ShippedDate, 
                                          ShipVia = @ShipVia, 
                                          Freight = @Freight, 
                                          ShipName = @ShipName, 
                                          ShipAddress = @ShipAddress,
                                          ShipCity = @ShipCity, 
                                          ShipRegion = @ShipRegion,
                                          ShipPostalCode = @ShipPostalCode,
                                          ShipCountry = @ShipCountry
                                      WHERE OrderID = @OrderID";

                    /*bool j = dt.ejecutarABC("Update Orders Set " +
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
                        );*/
                    parametros.Add("@OrderID", OrderID);
                    parametros.Add("@CustomerID", txtIDCliente.Text);
                    parametros.Add("@EmployeeID", Convert.ToInt32((cmbEmpleado.SelectedIndex+1)));
                    parametros.Add("@OrderDate", hora);
                    parametros.Add("@RequiredDate", dtpFechaEntrega.Value.ToString("dd-MM-yyyy"));
                    parametros.Add("@ShippedDate", dtpFechaEmbarque.Value.ToString("dd-MM-yyyy"));
                    parametros.Add("@ShipVia", Convert.ToInt32((cmbIDbarco.SelectedIndex+1)));
                    parametros.Add("@Freight", double.Parse(mtbFlete.Text));
                    parametros.Add("@ShipName", txtNombre.Text);
                    parametros.Add("@ShipAddress", txtDireccion.Text);
                    parametros.Add("@ShipCity", txtCiudad.Text);
                    parametros.Add("@ShipRegion", txtEstado.Text);
                    parametros.Add("@ShipPostalCode", mtbCodigoP.Text);
                    parametros.Add("@ShipCountry", txtPais.Text);
                    


                    bool j = dt.ejecutarABCModificado(consultaUpdate,parametros);


                    if (j == true)
                    {
                        MessageBox.Show("Datos Actualizados", "Products",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmOrdenes.cargarDatosOrders();
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
                                                            + mtbCodigoP.Text + "','"
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
                            frmOrdenes.cargarDatosOrders();
                            txtNombre.Clear();
                            txtPais.Clear();
                            txtEstado.Clear();
                            txtCiudad.Clear();
                            txtDireccion.Clear();
                            mtbCodigoP.Clear();
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
