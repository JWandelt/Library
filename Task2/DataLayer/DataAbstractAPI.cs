using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class DataAbstractAPI
    {
        public abstract void AddLentBook();
        public abstract void AddBookOnHand();
        public abstract void RemoveLentBook();
        public abstract void RemoveBookOnHand();
        //public static LibraryDatabaseDataContext CreateLINQ2SQL()
        //{
        //    return DataContext.getDatabase();
        //}
        public class ProductionDataAPI : DataAbstractAPI
        {
            public override void AddBookOnHand()
            {
                throw new NotImplementedException();
            }

            public override void AddLentBook()
            {
                throw new NotImplementedException();
            }

            public override void RemoveBookOnHand()
            {
                throw new NotImplementedException();
            }

            public override void RemoveLentBook()
            {
                throw new NotImplementedException();
            }
        }
    }
}
