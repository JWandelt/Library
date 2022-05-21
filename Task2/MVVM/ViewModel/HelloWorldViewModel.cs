using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM.Model;

namespace MVVM.ViewModel
{
    // Implements INotifyPropertyChanged interface to support bindings
    public partial class HelloWorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand mUpdater;
        public HelloWorldViewModel()
        {
            //r = db.getAllReader();
            InitializeComponent();
            //DataGridReaders.ItemsSource = r;
            // DataGridBooks.ItemsSource = db.getAllBooks();
            //DataGridLent.ItemsSource = db.getAllLendList();
        }

        public ICommand buttonClicked()
        {
            TitleBox.Text = "aaa";
            return mUpdater;
            
        }


    }
}