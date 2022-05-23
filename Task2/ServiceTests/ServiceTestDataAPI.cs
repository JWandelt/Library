using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.ServiceData;

namespace ServiceTests
{
    public class ServiceTestDataAPI : AbstractDataAPI
    {
        private List<Ibook> book = new List<Ibook>();
        private List<Iregistered_reader> reader = new List<Iregistered_reader>();
        private List<Ilend_list> lendList = new List<Ilend_list>();

        public List<Ibook> Book { get { return book; } set { book = value; } }
        public List<Iregistered_reader> Reader { get { return reader; } set { reader = value; } }
        public List<Ilend_list> LendList { get { return lendList; } set { lendList = value; } }

        public override void addBook(decimal id, string title, string first_name, string last_name, string description, bool lent)
        {
            book.Add(new Book(id, title, first_name, last_name, description, false));
        }

        public override void addLendList(decimal id, decimal bookID, decimal readerID)
        {
            lendList.Add(new LendList(id, bookID, readerID));
        }

        public override void addReader(decimal id, string first_name, string last_name)
        {
            reader.Add(new Reader(first_name, last_name, id));
        }

        public override void editBook(decimal id, string title, string first_name, string last_name, string description, bool lent)
        {
            Ibook b1;
            b1 = book.SingleOrDefault(x => x.bookID == id);

            b1.title = title;
            b1.author_first_name = first_name;
            b1.author_last_name = last_name;
            b1.description = description;
            b1.lent = lent;
        }

        public override void editLendList(decimal id, decimal bookID, decimal readerID)
        {
            Ilend_list l1;
            l1 = LendList.SingleOrDefault(x => x.lend_listID == id);

            l1.bookID = bookID;
            l1.readerID = readerID;
        }

        public override void editReader(decimal id, string first_name, string last_name)
        {
            Iregistered_reader r1;
            r1 = Reader.SingleOrDefault(x => x.readerID == id);

            r1.first_name = first_name;
            r1.last_name = last_name;
        }

        public override List<decimal> GetBookIDs()
        {
            List<decimal> bookIDs = new List<decimal>();

            foreach (Ibook b in book)
            {
                bookIDs.Add(b.bookID);
            }

            return bookIDs;
        }

        public override List<Ibook> GetBooks()
        {
            return book;
        }

        public override List<Ilend_list> GetLendList()
        {
            return lendList;
        }

        public override List<decimal> GetLendListIDs()
        {
            List<decimal> lendListIDs = new List<decimal>();

            foreach (Ilend_list b in lendList)
            {
                lendListIDs.Add(b.readerID);
            }

            return lendListIDs;
        }

        public override List<decimal> GetReaderIDs()
        {
            List<decimal> readerIDs = new List<decimal>();

            foreach (Iregistered_reader b in reader)
            {
                readerIDs.Add(b.readerID);
            }

            return readerIDs;
        }

        public override List<Iregistered_reader> GetRegisteredReader()
        {
            return reader;
        }

        public override void removeBook(decimal id)
        {
            book.Remove(book.SingleOrDefault(x => x.bookID == id));
        }

        public override void removeLendList(decimal id)
        {
            lendList.Remove(lendList.SingleOrDefault(x => x.lend_listID == id));
        }

        public override void removeReader(decimal id)
        {
            reader.Remove(reader.SingleOrDefault(x => x.readerID == id));
        }
    }
}