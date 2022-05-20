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
        public abstract void editBook(int id, string title, string first_name, string last_name, string description, bool lent);
        public abstract void addReader(string first_name, string last_name);
        public abstract void removeReader(int id);
        public abstract void editReader(int id, string first_name, string last_name);
        public abstract void addLendList(int bookID, int readerID);
        public abstract void removeLendList(int bookID);
        public abstract void editLendList(int id, int bookID, int readerID);

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

            }

            public override void addReader(string first_name, string last_name)
            {
                throw new NotImplementedException();
            }

            public override void editBook(int id, string title, string first_name, string last_name, string description, bool lent)
            {
                throw new NotImplementedException();
            }

            public override void editLendList(int id, int bookID, int readerID)
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

            public decimal findFreeBookID()
            {
                decimal id;

                List<decimal> ids = new List<decimal> ();
                ids = (from book in db.books select book.bookID).ToList();

                for(int i = 0; i < 1000; i++)
                {
                    int found = 0;
                    for(int j = 0; j < ids.Count; j++)
                    {
                        if (ids[j] == i)
                            found++;
                    }
                    if(found == 0)
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
