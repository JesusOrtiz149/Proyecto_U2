using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Proyecto_U2
{
    public class Datos
    {
        //string Con = @"Data Source = DESKTOP-U39V4L7\SQLEXPRESS;Integrated Security=true;Initial Catalog = Northwind";
        //Debajo puedes cambiar la conexion para que se conecte en tu sql, solamente cambiando lo de "DESKTOP" y los números
       //string Con = @"Data Source = LAPTOP-9P0KPF56\SQLEXPRESS04;Integrated Security=true;Initial Catalog = Northwind";
        string Con = @"Data Source = DESKTOP-3KGVR4J\SQLEXPRESS;Integrated Security=true;Initial Catalog = Northwind";
         
        SqlConnection conexion;

        private SqlConnection abrirConexion()
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

        private void cerrarConexion()
        {
            try
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }
        public bool ejecutarABC(String comando)
        {
            try
            {
                SqlCommand command = new SqlCommand(comando, abrirConexion());
                command.ExecuteNonQuery();
                cerrarConexion();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }
        public bool ejecutarABCModificado(String comando, Dictionary<string, object> parametros)
        {
            try
            {

                using (SqlCommand command = new SqlCommand(comando, abrirConexion())) { 
                    foreach(var parametro in parametros)
                    {
                        command.Parameters.AddWithValue(parametro.Key, parametro.Value ?? DBNull.Value);
                    }
                    command.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return false;
            }
        }

        public DataSet ejecutarConsulta (String comando)
        {
            DataSet es = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando, abrirConexion());
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
        public DataSet ejecutarConsultaConParametros(string query, Dictionary<string, object> parametros)
        {
            DataSet es = new DataSet();
            try
            {
                using (SqlCommand comando = new SqlCommand(query, abrirConexion()))
                {
                    
                    foreach (var parametro in parametros)
                    {
                        comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }

                  
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    da.Fill(es);
                }
                return es;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public DataSet ejecutarConsultaPS(string query, SqlParameter[] parametros = null)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9P0KPF56\\SQLEXPRESS04;Integrated Security=true;Initial Catalog=Northwind"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parametros != null)
                    {
                        cmd.Parameters.AddRange(parametros);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }


    }
}
