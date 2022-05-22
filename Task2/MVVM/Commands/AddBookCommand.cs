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
        }

        public override void Execute(object parameter)
        {
            b.Service.addBook(libraryViewModel.Title, "test", "test", "test", false);
        }
    }
}
