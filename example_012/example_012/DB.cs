using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace example_012
{
    internal class DB
    {
        private NpgsqlConnection conn;

        public DB()
        {
            Initialize();
        }

        private void Initialize()
        {
            // Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;
            string server = "localhost";
            string port = "1234";
            string user = "postgres";
            string pass = "papinha123";
            string db = "pim2";

            string sconn = "Server="+ server + ";Port="+ port + ";Database="+ db + ";User Id="+ user + ";Password="+ pass + ";";

            conn = new NpgsqlConnection(sconn);

            try
            {
                conn.Open();
                Console.WriteLine("Conectado!");
                // Executar querys

                string query = "select * from dado_funcionario;";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"{reader["nome"]} - {reader["conta"]}");
                }

                conn.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
