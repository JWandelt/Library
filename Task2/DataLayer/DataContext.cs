using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class DataContext
    {
        private static LibraryDatabaseDataContext db = new LibraryDatabaseDataContext();
        public static LibraryDatabaseDataContext getDatabase()
        {
            return db;
        }
    }
}
