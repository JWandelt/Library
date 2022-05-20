using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class DataAbstractAPI
    {
        //CRUD operations abstract declaration
        public abstract void addBook(string title, string first_name, string last_name, string description, bool lent);
        public abstract void removeBook(int id);
        public abstract void editBook(int id, string title, string first_name, string last_name, string description, string lent);
        public abstract void addReader(string first_name, string last_name);
        public abstract void removeReader(int id);
        public abstract void editReader(int id, string first_name, string last_name);
        public abstract void addLendList(int bookID, int readerID);
        public abstract void removeLendList(int bookID);
        public abstract void editLendList(int id, string first_name, string last_);

        public static LINQtoSQLDataContext CreateLINQ2SQL()
        {
            return DataContext.connectDatabase();
        }
        public class ProductionDataAPI : DataAbstractAPI
        {
            private LINQtoSQLDataContext db;
            ProductionDataAPI(LINQtoSQLDataContext db)
            {
                this.db = db;
            }

            public override void addBook(string title, string first_name, string last_name, string description, bool lent)
            {
                List<Ibook> books = new List<Ibook>();
                book b1 = new book();
                books.Add((Ibook)b1);
                //db.books.InsertOnSubmit(b1));
                db.SubmitChanges();
            }

            public override void addLendList(int bookID, int readerID)
            {
                throw new NotImplementedException();
            }

            public override void addReader(string first_name, string last_name)
            {
                throw new NotImplementedException();
            }

            public override void editBook(int id, string title, string first_name, string last_name, string description, string lent)
            {
                throw new NotImplementedException();
            }

            public override void editLendList(int id, string first_name, string last_)
            {
                throw new NotImplementedException();
            }

            public override void editReader(int id, string first_name, string last_name)
            {
                throw new NotImplementedException();
            }

            public override void removeBook(int id)
            {
                throw new NotImplementedException();
            }

            public override void removeLendList(int bookID)
            {
                throw new NotImplementedException();
            }

            public override void removeReader(int id)
            {
                throw new NotImplementedException();
            }
        }
    }
}
