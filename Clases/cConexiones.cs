using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Clases
{
    class cConexion
    {
        public static string CadenaConexion()
        {
            return @"Data Source=WHITELAB\SQLSERVER;Initial Catalog=dbContactos;Integrated Security=True";
        }
    }
}
