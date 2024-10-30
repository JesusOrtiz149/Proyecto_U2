using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_U2
{
    public class Datos
    {
        string Con = @"Data Source = DESKTOP-U39V4L7\SQLEXPRESS;Integrated Security=true;Initial Catalog = Northwind";
        private SqlConnection Conexion()
        {
            SqlConnection conexion = new SqlConnection(Con);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataSet Ejecutar (String comando)
        {
            DataSet es = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando, Conexion());
            try
            {
                da.Fill(es);
                return es;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
