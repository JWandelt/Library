using DataLayer;
using MVVM.ViewModel;
using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayerTests
{
    internal class TestViewModel : ILibraryViewModel
    {
        List<IBook> books = new List<IBook>();
        List<IReader> registered_readers = new List<IReader>();
        List<ILendList> lend_list = new List<ILendList>();
        IDataGenerator _generator;
        public TestViewModel(IDataGenerator data)
        {
            _generator = data;
            _generator.InitializeData();
            books = _generator.Books;
            registered_readers = _generator.Readers;
            lend_list = _generator.LendLists;

            AddBookCommand = new addBookCommand(books[0], this);
            DeleteBookCommand = new removeBookCommand(this, BookID);
            EditBookCommand = new editBookCommand(this, "test");
            AddReaderCommand = new addReaderCommand(this);
            DeleteReaderCommand = new removeReaderCommand(this);
            EditReaderCommand = new editReaderCommand(this);
            LendABookCommand = new addLendListCommand(this);
            CancelBookLeaseCommand = new removeLendListCommand(this);

        }
        public string AuthorFirstName { get { return books[0].author_first_name; } set { books[0].author_first_name = value; } }
        public string AuthorLastName { get { return books[0].author_last_name; } set { books[0].author_last_name = value; } }
        public decimal BookID { get { return books[0].bookID; } set { books[0].bookID = value; } }
        public decimal BookIDToCancelLease { get { return books[0].bookID; } set { books[0].bookID = value; } }
        public decimal BookIDToLease { get { return books[0].bookID; } set { books[0].bookID = value; } }
        public decimal BookIDToRemove { get { return books[0].bookID; } set { books[0].bookID = value; } }
        public List<IBook> Books { get { return books; } set { books = value; } }

        public ICommand CancelBookLeaseCommand { get; set; }
        public ICommand AddBookCommand { get; set; }
        public ICommand AddReaderCommand { get; set; }
        public ICommand DeleteBookCommand { get; set; }
        public ICommand EditBookCommand { get; set; }
        public ICommand LendABookCommand { get; set; }
        public ICommand EditReaderCommand { get; set; }
        public ICommand DeleteReaderCommand { get; set; }

        public string Description { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal LendListID { get; set; }
        public List<ILendList> LendLists { get { return lend_list; } set { lend_list = value; } }   
        public decimal ReaderID { get; set; }
        public decimal ReaderIDToLease { get; set; }
        public decimal ReaderIDToremove { get; set; }
        public List<IReader> Readers { get { return registered_readers; } set { registered_readers = value; } }
        public IBook SelectedBook { get; set; }
        public AbstractService Service => throw new NotImplementedException();
        public string Title { get; set; }

        public void RefreshBooks()
        {
            registered_readers = _generator.Readers;
        }

        public void RefreshLendLists()
        {
            books = _generator.Books;
        }

        public void RefreshReaders()
        {
            lend_list = _generator.LendLists;
        }

        public class addBookCommand : TestCommandBase
        {
            private Book b;
            private ILibraryViewModel lb;
            public addBookCommand(IBook book, ILibraryViewModel libraryViewModel)
            {
   
                lb = libraryViewModel;
            }
            public override void Execute(object parameter)
            {
                lb.Books.Add(b);
            }
        }

        public class removeBookCommand : TestCommandBase
        {
            private ILibraryViewModel lb;
            decimal id;
            public removeBookCommand(ILibraryViewModel libraryViewModel, decimal bookID)
            {
                id = bookID;
                lb = libraryViewModel;
            }
            public override void Execute(object parameter)
            {
                IBook b = lb.Books.SingleOrDefault(x => x.bookID == id);
                lb.Books.Remove(b);
            }
        }

        public class editBookCommand : TestCommandBase
        {
            private ILibraryViewModel lb;
            private string t;

            public editBookCommand(ILibraryViewModel libraryViewModel, string title)
            {
                t = title;  
                lb = libraryViewModel;
            }
            public override void Execute(object parameter)
            {
                lb.Books.SingleOrDefault(x => x.bookID == 0).title = t;
            }
        }

        public class addReaderCommand : TestCommandBase
        {
            private ILibraryViewModel lb;
            private IReader r;

            public addReaderCommand(ILibraryViewModel libraryViewModel)
            {
                lb = libraryViewModel;
            }

            public override void Execute(object parameter)
            {
                r.readerID = lb.ReaderID;
                r.first_name = lb.FirstName;
                r.last_name = lb.LastName;
                lb.Readers.Add(r);
            }
        }

        public class removeReaderCommand : TestCommandBase
        {
            public ILibraryViewModel lb;

            public removeReaderCommand(ILibraryViewModel libraryViewModel)
            {
                lb = libraryViewModel;
            }

            public override void Execute(object parameter)
            {
                lb.Readers.Remove(lb.Readers[0]);
            }
        }

        public class editReaderCommand : TestCommandBase
        {
            private ILibraryViewModel lb;
            public editReaderCommand(ILibraryViewModel libraryViewModel)
            {
                lb = libraryViewModel;
            }

            public override void Execute(object parameter)
            {
                lb.Readers[0].last_name = "test";
            }
        }

        public class addLendListCommand : TestCommandBase
        {
            private ILibraryViewModel lb;
            private ILendList r;

            public addLendListCommand(ILibraryViewModel libraryViewModel)
            {
                lb = libraryViewModel;
            }

            public override void Execute(object parameter)
            {
                r.lend_listID = lb.LendListID;
                r.bookID = lb.BookID;
                r.readerID = lb.ReaderID;
                lb.LendLists.Add(r);
            }
        }

        public class removeLendListCommand : TestCommandBase
        {
            public ILibraryViewModel lb;

            public removeLendListCommand(ILibraryViewModel libraryViewModel)
            {
                lb = libraryViewModel;
            }

            public override void Execute(object parameter)
            {
                lb.LendLists.Remove(lb.LendLists[0]);
            }
        }

        public class editLendListCommand : TestCommandBase
        {
            private ILibraryViewModel lb;
            public editLendListCommand(ILibraryViewModel libraryViewModel)
            {
                lb = libraryViewModel;
            }

            public override void Execute(object parameter)
            {
                lb.LendLists[0].readerID = 0;
            }
        }

    }
}
