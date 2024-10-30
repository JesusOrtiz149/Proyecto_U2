using System.Data;

namespace Proyecto_U2
{
    public partial class Form1 : Form
    {
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        public void cargarDatos(String comando)
        {
            Datos dt = new Datos();
            ds = dt.Ejecutar(comando);
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos("Select * From Territories");   
        }
    }
}
