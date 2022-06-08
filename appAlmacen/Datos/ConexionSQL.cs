using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
   public abstract class ConexionSQL
    {
        private readonly string ConexionString;

        public ConexionSQL()
        {
            ConexionString = "Server=(local)\\SQLEXPRESS; database=GestorDb; integrated segurity=true";
        }
        protected SqlConnection GetConexion()
        {
            return new SqlConnection(ConexionString);
        }
    }
}
