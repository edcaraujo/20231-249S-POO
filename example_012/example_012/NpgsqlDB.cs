using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace example_012
{
    internal class NpgsqlDB : IDB
    {
        private NpgsqlConnection conn;
        public void init()
        {
            if (conn == null)
            {
                string server = "localhost";
                string port = "1234";
                string user = "postgres";
                string pass = "papinha123";
                string db = "pim2";

                string sconn = "Server=" + server + ";Port=" + port + ";Database=" + db + ";User Id=" + user + ";Password=" + pass + ";";

                conn = new NpgsqlConnection(sconn);
            }
        }
        public void execute(string query)
        {
            openConnection();

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            closeConnection();
        }

        public void openConnection()
        {
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public void closeConnection()
        {
            conn.Close();
        }
    }
}
