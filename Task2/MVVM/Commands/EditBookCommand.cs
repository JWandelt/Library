using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Commands
{
    public class EditBookCommand : CommandBase
    {
        LibraryViewModel lb;
        BookModel b;

        public EditBookCommand(LibraryViewModel libraryViewModel, BookModel bookModel)
        {
            lb = libraryViewModel;
            b = bookModel;

            lb.PropertyChanged += Lb_PropertyChanged;
        }

        private void Lb_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(LibraryViewModel.Title) || e.PropertyName == nameof(LibraryViewModel.AuthorFirstName) || e.PropertyName == nameof(LibraryViewModel.AuthorLastName)
              || e.PropertyName == nameof(LibraryViewModel.Description) || e.PropertyName == nameof(LibraryViewModel.BookID))
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(lb.Title)
                && !string.IsNullOrEmpty(lb.AuthorFirstName)
                && !string.IsNullOrEmpty(lb.AuthorLastName)
                && !string.IsNullOrEmpty(lb.Description)
                && base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            b.Service.editBook(lb.BookID, lb.Title, lb.AuthorFirstName, lb.AuthorLastName, lb.Description, b.Books.SingleOrDefault(x => x.bookID == lb.BookID).lent);
            lb.BookID = 0;
            lb.Title = null;
            lb.AuthorFirstName = null;
            lb.AuthorLastName = null;
            lb.Description = null;
        }
    }
}
