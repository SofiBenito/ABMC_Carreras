using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ABMC_Carrera.Dominio;

namespace ABMC_Carrera.Datos
{
    internal class DBHelper
    {
        private SqlConnection cnn; //dependencia de uso

        public DBHelper()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
        }

        public DataTable ConsultaSQL(string strSql)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = strSql;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        public int EjecutarSQL(string strSql, CommandType type)
        {
            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = strSql;
            afectadas = cmd.ExecuteNonQuery();
            cnn.Close();

            return afectadas;
        }

        public bool confirmarCarrera(Carrera oCarrera)
        {
            bool ok = true;
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaction =null;
            try
            {
                cnn.Open();
                transaction = cnn.BeginTransaction();
                cmd.Transaction = transaction;
                cmd.Connection = cnn;
                cmd.CommandText = "pa_insertarMaestro";
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre",oCarrera.Nombre_Titulo);
                cmd.Parameters.AddWithValue("@titulo", oCarrera.Nombre_Titulo);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@IdCarrera";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                int carreraNro = (int)pOut.Value;
                SqlCommand cmDetalle;
                int idDetalle = 1;
                foreach (DetalleCarrera item in oCarrera.DetallesCarrera)
                {
                    cmDetalle = new SqlCommand();
                    cmDetalle.Transaction = transaction;
                    cmDetalle.Connection = cnn;
                    cmDetalle.CommandText = "pa_InsertarDetalle";
                    cmDetalle.CommandType = CommandType.StoredProcedure;
                    cmDetalle.Parameters.AddWithValue("@idDetalle", idDetalle);
                    cmDetalle.Parameters.AddWithValue("@IdCarrera", carreraNro);
                    cmDetalle.Parameters.AddWithValue("@IdAsignatura", item.Materia.IdAsignatura);
                    cmDetalle.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
                    cmDetalle.Parameters.AddWithValue("@anioCursado", item.AnioCursado);
                    cmDetalle.Parameters.AddWithValue("@activo", 1);
                    cmDetalle.ExecuteNonQuery();
                    idDetalle++;
                }
                transaction.Commit();

            }
            catch (Exception)
            {

                ok = false;
                transaction.Rollback();
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return ok;
        }
        public void EliminarLogico(string sp,int id)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Parameters.AddWithValue("@idCarrera",SqlDbType.Int).Value=id;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cnn.Close();
            
        }

   
    }
}
