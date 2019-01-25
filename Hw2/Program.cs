using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection (ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                
                command.CommandText = "create table groups (" +
                    "Id int identity(1,1)," +
                    "Name nvarchar(max))";

                command.Connection = connection;

                command.ExecuteNonQuery();
            }
        }
    }
}
