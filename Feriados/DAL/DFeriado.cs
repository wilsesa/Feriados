using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Feriados.ENT;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feriados.DAL
{
    class DFeriado
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;

        SqlConnection conexion;
        SqlCommand cmd;
        public DataTable dt;
        public SqlDataAdapter da;

        //Metodo insertar Feriado
        public int registrarFeriado(EFeriado eFer)
        {
            int insertado = 0;
            conexion = new SqlConnection(cadenaConexion);

            try
            {
                //Abrimos a conexion
                conexion.Open();
                //Passamos o nombre do procedimento
                cmd = new SqlCommand("spInsFeriado");
                cmd.Parameters.AddWithValue("@ferId", eFer.FerId);
                cmd.Parameters.AddWithValue("@ferData", eFer.FerData);
                cmd.Parameters.AddWithValue("@ferDataCad", eFer.FerDataCad);
                //Reconoce los datos de envio al procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                //Ejecutamos el procedimeinto
                insertado = cmd.ExecuteNonQuery();
                return insertado;
            }
            catch (Exception ex )
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
