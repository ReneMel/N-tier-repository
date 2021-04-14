using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Program.Entidades;
using System.Data.SqlClient;

namespace Program.Data
{
    public class Dpersona
    {
        public DataTable Listar() {

            SqlDataReader res;
            DataTable tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("listar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                res = cmd.ExecuteReader();
                tabla.Load(res);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            
            }

        }

        public String Insertar(Persona Obj) { 

        }
    }
}
