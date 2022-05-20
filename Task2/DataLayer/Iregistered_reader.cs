using System.ComponentModel;
using System.Data.Linq;

namespace DataLayer
{
    public interface Iregistered_reader
    {
        string first_name { get; set; }
        string last_name { get; set; }
        EntitySet<lend_list> lend_lists { get; set; }
        decimal readerID { get; set; }

        event PropertyChangedEventHandler PropertyChanged;
        event PropertyChangingEventHandler PropertyChanging;
    }
}