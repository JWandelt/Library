using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class AbstractDataAPI
    {
        public static LINQtoSQLDataContext ConnectToDatabase()
        {
            return new ProductionDataAPI().GetDatabse();
        }

        public class ProductionDataAPI : AbstractDataAPI
        {
            LINQtoSQLDataContext db;
            public ProductionDataAPI()
            {
                db = DataContext.connectDatabase();
            }

            public LINQtoSQLDataContext GetDatabse()
            {
                return db;
            }
        }
    }
}
