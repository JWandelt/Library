using MVVM.Commands;
using MVVM.Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace PresentationLayerTests
{
    public class ViewModelAPI 
    {
        
        private BookModel b;
        private ReaderModel r;
        private LendListModel l;


        public ICommand AddBookCommand;
        public ICommand DeleteBookCommand;
        public ICommand EditBookCommand;
        public ICommand AddReaderCommand;
        public ICommand EditReaderCommand;
        public ICommand DeleteReaderCommand;
        public ICommand LendABookCommand;
        public ICommand CancelBookLeaseCommand;

    }
}
