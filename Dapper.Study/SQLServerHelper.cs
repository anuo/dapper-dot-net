using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data.SqlClient;
using System.Data;

namespace Dapper.Study
{
    public class SQLServerHelper
    {
        public static SqlConnection sqlServerCon;
        public static string conStr;
        public static SqlConnection GetConnection()
        {

            if (string.IsNullOrEmpty(conStr))
            {
                conStr = @"Data Source=192.168.0.3\ydlmserver;Initial Catalog=YDL;User Id=sa;Password=ydl_151001;";
            }

            sqlServerCon = new SqlConnection(conStr);
            sqlServerCon.Open();
 
            return sqlServerCon;


      
        }
    }
}
