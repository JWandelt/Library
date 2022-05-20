using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IData
{
    internal interface IReader
    {
        string first_name { get; set; }
        string last_name { get; set; }
        decimal readerID { get; set; }
    }
}
