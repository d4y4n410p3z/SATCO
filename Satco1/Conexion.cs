using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  MySql.Data.MySqlClient;

namespace Satco1
{
    class Conexion
    {
     public static MySqlConnection miConexion;

        public static MySqlConnection CrearConexion()
        {
            
            MySqlConnection miConexion = new MySqlConnection("server=localhost; Database=dimolo8_satco; uid=root; pwd=");
            miConexion.Open();
            return miConexion;
        }

    }
}
