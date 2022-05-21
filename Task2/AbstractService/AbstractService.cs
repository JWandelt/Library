using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Service.Data;
using Service.IData;

namespace Service
{
    public abstract class AbstractService
    {
        //CRUD operations abstract declaration
        public abstract void addBook(string title, string first_name, string last_name, string description, bool lent);
        public abstract void removeBook(int id);
        public abstract void editBook(int id, string title, string first_name, string last_name, string description, bool lent);
        public abstract void addReader(string first_name, string last_name);
        public abstract void removeReader(int id);
        public abstract void editReader(int id, string first_name, string last_name);
        public abstract void addLendList(int bookID, int readerID);
        public abstract void removeLendList(int id);
        public abstract void editLendList(int id, int bookID, int readerID);
        public abstract List<IBook> getAllBooks();

        public static ProductionService CreateLINQ2SQL()
        {
            return new ProductionService(DataContext.connectDatabase());
        }

        public class ProductionService : AbstractService
        {
            private LINQtoSQLDataContext db;
            public ProductionService(LINQtoSQLDataContext db)
            {
                this.db = db;
            }
            public override List<IBook> getAllBooks()
            {
                List<book> books = db.books.ToList();
                List<IBook> result = new List<IBook>();
                foreach(book book in books)
                {
                    result.Add(new Book(book.bookID, book.title, book.description, book.author_last_name, book.author_first_name, book.lent));
                }
                return result;
            }

            //CRUD operations implementation for the main program
            public override void addBook(string title, string first_name, string last_name, string description, bool lent)
            {
                book b1 = new book();

                b1.bookID = findFreeBookID();
                b1.title = title;
                b1.author_first_name = first_name;
                b1.author_last_name = last_name;
                b1.description = description;
                b1.lent = false;

                db.books.InsertOnSubmit(b1);
                db.SubmitChanges();
            }

            public override void addLendList(int bookID, int readerID)
            {
                lend_list l1 = new lend_list();

                l1.bookID = bookID;
                l1.readerID = readerID;

                db.lend_lists.InsertOnSubmit(l1);
                db.SubmitChanges();

            }

            public override void addReader(string first_name, string last_name)
            {
                registered_reader r1 = new registered_reader();

                r1.readerID = findFreeReaderID();
                r1.first_name = first_name;
                r1.last_name = last_name;

                db.registered_readers.InsertOnSubmit(r1);
                db.SubmitChanges();
            }

            public override void editBook(int id, string title, string first_name, string last_name, string description, bool lent)
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

            public override void editLendList(int id, int bookID, int readerID)
            {
                lend_list l1 = new lend_list();

                l1 = db.lend_lists.SingleOrDefault(x => x.lend_listID == id);
                l1.bookID = bookID;
                l1.readerID = readerID;

                db.SubmitChanges();
            }

            public override void editReader(int id, string first_name, string last_name)
            {
                registered_reader r1 = new registered_reader();

                r1 = db.registered_readers.SingleOrDefault(x => x.readerID == id);
                r1.first_name = first_name;
                r1.last_name = last_name;

                db.SubmitChanges();
            }

            public override void removeBook(int id)
            {
                book b1 = new book();

                b1 = db.books.SingleOrDefault(x => x.bookID == id);

                db.books.DeleteOnSubmit(b1);
                db.SubmitChanges();

            }

            public override void removeLendList(int id)
            {
                lend_list l1 = new lend_list();

                l1 = db.lend_lists.SingleOrDefault(x => x.lend_listID == id);

                db.lend_lists.DeleteOnSubmit(l1);
                db.SubmitChanges();
            }

            public override void removeReader(int id)
            {
                registered_reader r1 = new registered_reader();

                r1 = db.registered_readers.SingleOrDefault(x => x.readerID == id);

                db.registered_readers.DeleteOnSubmit(r1);
                db.SubmitChanges();
            }

            //Generators of free ids
            public decimal findFreeBookID()
            {
                decimal id;

                List<decimal> ids = new List<decimal>();
                ids = (from book in db.books select book.bookID).ToList();

                for (int i = 0; i < 1000; i++)
                {
                    int found = 0;
                    for (int j = 0; j < ids.Count; j++)
                    {
                        if (ids[j] == i)
                            found++;
                    }
                    if (found == 0)
                    {
                        return id = i;
                    }
                }

                return 0;
            }

            public decimal findFreeLendListID()
            {
                decimal id;

                List<decimal> ids = new List<decimal>();
                ids = (from lend_list in db.lend_lists select lend_list.lend_listID).ToList();

                for (int i = 0; i < 1000; i++)
                {
                    int found = 0;
                    for (int j = 0; j < ids.Count; j++)
                    {
                        if (ids[j] == i)
                            found++;
                    }
                    if (found == 0)
                    {
                        return id = i;
                    }
                }

                return 0;
            }

            public decimal findFreeReaderID()
            {
                decimal id;

                List<decimal> ids = new List<decimal>();
                ids = (from registered_reader in db.registered_readers select registered_reader.readerID).ToList();

                for (int i = 0; i < 1000; i++)
                {
                    int found = 0;
                    for (int j = 0; j < ids.Count; j++)
                    {
                        if (ids[j] == i)
                            found++;
                    }
                    if (found == 0)
                    {
                        return id = i;
                    }
                }

                return 0;
            }


        }
    }
}
