using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentMS_DAL
{
   public class DatabaseConnection
    {
        //public static string connString = ConfigurationManager.ConnectionStrings["connStringMirejete"].ConnectionString.ToString();
        public static string connString = ConfigurationManager.ConnectionStrings["connStringFlorentine"].ConnectionString.ToString();
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

    }
}
