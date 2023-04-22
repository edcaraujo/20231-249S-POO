using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_012
{
    internal class CargoDB
    {
        private IDB DB { get; set; }

        public CargoDB(IDB db)
        {
            DB = db; 
            
            db.init();
        }

        public void insert(Cargo cargo)
        {
            string query = "INSERT INTO cargo (id,nome) values (16,'" + cargo.Name + "');";

            DB.execute(query);
        }
    }
}
