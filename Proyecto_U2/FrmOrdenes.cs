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
using System.Windows.Forms.DataVisualization.Charting;


namespace Proyecto_U2
{
    public partial class FrmOrdenes : Form
    {
        Thread Order1;
        Datos dt = new Datos();
        DataSet ds;
        public FrmOrdenes()
        {
            InitializeComponent();

        }
        public void Chart(int employeeID)
        {
            Datos dt = new Datos();

            string query = @"
        SELECT CONVERT(DATE, OrderDate) AS OrderDate, COUNT(*) AS OrderCount
FROM Orders
WHERE EmployeeID IS NOT NULL AND EmployeeID = @EmployeeID
GROUP BY CONVERT(DATE, OrderDate)
ORDER BY CONVERT(DATE, OrderDate)";


            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@EmployeeID", employeeID)
            };

            DataSet ds = dt.ejecutarConsultaPS(query, parametros);

            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                
                return;
            }

            // Crear la serie de datos para la gráfica
            Series orderSeries = new Series("OrderCount")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.DeepSkyBlue,
                BorderWidth = 3
            };

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                DateTime orderDate = Convert.ToDateTime(row["OrderDate"]);
                int orderCount = Convert.ToInt32(row["OrderCount"]);
                orderSeries.Points.AddXY(orderDate, orderCount);
            }

            // Configurar el gráfico
            chtOrde.Series.Clear();
            chtOrde.Series.Add(orderSeries);
            ConfigurarEjes();
        }

        private void ConfigurarEjes()
        {
            var chartArea = chtOrde.ChartAreas[0];
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.LabelStyle.Format = "dd/MM/yyyy";
            chartArea.AxisX.Title = "Fecha de Pedido";
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Title = "Cantidad de Órdenes";
        }


        
    

        public void cargarDatosOrders()
        {

            using (SqlConnection conn = new SqlConnection("Data Source = LAPTOP-9P0KPF56\\SQLEXPRESS04;Integrated Security=true;Initial Catalog = Northwind"))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT OrderID, OrderDate FROM Orders", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgOrders.DataSource = dt;
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
            if (cmbEmployeeID.SelectedValue != null && cmbEmployeeID.SelectedValue != DBNull.Value)
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
                int selectedEmployeeID = Convert.ToInt32(cmbEmployeeID.SelectedValue != DBNull.Value);
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
            //frmAddOrder.FormClosed += Ordenes_FormClosed;
            frmAddOrder.Show();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Por favor, ingresa un OrderID.");
                return;
            }


            int orderIdToSearch;
            if (!int.TryParse(txtOrderID.Text, out orderIdToSearch))
            {
                MessageBox.Show("Por favor, ingresa un OrderID válido.");
                return;
            }


            bool orderFound = false;

            foreach (DataGridViewRow row in dtgOrders.Rows)
            {

                if (Convert.ToInt32(row.Cells["OrderID"].Value) == orderIdToSearch)
                {

                    row.Selected = true;
                    dtgOrders.FirstDisplayedScrollingRowIndex = row.Index;
                    orderFound = true;
                    break;
                }
            }

            if (!orderFound)
            {
                MessageBox.Show("No se encontró la orden con el ID proporcionado.");
            }
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          /*  if (dtgOrders.SelectedRows.Count > 0)
            {
                FrmAddOrder edit = new FrmAddOrder(
                    dtgOrders[0, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[1, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[2, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[3, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[4, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[5, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[6, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[7, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[8, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[9, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[10, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[11, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[12, dtgOrders.SelectedRows[0].Index].Value.ToString(),
                    dtgOrders[13, dtgOrders.SelectedRows[0].Index].Value.ToString());
                edit.ShowDialog();
                cargarDatosOrders();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro", "Sistema", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }*/
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dtgOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string x = dtgOrders[0, dtgOrders.SelectedRows[0].Index].Value.ToString();

            // Confirmar eliminación
            if (MessageBox.Show("¿Deseas eliminar a " +
                dtgOrders[1, dtgOrders.SelectedRows[0].Index].Value.ToString() + "?",
                "Confirmar eliminación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string consulta = "DELETE FROM Orders WHERE OrderID = @OrderID";

                Dictionary<string, object> parametros = new Dictionary<string, object>
                  {
                      { "@OrderID", x }
                  };

                bool s = dt.ejecutarABCModificado(consulta, parametros);

                if (s)
                {
                    MessageBox.Show("Registro eliminado con éxito.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cargarDatosOrders();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el registro.", "Sistema",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lklOrdenes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmNewOrders frm = new FrmNewOrders();
            frm.ShowDialog();
        }
    }


    /* private void FrmOrdenes_Load(object sender, EventArgs e)
     {
         cargarDatosOrders("Select * From Orders");

     }*/
    /*public void cargarDatosOrders(String comando)
    {

        dtgOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dtgOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


        Datos dt = new Datos();
        ds = dt.ejecutarConsulta(comando);
        if (ds != null)
        {
            dtgOrders.DataSource = ds.Tables[0];
        }
    }*/


    }
