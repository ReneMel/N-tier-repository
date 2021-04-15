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
                if (con.State == ConnectionState.Open)
                    con.Close();

            }

        }

        public String Insertar(Persona Obj) {
            string res = "";
            SqlConnection con = new SqlConnection();

            SqlParameter[] parameters= { 
                new SqlParameter(){ 
                    ParameterName= "@nombre",
                    Value = Obj.nombre,
                    SqlDbType= SqlDbType.VarChar
                },
                new SqlParameter(){
                    ParameterName= "@apellido",
                    Value = Obj.apellido,
                    SqlDbType= SqlDbType.VarChar
                },
                new SqlParameter(){
                    ParameterName= "@edad",
                    Value = Obj.edad,
                    SqlDbType= SqlDbType.Int
                },
                new SqlParameter(){
                    ParameterName= "@tel",
                    Value = Obj.tel,
                    SqlDbType= SqlDbType.VarChar
                },
            };

            try
            {
                con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("insertar_persona", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(parameters);
                con.Open();

                if (cmd.ExecuteNonQuery() == 1)
                    res = "Insertado con Exito";
                else
                    res = "Usuario no Insertado";

            }
            catch (Exception e)
            {
                res = e.Message;
            }
            finally {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return res;
        }
    }
}
