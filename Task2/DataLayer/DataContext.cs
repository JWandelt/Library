using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class DataContext
    {
        private static LINQtoSQLDataContext db = new LINQtoSQLDataContext();
        
        public static LINQtoSQLDataContext connectDatabase()
        {
            return db;
        }
    }
}
