using matomonial_management_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matomonial_management_system.databases
{
    internal class DatabaseOperation : DatabaseInterface
    {
        private SqlConnection conn;

        public DatabaseOperation()
        {
            conn = new Connection().getConnection();
        }
        public SqlCommand SqlCommand(String query)
        {
            SqlCommand command = new SqlCommand(query, conn);
            return command;
        }
        public int delete(string tableName,int ID)
        {
            string deleteQuery = "DELETE FROM Users WHERE ID = @ID";
            SqlCommand delete =this.SqlCommand(deleteQuery);
            delete.Parameters
                  .AddWithValue("@ID", ID);
            return delete.ExecuteNonQuery();
        }

        public int deleteAll()
        {
            return 0;
        }

        public void insert()
        {
           
        }

        public SqlDataReader select(string tableName)
        {
            string selectQuery = "SELECT * FROM "+tableName;
            //this.SqlCommand(selectQuery);

            SqlDataReader reader = this.SqlCommand(selectQuery).ExecuteReader();
            return reader;
        }

        public void update()
        {
        
        }
    }
}
