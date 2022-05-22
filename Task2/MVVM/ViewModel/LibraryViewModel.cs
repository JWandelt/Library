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
        public LibraryViewModel()
        {
            b = new BookModel(service);
            AddBookCommand = new AddBookCommand(this, b);
        }
        public List<IBook> Books { get { return b.Service.getAllBooks(); } }
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
