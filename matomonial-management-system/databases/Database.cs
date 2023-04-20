using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matomonial_management_system.databases
{
    internal sealed class Database
    {
        public static DatabaseOperation conn = new DatabaseOperation();
        public static SqlCommand sqlcommand(string queryString)
        {
            return conn.SqlCommand(queryString);
        }
        public static SqlDataReader selectAll(string tableName)
        {
           return conn.select(tableName);
        }
        public static int deleteByID(string tableName,int ID)
        {
            return conn.delete(tableName,ID);
        }

    }
}
