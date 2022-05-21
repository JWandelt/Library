using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IData
{
    public interface IReader
    {
        decimal readerID { get; set; }
        string first_name { get; set; }
        string last_name { get; set; }
    }
}
