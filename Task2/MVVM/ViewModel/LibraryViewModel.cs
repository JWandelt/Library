using MVVM.Commands;
using MVVM.Model;
using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {
        private AbstractService service = AbstractService.CreateLINQ2SQL();
        private BookModel b;
        private ReaderModel r;
        private LendListModel l;
        private List<IReader> readers = new List<IReader>();
        private List<IBook> books = new List<IBook>();
        private List<ILendList> lendLists = new List<ILendList>();
        private IBook selectedBook;
        
        public LibraryViewModel()
        {
            b = new BookModel(service);
            r = new ReaderModel(service);
            l = new LendListModel(service);
            books = b.Books;
            readers = r.Readers;
            lendLists = l.LendLists;
            AddBookCommand = new AddBookCommand(this, b);
            DeleteBookCommand = new DeleteBookCommand(this, b);
            EditBookCommand = new EditBookCommand(this, b);
            AddReaderCommand = new AddReaderCommand(this, r);
            EditReaderCommand = new EditReaderCommand(this, r);
            DeleteReaderCommand = new DeleteReaderCommand(this, r);
            LendABookCommand = new LendABookCommand(this, b, l);
            CancelBookLeaseCommand = new CancelBookLeaseCommand(this, b, l);
        }
        public List<IBook> Books
        {
            get
            {
                return books;
            }
            set
            {
                books = value;
                OnPropertyChanged(nameof(Books));
            }
        }
        public List<IReader> Readers 
        { 
            get 
            { 
                return readers; 
            } 
            set
            {
                readers = value;
                OnPropertyChanged(nameof(Readers));
            }
        }
        public List<ILendList> LendLists
        {
            get
            {
                return lendLists;
            }
            set
            {
                lendLists = value;
                OnPropertyChanged(nameof(LendLists));
            }
        }

        public IBook SelectedBook
        {
            get
            {
                return selectedBook;
            }
            set
            {
                if(selectedBook != value)
                {
                    selectedBook = value;
                    OnPropertyChanged(nameof(SelectedBook));
                }
            }
        }

        public AbstractService Service { get { return service; } }

        public void RefreshReaders()
        {
            Readers = r.Readers;
        }

        public void RefreshBooks()
        {
            Books = b.Books;
        }

        public void RefreshLendLists()
        {
            LendLists = l.LendLists;
        }

        private string _title;
        public string Title
        {
            get 
            { 
                return _title; 
            }
            set 
            { 
                _title = value; 
                OnPropertyChanged(nameof(Title));
            }
        }

        private decimal _bookIDBook;
        public decimal BookID
        {
            get
            {
                return _bookIDBook;
            }
            set
            {
                _bookIDBook = value;
                OnPropertyChanged(nameof(BookID));
            }
        }

        private string _authorFirstName;
        public string AuthorFirstName
        {
            get
            {
                return _authorFirstName;
            }
            set
            {
                _authorFirstName = value;
                OnPropertyChanged(nameof(AuthorFirstName));
            }
        }

        private string _authorLastName;
        public string AuthorLastName
        {
            get
            {
                return _authorLastName;
            }
            set
            {
                _authorLastName = value;
                OnPropertyChanged(nameof(AuthorLastName));
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        private decimal _bookIDToRemove;
        public decimal BookIDToRemove
        {
            get
            {
                return _bookIDToRemove;
            }
            set
            {
                _bookIDToRemove = value;
                OnPropertyChanged(nameof(BookIDToRemove));
            }
        }

        private decimal _readerID;
        public decimal ReaderID
        {
            get
            {
                return _readerID;
            }
            set
            {
                _readerID = value; 
                OnPropertyChanged(nameof(ReaderID));
            }
        }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private decimal _readerIDToremove;
        public decimal ReaderIDToremove
        {
            get
            {
                return _readerIDToremove;
            }
            set
            {
                _readerIDToremove = value;
                OnPropertyChanged(nameof(ReaderIDToremove));
            }
        }

        private decimal _lendListID;
        public decimal LendListID
        {
            get
            {
                return _lendListID;
            }
            set
            {
                _lendListID = value;
                OnPropertyChanged(nameof(LendListID));
            }
        }

        private decimal _bookIDToLease;
        public decimal BookIDToLease
        {
            get
            {
                return _bookIDToLease;
            }
            set
            {
                _bookIDToLease = value;
                OnPropertyChanged(nameof(BookIDToLease));
            }
        }

        private decimal _readerIDToLease;
        public decimal ReaderIDToLease
        {
            get
            {
                return _readerIDToLease;
            }
            set
            {
                _readerIDToLease = value;
                OnPropertyChanged(nameof(ReaderIDToLease));
            }
        }
        private decimal _bookIDToCancelLease;
        public decimal BookIDToCancelLease
        {
            get
            {
                return _bookIDToCancelLease;
            }
            set
            {
                _bookIDToCancelLease = value;
                OnPropertyChanged(nameof(BookIDToCancelLease));
            }
        }
        public ICommand AddBookCommand { get; }
        public ICommand DeleteBookCommand { get; }
        public ICommand EditBookCommand { get; }
        public ICommand AddReaderCommand { get; }
        public ICommand EditReaderCommand { get; }
        public ICommand DeleteReaderCommand { get; }
        public ICommand LendABookCommand { get; }
        public ICommand CancelBookLeaseCommand { get; }

    } 
}
