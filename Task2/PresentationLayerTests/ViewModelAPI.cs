using MVVM.Commands;
using MVVM.Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace PresentationLayerTests
{
    public abstract class ViewModelAbstractAPI 
    {
        
        private BookModel b;
        private ReaderModel r;
        private LendListModel l;


        public abstract ICommand AddBookCommand(decimal id, string title, string first_name, string last_name, string description, bool lent);
        public abstract ICommand DeleteBookCommand(decimal id);
        public ICommand EditBookCommand;
        public ICommand AddReaderCommand;
        public ICommand EditReaderCommand;
        public ICommand DeleteReaderCommand;
        public ICommand LendABookCommand;
        public ICommand CancelBookLeaseCommand;

        public abstract string ReadTitle();
        public abstract string ReadFirstName();
        public abstract string ReadLastName();
        public abstract string ReadDescription();

        public class ViewModelAPI : ViewModelAbstractAPI
        {
            DataGenerator data;
            DataLayerAPI dataLayer;
            ICommand TestCommand;

            public ViewModelAPI(DataLayerAPI dataLayer, DataGenerator data)
            {
                this.dataLayer = dataLayer;
                this.data = data;
            }
            public override string ReadTitle()
            {
                return data.Title;
            }
            public override string ReadFirstName()
            {
                return data.Firstname;
            }
            public override string ReadLastName()
            {
                return data.Lastname;
            }  
            public override string ReadDescription()
            {
                return data.Description;
            }
            public override string ReadBookId()
            {
                return data.BookId;
            }
            public override ICommand AddBookCommand(decimal id, string title, string first_name, string last_name, string description, bool lent)
            {
                dataLayer.addBook(id, title, first_name, last_name, description, lent);
                return TestCommand;
               
            }
            public override ICommand DeleteBookCommand(decimal id)
            {

                dataLayer.removeBook(id);
                return TestCommand;
            }
        }

    }
}
