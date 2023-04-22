using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_012
{
    internal interface IDB
    {
        public void init();
        public void execute(string query);

        public void openConnection();
        public void closeConnection();
    }
}
