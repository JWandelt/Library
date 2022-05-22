using MVVM.Commands;
using MVVM.Model;
using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {
        AbstractService service = AbstractService.CreateLINQ2SQL();
        BookModel b;
        ReaderModel r;
        LendListModel l;
        public LibraryViewModel()
        {
            b = new BookModel(service);
            r = new ReaderModel(service);
            l = new LendListModel(service);
            AddBookCommand = new AddBookCommand(this, b);
            DeleteBookCommand = new DeleteBookCommand(this, b);
            EditBookCommand = new EditBookCommand(this, b);
            AddReaderCommand = new AddReaderCommand(this, r);
            //EditReaderCommand = new EditReaderCommand(this, r);
            //DeleteReaderCommand = new DeleteReaderCommand(this, r);

        }
        public List<IBook> Books { get { return b.Books; } }
        public List<IReader> Readers { get { return r.Readers; } }
        public List<ILendList> LendLists { get { return l.LendLists; } }

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
        public ICommand AddBookCommand { get; }
        public ICommand DeleteBookCommand { get; }
        public ICommand EditBookCommand { get; }
        public ICommand AddReaderCommand { get; }
        public ICommand EditReaderCommand { get; }
        public ICommand DeleteReaderCommand { get; }

    }
}
