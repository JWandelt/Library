using MVVM.Commands;
using MVVM.Model;
using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.ViewModel
{
    public class LibraryViewModel : ViewModelBase
    {
        AbstractService service = AbstractService.CreateLINQ2SQL();
        BookModel b;
        ReaderModel r;
        LendListModel l;
        public LibraryViewModel()
        {
            b = new BookModel(service);
            r = new ReaderModel(service);
            l = new LendListModel(service);
            AddBookCommand = new AddBookCommand(this, b);
        }
        public List<IBook> Books { get { return b.Books; } }
        public List<IReader> Readers { get { return r.Readers; } }
        public List<ILendList> LendLists { get { return l.LendLists; } }
        private string _title;
        public string Title
        {
            get 
            { 
                return _title; 
            }
            set 
            { 
                _title = value; 
                OnPropertyChanged(nameof(Title));
            }
        }

        public ICommand AddBookCommand { get; }
    }
}
