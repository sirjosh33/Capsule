using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ion.Data.Linq;

namespace Capsule.Data
{
    class DataContext : DbContext
    {
        public DataContext(string server, string database, string userID, string password)
            : base(server, database, userID, password)
        {
           
        }

        public DataContext(string connectionString)
            : base(connectionString)
        {
            
        }
    }
}
