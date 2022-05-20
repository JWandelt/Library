using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IData
{
    internal interface ILendList
    {
        decimal bookID { get; set; }
        decimal lend_listID { get; set; }
        decimal readerID { get; set; }
    }
}
