using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_013
{
    internal class DBPessoa
    {
        private DB db;

        public DBPessoa()
        {
            db = new DB();
        }
        public void insert(Pessoa pessoa)
        {
            string query = "INSERT INTO Pessoa (Nome, CPF, RG) " +
                "VALUES ('" + pessoa.Nome + "', " +
                "'" + pessoa.CPF + "', " +
                "'" + pessoa.RG + "');";

            db.execute(query);
        }
    }
}
