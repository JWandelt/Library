using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Commands
{
    public class LendABookCommand : CommandBase
    {
        private LibraryViewModel libraryViewModel;
        private BookModel bookModel;
        private LendListModel lendModel;

        public LendABookCommand(LibraryViewModel libraryViewModel, BookModel bookModel, LendListModel lendListModel)
        {
            this.libraryViewModel = libraryViewModel;
            this.bookModel = bookModel;
            this.lendModel = lendListModel;

            libraryViewModel.PropertyChanged += LibraryViewModel_PropertyChanged;
        }

        private void LibraryViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(LibraryViewModel.BookIDToLease) || e.PropertyName == nameof(LibraryViewModel.ReaderIDToLease))
            {
                OnCanExecutedChanged();
            }
        }

        public override void Execute(object parameter)
        {
            libraryViewModel.Service.lendABook(libraryViewModel.BookIDToLease, libraryViewModel.ReaderIDToLease);
            libraryViewModel.ReaderIDToLease = 0;
            libraryViewModel.BookIDToLease = 0;
            libraryViewModel.RefreshLendLists();
            libraryViewModel.RefreshBooks();
        }
    }
}
