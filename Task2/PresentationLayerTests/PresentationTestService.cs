using DataLayer;
using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayerTests
{
    public class PresentationTestService : AbstractService
    {
        private AbstractDataAPI data;
        public PresentationTestService(AbstractDataAPI d)
        {
            data = d;
        }

        public override List<IBook> getAllBooks()
        {
            List<Ibook> books = data.GetBooks();
            List<IBook> result = new List<IBook>();
            foreach (Ibook book in books)
            {
                result.Add(new Book(book.bookID, book.title, book.description, book.author_last_name, book.author_first_name, book.lent));
            }

            return result;
        }
        public override List<IReader> getAllReader()
        {
            //return data.GetBooks();
            List<Iregistered_reader> readers = data.GetRegisteredReader();
            List<IReader> result = new List<IReader>();
            foreach (Iregistered_reader r1 in readers)
            {
                result.Add(new Reader(r1.readerID, r1.first_name, r1.last_name));
            }

            return result;
        }

        public override List<ILendList> getAllLendList()
        {
            List<Ilend_list> lendlists = data.GetLendList();
            List<ILendList> result = new List<ILendList>();
            foreach (Ilend_list l1 in lendlists)
            {
                result.Add(new LendList(l1.lend_listID, l1.bookID, l1.readerID));
            }

            return result;
        }

        //CRUD operations implementation for the main program
        public override void addBook(string title, string first_name, string last_name, string description, bool lent)
        {
            data.addBook(findFreeBookID(), title, first_name, last_name, description, lent);

        }

        public override void addLendList(decimal bookID, decimal readerID)
        {
            data.addLendList(findFreeLendListID(), bookID, readerID);
        }

        public override void addReader(string first_name, string last_name)
        {
            data.addReader(findFreeReaderID(), first_name, last_name);
        }

        public override void editBook(decimal id, string title, string first_name, string last_name, string description, bool lent)
        {
            data.editBook(id, title, first_name, last_name, description, lent);
        }

        public override void editLendList(decimal id, decimal bookID, decimal readerID)
        {
            data.editLendList(id, bookID, readerID);
        }

        public override void editReader(decimal id, string first_name, string last_name)
        {
            data.editReader(id, first_name, last_name);
        }

        public override void removeBook(decimal id)
        {
            data.removeBook(id);

        }

        public override void removeLendList(decimal id)
        {
            data.removeLendList(id);
        }

        public override void removeReader(decimal id)
        {
            data.removeReader(id);
        }

        //Generators of free ids
        public decimal findFreeBookID()
        {
            List<decimal> ids = data.GetBookIDs();

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
                    return i;
                }
            }

            return 0;
        }

        public decimal findFreeLendListID()
        {

            List<decimal> ids = data.GetLendListIDs();

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
                    return i;
                }
            }

            return 0;
        }

        public decimal findFreeReaderID()
        {
            List<decimal> ids = data.GetReaderIDs();

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
                    return i;
                }
            }

            return 0;
        }

        public override void lendABook(decimal bookID, decimal readerID)
        {
            Ibook b1;

            //Changing the lent status of a specified book to true
            b1 = data.GetBooks().SingleOrDefault(x => x.bookID == bookID);
            data.editBook(bookID, b1.title, b1.author_first_name, b1.author_last_name, b1.description, true);

            //Creating a lendlist record
            data.addLendList(findFreeLendListID(), bookID, readerID);
        }

        public override void cancelLease(decimal lendListID)
        {
            Ibook b1;
            Ilend_list l1;
            //Changing the lent status of a specified book to false                        
            l1 = data.GetLendList().SingleOrDefault(x => x.lend_listID == lendListID);
            b1 = data.GetBooks().SingleOrDefault(x => x.bookID == l1.bookID);
            data.editBook(l1.bookID, b1.title, b1.author_first_name, b1.author_last_name, b1.description, false);

            //Removing lendlist record
            data.removeLendList(l1.lend_listID);
        }
    }
}
