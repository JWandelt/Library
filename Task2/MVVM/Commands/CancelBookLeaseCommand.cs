using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Commands
{
    public class CancelBookLeaseCommand : CommandBase
    {
        private LibraryViewModel libraryViewModel;
        private BookModel bookModel;
        private LendListModel lendModel;

        public CancelBookLeaseCommand(LibraryViewModel libraryViewModel, BookModel bookModel, LendListModel lendListModel)
        {
            this.libraryViewModel = libraryViewModel;
            this.bookModel = bookModel;
            this.lendModel = lendListModel;

            libraryViewModel.PropertyChanged += LibraryViewModel_PropertyChanged;
        }

        private void LibraryViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(LibraryViewModel.BookIDToCancelLease))
            {
                OnCanExecutedChanged();
            }
        }

        public override void Execute(object parameter)
        {
            libraryViewModel.Service.cancelLease(libraryViewModel.BookIDToCancelLease);
            libraryViewModel.BookIDToCancelLease = 0;
        }
    }
}
