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
        public ICommand AddBookCommand;
        
        public ICommand AddReaderCommand;

        public string AuthorFirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AuthorLastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BookID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BookIDToCancelLease { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BookIDToLease { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal BookIDToRemove { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IBook> Books { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICommand CancelBookLeaseCommand;

        public ICommand DeleteBookCommand => throw new NotImplementedException();

        public ICommand DeleteReaderCommand => throw new NotImplementedException();

        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICommand EditBookCommand => throw new NotImplementedException();

        public ICommand EditReaderCommand => throw new NotImplementedException();

        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICommand LendABookCommand => throw new NotImplementedException();

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
            //No need to implement this class, as it serves purpose only in GUI
            throw new NotImplementedException();
        }

        public void RefreshLendLists()
        {
            //No need to implement this class, as it serves purpose only in GUI
            throw new NotImplementedException();
        }

        public void RefreshReaders()
        {
            //No need to implement this class, as it serves purpose only in GUI
            throw new NotImplementedException();
        }
    }
}
