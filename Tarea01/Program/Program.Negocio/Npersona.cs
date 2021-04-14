using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Program.Data;
using Program.Entidades;

namespace Program.Negocio
{
    public class Npersona
    {
        public DataTable Listar() {

            Dpersona dp = new Dpersona();

            return dp.Listar();
        }

        public string insertarData(string nombre, string apellido, int edad, string tel) {

            Persona p = new Persona() {
                nombre = nombre,
                apellido = apellido,
                edad = edad,
                tel= tel
            
            };

            Dpersona dp = new Dpersona();

            //dp.Insertar(p);



            return dp.Insertar(p);
        }

    }
}
