using System.ComponentModel;

namespace DataLayer
{
    public interface Ilend_list
    {
        book book { get; set; }
        decimal bookID { get; set; }
        decimal lend_listID { get; set; }
        decimal readerID { get; set; }
        registered_reader registered_reader { get; set; }

        event PropertyChangedEventHandler PropertyChanged;
        event PropertyChangingEventHandler PropertyChanging;
    }
}