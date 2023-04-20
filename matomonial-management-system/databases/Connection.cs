using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matomonial_management_system.databases
{
    internal sealed class Connection
    {
        private SqlConnection connection;

        public Connection()
        {
           // string connectionString = "Data Source=DESKTOP-D428TCH\\MSSQLSERVER01;Initial Catalog=Matrimonial;User ID=DESKTOP-D428TCH\\mdnur;Password=";
            string connectionString = "Data Source=DESKTOP-D428TCH\\MSSQLSERVER01;Initial Catalog=Matrimonial;Integrated Security=true;";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("Database connection successful.");
                }
                else
                {
                    MessageBox.Show("Database connection failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        public SqlConnection getConnection()
        {
           return this.connection;
        }
    }
}
