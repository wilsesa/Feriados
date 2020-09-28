using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Feriados.ENT;

namespace Feriados.DAL
{
    public class DEstado
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;

        SqlConnection conexion;
        SqlCommand cmd;
        public DataTable dt;
        public SqlDataAdapter da;

        //Metodo listar estado
        public DataTable listarEstado(int IdPais)
        {
            dt = new DataTable();
            conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                cmd = new SqlCommand("spSel_estado", conexion);
                cmd.Parameters.AddWithValue("@IdPais", IdPais);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
