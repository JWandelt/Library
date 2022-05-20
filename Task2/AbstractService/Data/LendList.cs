using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Data
{
    public class LendList : ILendList
    {
        private decimal _bookID;
        private decimal _lend_listID;
        private decimal _readerID;

        public decimal bookID { get { return _bookID; } set { _bookID = value; } }
        public decimal lend_listID { get { return _lend_listID; } set { _lend_listID = value;} }
        public decimal readerID { get { return _readerID; } set { _readerID = value;} }
        
    }
}
