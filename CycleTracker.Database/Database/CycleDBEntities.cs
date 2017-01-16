using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTracker.Database.Database
{
    public partial class CycleDBEntities : DbContext
    {
        public CycleDBEntities(string connectionString)
           : base(string.Format ("name = {0}", connectionString))
        {
        }
    }
}
