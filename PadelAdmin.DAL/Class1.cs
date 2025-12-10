using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadelAdmin.DAL
{
    public class Database
    {

        private static Database instance;
        private readonly string connectionString = "Server=localhost;Database=PadelAdmin;Trusted_Connection=True;";

        private Database() { }

        public static Database Instance
        {

            get
            {

                if(instance == null)
                {

                    instance = new Database();

                }

                return instance;

            }

        }

        public SqlConnection GetConnection()
        {

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            return conn;

        }

    }
}
