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
            if(e.PropertyName == nameof(LibraryViewModel.Title) || e.PropertyName == nameof(LibraryViewModel.AuthorFirstName) || e.PropertyName == nameof(LibraryViewModel.AuthorLastName)
              || e.PropertyName == nameof(LibraryViewModel.Description))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(libraryViewModel.Title) 
                && !string.IsNullOrEmpty(libraryViewModel.AuthorFirstName)
                && !string.IsNullOrEmpty(libraryViewModel.AuthorLastName)
                && !string.IsNullOrEmpty(libraryViewModel.Description)
                && base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            b.Service.addBook(libraryViewModel.Title, libraryViewModel.AuthorFirstName, libraryViewModel.AuthorLastName, libraryViewModel.Description, false);
            libraryViewModel.Title = null;
            libraryViewModel.AuthorFirstName = null;
            libraryViewModel.AuthorLastName = null;
            libraryViewModel.Description = null;
            libraryViewModel.RefreshBooks();
        }
    }
}
