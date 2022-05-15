using System.ComponentModel;

namespace DataLayer
{
    public interface IBook
    {
        string author_firstName { get; set; }
        string author_lastName { get; set; }
        decimal book_id { get; set; }
        string long_description { get; set; }

        event PropertyChangedEventHandler PropertyChanged;
        event PropertyChangingEventHandler PropertyChanging;
    }
}