using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTTT
{
    public class Database: DbContext
    {
        public Database(): base()
        {

        }

        public DbSet<Task> Task { get; set; }
    }
}
