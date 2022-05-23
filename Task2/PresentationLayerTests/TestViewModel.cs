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
        }
        public string AuthorFirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AuthorLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BookID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BookIDToCancelLease { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BookIDToLease { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BookIDToRemove { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IBook> Books { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICommand CancelBookLeaseCommand { get; set; }
        public ICommand AddBookCommand { get; set; }
        public ICommand AddReaderCommand { get; set; }
        public ICommand DeleteBookCommand { get; set; }
        public ICommand EditBookCommand { get; set; }
        public ICommand LendABookCommand { get; set; }
        public ICommand EditReaderCommand { get; set; }
        public ICommand DeleteReaderCommand { get; set; }

        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal LendListID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<ILendList> LendLists { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal ReaderID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal ReaderIDToLease { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal ReaderIDToremove { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IReader> Readers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IBook SelectedBook { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public AbstractService Service => throw new NotImplementedException();
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            private IBook b;
            private ILibraryViewModel lb;
            public addBookCommand(IBook book, ILibraryViewModel libraryViewModel)
            {
                b.bookID = book.bookID;
                b.title = book.title;
                b.author_first_name = book.author_first_name;
                b.author_last_name = book.author_last_name;
                b.description = book.description;
                b.lent = false;
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
    }
}
