using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Commands
{
    public class DeleteBookCommand : CommandBase
    {
        private LibraryViewModel libraryViewModel;
        private BookModel b;

        public DeleteBookCommand(LibraryViewModel libraryViewModel, BookModel b)
        {
            this.libraryViewModel = libraryViewModel;  
            this.b = b;
        }

        public override void Execute(object parameter)
        {
            b.Service.removeBook(libraryViewModel.BookIDToRemove);
            libraryViewModel.BookIDToRemove = 0;
        }
    }
}
