using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;

namespace DataLayer
{
    public interface Ibook
    {
        string author_first_name { get; set; }
        string author_last_name { get; set; }
        decimal bookID { get; set; }
        string description { get; set; }
        bool lent { get; set; }
        string title { get; set; }

    }
}