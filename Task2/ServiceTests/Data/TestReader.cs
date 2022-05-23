using DataLayer;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTests
{
    public class TestReader : IReader
    {
        private decimal _readerID;
        private string _first_name;
        private string _last_name;

        public TestReader(decimal readerID, string first_name, string last_name)
        {
            this.readerID = readerID;
            this.first_name = first_name;
            this.last_name = last_name;
        }

        public decimal readerID { get { return _readerID; } set { _readerID = value; } }
        public string first_name { get { return _first_name; } set { _first_name = value; } }
        public string last_name { get { return _last_name; } set { _last_name = value; } }
    }
}
