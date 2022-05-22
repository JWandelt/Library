using DataLayer.ServiceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class AbstractDataAPI
    {
        public abstract void addBook(decimal id, string title, string first_name, string last_name, string description, bool lent);
        public abstract void removeBook(decimal id);
        public abstract void editBook(decimal id, string title, string first_name, string last_name, string description, bool lent);
        public abstract void addReader(decimal id, string first_name, string last_name);
        public abstract void removeReader(decimal id);
        public abstract void editReader(decimal id, string first_name, string last_name);
        public abstract void addLendList(decimal id, decimal bookID, decimal readerID);
        public abstract void removeLendList(decimal id);
        public abstract void editLendList(decimal id, decimal bookID, decimal readerID);
        public abstract List<decimal> GetBookIDs();
        public abstract List<decimal> GetReaderIDs();
        public abstract List<decimal> GetLendListIDs();
        public abstract List<Ibook> GetBooks();
        public abstract List<Iregistered_reader> GetRegisteredReader();
        public abstract List<Ilend_list> GetLendList();
        public static LINQtoSQLDataContext ConnectToDatabase()
        {
            return new ProductionDataAPI().GetDatabse();
        }

        public static ProductionDataAPI Test()
        {
            return new ProductionDataAPI();
        }

        public class ProductionDataAPI : AbstractDataAPI
        {
            LINQtoSQLDataContext db;
            public ProductionDataAPI()
            {
                db = DataContext.connectDatabase();
            }

            public override void addBook(decimal id, string title, string first_name, string last_name, string description, bool lent)
            {
                book b1 = new book();

                b1.bookID = id;
                b1.title = title;
                b1.author_first_name = first_name;
                b1.author_last_name = last_name;
                b1.description = description;
                b1.lent = false;

                db.books.InsertOnSubmit(b1);
                db.SubmitChanges();
            }

            public override void addLendList(decimal id, decimal bookID, decimal readerID)
            {
                lend_list l1 = new lend_list();

                l1.lend_listID = id;
                l1.bookID = bookID;
                l1.readerID = readerID;

                db.lend_lists.InsertOnSubmit(l1);
                db.SubmitChanges();
            }

            public override void addReader(decimal id, string first_name, string last_name)
            {
                registered_reader r1 = new registered_reader();

                r1.readerID = id;
                r1.first_name = first_name;
                r1.last_name = last_name;

                db.registered_readers.InsertOnSubmit(r1);
                db.SubmitChanges();
            }

            public override void editBook(decimal id, string title, string first_name, string last_name, string description, bool lent)
            {
                book b1 = new book();

                b1 = db.books.SingleOrDefault(x => x.bookID == id);
                b1.bookID = id;
                b1.title = title;
                b1.author_last_name = last_name;
                b1.author_first_name = first_name;
                b1.description = description;
                b1.lent = lent;

                db.SubmitChanges();
            }

            public override void editLendList(decimal id, decimal bookID, decimal readerID)
            {
                lend_list l1 = new lend_list();

                l1 = db.lend_lists.SingleOrDefault(x => x.lend_listID == id);
                l1.bookID = bookID;
                l1.readerID = readerID;

                db.SubmitChanges();
            }

            public override void editReader(decimal id, string first_name, string last_name)
            {
                registered_reader r1 = new registered_reader();

                r1 = db.registered_readers.SingleOrDefault(x => x.readerID == id);
                r1.first_name = first_name;
                r1.last_name = last_name;

                db.SubmitChanges();
            }

            public override List<decimal> GetBookIDs()
            {
                List<decimal> ids = new List<decimal>();
                ids = (from book in db.books select book.bookID).ToList();

                return ids;
            }

            public override List<Ibook> GetBooks()
            {
                //throw new NotImplementedException();
                List<book> books = db.books.ToList();
                List<Ibook> result = new List<Ibook>();

                foreach(book book in books)
                {
                    result.Add(new Book(book.bookID, book.title, book.author_first_name, book.author_last_name, book.description, book.lent));
                }

                return result;
            }

            public LINQtoSQLDataContext GetDatabse()
            {
                return db;
            }

            public override List<Ilend_list> GetLendList()
            {
                List<lend_list> lend_list = db.lend_lists.ToList();
                List<Ilend_list> result = new List<Ilend_list>();

                foreach(lend_list l in lend_list)
                {
                    result.Add(new LendList(l.bookID, l.lend_listID, l.readerID));
                }

                return result;
            }

            public override List<decimal> GetLendListIDs()
            {
                var ids = (from lend_list in db.lend_lists select lend_list.lend_listID).ToList();
                
                return ids;
            }

            public override List<decimal> GetReaderIDs()
            {
                var ids = (from registered_reader in db.registered_readers select registered_reader.readerID).ToList();

                return ids;
            }

            public override List<Iregistered_reader> GetRegisteredReader()
            {
                List<registered_reader> registered_Readers = db.registered_readers.ToList();
                List<Iregistered_reader> result = new List<Iregistered_reader>();

                foreach (registered_reader r in registered_Readers)
                {
                    result.Add(new Reader(r.first_name, r.last_name, r.readerID));
                }

                return result;
            }

            public override void removeBook(decimal id)
            {
                book b1 = new book();

                b1 = db.books.SingleOrDefault(x => x.bookID == id);

                db.books.DeleteOnSubmit(b1);
                db.SubmitChanges();
            }

            public override void removeLendList(decimal id)
            {
                lend_list l1 = new lend_list();

                l1 = db.lend_lists.SingleOrDefault(x => x.lend_listID == id);

                db.lend_lists.DeleteOnSubmit(l1);
                db.SubmitChanges();
            }

            public override void removeReader(decimal id)
            {
                registered_reader r1 = new registered_reader();

                r1 = db.registered_readers.SingleOrDefault(x => x.readerID == id);

                db.registered_readers.DeleteOnSubmit(r1);
                db.SubmitChanges();
            }

            
        }
    }
}
