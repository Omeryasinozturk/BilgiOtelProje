using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public static class DataConnections
    {
           //MSSQLSERVER Bağlantı Stringi
           public static string Get_MsSqlConnectionString
           {
            
             get{ return "Server = .; Database = DB_Bilgi_Hotel; Trusted_Connection = True;"; }

           }

    }
}
