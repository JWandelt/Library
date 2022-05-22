using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Commands
{
    public class AddBookCommand : CommandBase
    {
        private LibraryViewModel libraryViewModel;
        private BookModel b;

        public AddBookCommand(LibraryViewModel libraryViewModel, BookModel b)
        {
            this.libraryViewModel = libraryViewModel;
            this.b = b;

            libraryViewModel.PropertyChanged += LibraryViewModel_PropertyChanged;
        }

        private void LibraryViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(LibraryViewModel.Title))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(libraryViewModel.Title) && base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            b.Service.addBook(libraryViewModel.Title, "test", "test", "test", false);
        }
    }
}
