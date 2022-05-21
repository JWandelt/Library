using MVVM.ViewModel;
using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM.View
{
    /// <summary>
    /// Interaction logic for HelloWorldView.xaml
    /// </summary>
    public partial class HelloWorldView : Window
    {
        AbstractService db = AbstractService.CreateLINQ2SQL();
        List<IReader> r;
        public HelloWorldView()
        {
            r = db.getAllReader();
            InitializeComponent();
            DataGridReaders.ItemsSource = r;
            //DataGridBooks.ItemsSource = t.Books;
            DataGridLent.ItemsSource = db.getAllLendList();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
