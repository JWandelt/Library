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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Service;
using Service.Data;
using Service.IData;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //LINQtoSQLDataContext db = new LINQtoSQLDataContext();
        AbstractService db = AbstractService.CreateLINQ2SQL();
        List<IReader> r;

        public MainWindow()
        {    
            List<IBook> b = db.getAllBooks();
            r = db.getAllReader();
            InitializeComponent();
            //ExampleDataGrid.ItemsSource = r;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //book b1 = new book();
            //b1.bookID = 9999;
            //b1.title = "test";
            //b1.author_first_name = "test";
            //b1.author_last_name = "test";
            //b1.description = "test";
            ////b1.long_description = "test";

            //db.books.InsertOnSubmit(b1);
            db.addReader("test", "test");
        }
    }
}
