using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Commands
{
    public class AddReaderCommand : CommandBase
    {
        LibraryViewModel lb;
        ReaderModel r;

        public AddReaderCommand(LibraryViewModel libraryViewModel, ReaderModel readerModel)
        {
            lb = libraryViewModel;
            r = readerModel;

            libraryViewModel.PropertyChanged += LibraryViewModel_PropertyChanged;
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(lb.FirstName) && !string.IsNullOrEmpty(lb.LastName)
                && base.CanExecute(parameter);
        }

        private void LibraryViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(LibraryViewModel.FirstName) || e.PropertyName == nameof(LibraryViewModel.LastName))
                {
                OnCanExecutedChanged();
            }
        }

        public override void Execute(object parameter)
        {
            r.Service.addReader(lb.FirstName, lb.LastName);
            lb.FirstName = null;
            lb.LastName = null;
            lb.RefreshReaders();
        }
    }
}
