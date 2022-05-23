using DataLayer;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayerTests
{
    public class DataGenerator : IDataGenerator
    {
        List<IBook> books = new List<IBook>();
        List<IReader> registered_readers = new List<IReader>();
        List<ILendList> lend_list = new List<ILendList>();

        string _Title = "TestTitle";
        string _FirstName = "TestFirstName";
        string _LastName = "TestLastName";
        string _Description = "TestDescription";
        decimal _BookId = 0;
        decimal _ReaderId = 0;
        decimal _LendListId = 0;

        public string Title { get { return _Title; } set { _Title = value; } }
        public string Firstname { get { return _FirstName; } set { _FirstName = value; } }
        public string Lastname { get { return _LastName; } set { _LastName = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public decimal BookId { get { return _BookId; } set { _BookId = value; } }
        public decimal ReaderId { get { return _ReaderId; } set { _ReaderId = value; } }
        public decimal LendListId { get { return _LendListId; } set { _LendListId = value; } }
        public List<IBook> Books { get { return books; } }
        public List<IReader> Readers { get { return registered_readers; } }
        public List<ILendList> LendLists { get { return lend_list; } }

        public void InitializeData()
        {
            books.Add(new Book(BookId, Title, Description, Lastname, Firstname, false));
            registered_readers.Add(new Reader(ReaderId, Firstname, Lastname));
            lend_list.Add(new LendList(LendListId, BookId, ReaderId));
        }

    }
}
