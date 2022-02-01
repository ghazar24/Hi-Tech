using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace HiTechProject.DAL
{
    class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection connDB = new SqlConnection();
            connDB.ConnectionString = ConfigurationManager.ConnectionStrings["Hi_TechDB_Connection"].ConnectionString;
            connDB.Open();
            return connDB;

        }
    }
}
