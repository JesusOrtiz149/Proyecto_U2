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
        
        public FrmOrdenes()
        {
            InitializeComponent();

        }
        public void Chart(int employeeID)
        {
            Datos dt = new Datos(); // Asegúrate de que esta clase esté correctamente configurada

            // Consulta SQL que obtiene las órdenes del empleado seleccionado
            string query = $"SELECT CONVERT(DATE, OrderDate) AS OrderDate, COUNT(*) AS OrderCount " +
                           $"FROM Orders " +
                           $"WHERE EmployeeID = {employeeID} " +  // Filtrar por el employeeID
                           $"GROUP BY CONVERT(DATE, OrderDate) " +
                           $"ORDER BY CONVERT(DATE, OrderDate)";

            // Ejecutar la consulta y obtener los resultados
            DataSet ds = dt.ejecutarConsulta(query);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                // Crear la serie de datos para la gráfica
                Series orderSeries = new Series("OrderCount")
                {
                    ChartType = SeriesChartType.Column, // Tipo de gráfico (Columnas)
                    Color = Color.DeepSkyBlue,         // Color de las barras
                    BorderWidth = 3                    // Ancho de borde de las barras
                };

                // Añadir los puntos de datos a la serie
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DateTime orderDate = Convert.ToDateTime(row["OrderDate"]);
                    int orderCount = Convert.ToInt32(row["OrderCount"]);

                    // Añadir un punto con la fecha y el número de órdenes
                    orderSeries.Points.AddXY(orderDate, orderCount);
                }

                // Verificar si el gráfico necesita actualizarse desde otro hilo (en caso de usar Invoke)
                if (chtOrde.InvokeRequired)
                {
                    chtOrde.Invoke(new MethodInvoker(delegate
                    {
                        chtOrde.Series.Clear();  // Limpiar antes de agregar nueva serie
                        chtOrde.Series.Add(orderSeries);
                        ConfigurarEjes();
                    }));
                }
                else
                {
                    // Actualizar la gráfica directamente si ya estamos en el hilo correcto
                    chtOrde.Series.Clear();  // Limpiar antes de agregar nueva serie
                    chtOrde.Series.Add(orderSeries);
                    ConfigurarEjes();
                }
            }
            else
            {
                // Limpiar la gráfica si no hay datos
                chtOrde.Series.Clear();
                MessageBox.Show("No se encontraron datos para graficar del empleado seleccionado.",
                                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigurarEjes()
        {
            // Configuración de los ejes de la gráfica
            var chartArea = chtOrde.ChartAreas[0];

            // Configuración del eje X
            chartArea.AxisX.Interval = 1; // Mostrar todas las fechas
            chartArea.AxisX.LabelStyle.Angle = -45; // Rotar las etiquetas de las fechas para mejor visibilidad
            chartArea.AxisX.LabelStyle.Format = "dd/MM/yyyy"; // Formato de fecha
            chartArea.AxisX.Title = "Fecha de Pedido";

            // Configuración del eje Y
            chartArea.AxisY.Minimum = 0;  // Asegurar que el eje Y comienza en 0
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
        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        
    }
}