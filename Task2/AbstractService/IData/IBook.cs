using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IData
{
    public interface IBook
    {
        string author_first_name { get; set; }
        string author_last_name { get; set; }
        decimal bookID { get; set; }
        string description { get; set; }
        bool lent { get; set; }
        string title { get; set; }
    }
}
