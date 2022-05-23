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
            DataGenerator Data;
            ICommand TestCommand;
            
            public ViewModelAPI(DataGenerator Data)
            {
                this.Data = Data;
            }
            public override string ReadTitle()
            {
                return Data.Title;
            }
            public override string ReadFirstName()
            {
                return Data.Firstname;
            }
            public override string ReadLastName()
            {
                return Data.Lastname;
            }  
            public override string ReadDescription()
            {
                return Data.Lastname;
            }
            public override ICommand AddBookCommand(decimal id, string title, string first_name, string last_name, string description, bool lent)
            {
                return TestCommand;
               
            }
            public override ICommand DeleteBookCommand(decimal id)
            {

                return TestCommand;

            }
        }

    }
}
