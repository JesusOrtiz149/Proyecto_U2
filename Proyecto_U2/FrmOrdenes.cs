using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Proyecto_U2
{
    public partial class FrmOrdenes : Form
    {
        Thread Order1;
        public FrmOrdenes()
        {
            InitializeComponent();
            
        }
        public void Chart(int employeeID)
        {
            Datos dt = new Datos();

            // Consulta SQL para obtener las fechas y cantidades de órdenes del empleado seleccionado
            string query = $"SELECT CONVERT(DATE, OrderDate) AS OrderDate, COUNT(*) AS OrderCount " +
                           $"FROM Orders " +
                           $"WHERE EmployeeID = {employeeID} " +
                           $"GROUP BY CONVERT(DATE, OrderDate) " +
                           $"ORDER BY CONVERT(DATE, OrderDate)";
            DataSet ds = dt.ejecutarConsulta(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                // Crear y configurar la serie de datos para el gráfico
                Series orderSeries = new Series("OrderCount")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.DeepSkyBlue,
                    BorderWidth = 3
                };

                // Añadir los puntos de datos a la serie
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DateTime orderDate = Convert.ToDateTime(row["OrderDate"]);
                    int orderCount = Convert.ToInt32(row["OrderCount"]);
                    orderSeries.Points.AddXY(orderDate.ToShortDateString(), orderCount);
                }

                // Verificar si el gráfico necesita invocarse desde un subproceso
                if (chtOrde.InvokeRequired)
                {
                    chtOrde.Invoke(new MethodInvoker(delegate
                    {
                        chtOrde.Series.Clear();
                        chtOrde.Series.Add(orderSeries);
                        ConfigurarEjes();
                    }));
                }
                else
                {
                    chtOrde.Series.Clear();
                    chtOrde.Series.Add(orderSeries);
                    ConfigurarEjes();
                }
            }
            else
            {
                // Limpiar el gráfico si no hay datos
                chtOrde.Series.Clear();
                MessageBox.Show("No se encontraron datos para graficar del empleado seleccionado.",
                                "Información",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void ConfigurarEjes()
        {
            var chartArea = chtOrde.ChartAreas[0];

            chartArea.AxisX.Interval = 1;                     // Mostrar todas las fechas
            chartArea.AxisX.LabelStyle.Angle = -45;           // Rotar etiquetas para legibilidad
            chartArea.AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Formato de fecha
            chartArea.AxisX.Title = "Fecha de Pedido";

            chartArea.AxisY.Minimum = 0;                      // Asegurar que el eje Y comienza en 0
            chartArea.AxisY.Title = "Cantidad de Órdenes";
        }



        public void cargarDatosOrders()
        {
            Datos dt = new Datos();
            DataSet ds = dt.ejecutarConsulta("SELECT * FROM Orders");
            if (ds != null)
            {
                dtgOrders.DataSource = ds.Tables[0];
            }
        }


        public void cargarEmployeeIDs()
        {
            Datos dt = new Datos();
            DataSet ds = dt.ejecutarConsulta("SELECT DISTINCT EmployeeID FROM Orders ORDER BY EmployeeID");
            if (ds != null)
            {
                cmbEmployeeID.DisplayMember = "EmployeeID";
                cmbEmployeeID.ValueMember = "EmployeeID";
                cmbEmployeeID.DataSource = ds.Tables[0];
            }
        }


        public void cargarNombreEmpleado(int employeeID)
        {
            Datos dt = new Datos();
            string query = $"SELECT FirstName + ' ' + LastName AS FullName FROM Employees WHERE EmployeeID = {employeeID}";
            DataSet ds = dt.ejecutarConsulta(query);
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                txtEmployeeName.Text = ds.Tables[0].Rows[0]["FullName"].ToString();
            }
            else
            {
                txtEmployeeName.Text = "Empleado no encontrado";
            }
        }


        public void cargarOrdersPorEmpleado(int employeeID)
        {
            Datos dt = new Datos();
            string query = $"SELECT * FROM Orders WHERE EmployeeID = {employeeID}";
            DataSet ds = dt.ejecutarConsulta(query);
            if (ds != null)
            {
                dtgOrders.DataSource = ds.Tables[0];
            }
        }


        private void dtgOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string orderID = dtgOrders.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                FrmDetails detallesForm = new FrmDetails(orderID);
                detallesForm.ShowDialog();
            }
        }

     
        private void btnNuevaOrden_Click(object sender, EventArgs e)
        {
            FrmAddOrder frmAddOrder = new FrmAddOrder();
            frmAddOrder.Show();
        }


        private void cmbEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedValue != null)
            {
                int selectedEmployeeID = Convert.ToInt32(cmbEmployeeID.SelectedValue);

                Chart(selectedEmployeeID);
                cargarOrdersPorEmpleado(selectedEmployeeID);
                cargarNombreEmpleado(selectedEmployeeID);
               
            }
        }


        private void FrmOrdenes_Load_1(object sender, EventArgs e)
        {
            cargarEmployeeIDs();
            cargarDatosOrders();

            if (cmbEmployeeID.SelectedValue != null)
            {
                int selectedEmployeeID = Convert.ToInt32(cmbEmployeeID.SelectedValue);
                Chart(selectedEmployeeID);

            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

       
    }
}