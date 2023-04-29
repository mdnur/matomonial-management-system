using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matomonial_management_system.databases
{
    using System.Data.SqlClient;

    public sealed class DatabaseConnection
    {
        private static readonly DatabaseConnection instance = new DatabaseConnection();
        private readonly SqlConnection connection;

        private DatabaseConnection()
        {
            string connectionString = "Data Source=DESKTOP-D428TCH\\MSSQLSERVER01;Initial Catalog=Matrimonial;Integrated Security=true;";
            connection = new SqlConnection(connectionString);
        }

        public static DatabaseConnection Instance
        {
            get
            {
                return instance;
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return connection;
            }
        }

        public DatabaseConnection Open()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            return this;
        }

        public DatabaseConnection Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
            return this;
        }
        public SqlCommand SqlComman1d(string sql)
        {
            return new SqlCommand("SELECT COUNT(*) FROM \" + table + \" WHERE email=@email AND password=@password", this.connection);
        }
    }
}
