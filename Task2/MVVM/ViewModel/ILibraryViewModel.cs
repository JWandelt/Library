using Service;
using Service.IData;
using System.Collections.Generic;
using System.Windows.Input;

namespace MVVM.ViewModel
{
    public interface ILibraryViewModel
    {
        ICommand AddBookCommand { get; }
        ICommand AddReaderCommand { get; }
        string AuthorFirstName { get; set; }
        string AuthorLastName { get; set; }
        decimal BookID { get; set; }
        decimal BookIDToCancelLease { get; set; }
        decimal BookIDToLease { get; set; }
        decimal BookIDToRemove { get; set; }
        List<IBook> Books { get; set; }
        ICommand CancelBookLeaseCommand { get; }
        ICommand DeleteBookCommand { get; }
        ICommand DeleteReaderCommand { get; }
        string Description { get; set; }
        ICommand EditBookCommand { get; }
        ICommand EditReaderCommand { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        ICommand LendABookCommand { get; }
        decimal LendListID { get; set; }
        List<ILendList> LendLists { get; set; }
        decimal ReaderID { get; set; }
        decimal ReaderIDToLease { get; set; }
        decimal ReaderIDToremove { get; set; }
        List<IReader> Readers { get; set; }
        IBook SelectedBook { get; set; }
        AbstractService Service { get; }
        string Title { get; set; }

        void RefreshBooks();
        void RefreshLendLists();
        void RefreshReaders();
    }
}