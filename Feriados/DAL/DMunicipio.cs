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
    public class DMunicipio
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;

        SqlConnection conexion;
        SqlCommand cmd;
        public DataTable dt;
        public SqlDataAdapter da;

        //Metodo listar municipio
        public DataTable listarMunicipio(int IdEstado)
        {
            dt = new DataTable();
            conexion = new SqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                cmd = new SqlCommand("spSel_municipio", conexion);
                cmd.Parameters.AddWithValue("@idEstado", IdEstado);
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
