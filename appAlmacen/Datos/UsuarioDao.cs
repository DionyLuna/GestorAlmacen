using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Comun;

namespace Datos
{
    public class UsuarioDao:ConexionSQL
    {
        public bool IsLogin(string User, string Pass)
        {
            using(var conex = GetConexion())
            {
                conex.Open();
                using(var comando = new SqlCommand())
                {
                    comando.Connection = conex;
                    comando.CommandText = @"";
                }
                return true;
            }
        }
    }
}
