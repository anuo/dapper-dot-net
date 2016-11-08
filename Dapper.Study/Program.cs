using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper.Study
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var con = SQLServerHelper.GetConnection())
            {
                string query = "SELECT* FROM dbo.UserAccount WHERE Code =@Code";
                con.Query<dynamic>(query, new { @Code = "admin16" }).ToList();

            }
        }
    }
}
