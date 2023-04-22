using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace example_013
{
    internal class DB
    {
        private MySqlConnection _connection;

        public DB()
        {
            Init();
        }

        private void Init()
        {
            string host = "localhost";
            string port = "1234";
            string user = "root";
            string pass = "papinha123";
            string name = "DBdepartamento";

            string conn = "Server="+ host + ";" +
                          "Port=" + port + ";" +
                          "Database=" + name + ";" +
                          "Uid=" + user + ";" +
                          "Pwd= " + pass + ";" +
                          "AllowPublicKeyRetrieval= " + "true" + ";";

            _connection = new MySqlConnection(conn);
        }

        public void execute(string query)
        {
            try
            {
                _connection.Open();

                MySqlCommand c = new MySqlCommand(query, _connection);
                c.ExecuteNonQuery();

                _connection.Close();


            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
}
