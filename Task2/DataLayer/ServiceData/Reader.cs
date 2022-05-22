using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ServiceData
{
    public class Reader : Iregistered_reader
    {
        private decimal _readerID;
        private string _first_name;
        private string _last_name;

        public Reader(string first_name, string last_name, decimal readerID)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.readerID = readerID;
        }

        public string first_name { get { return _first_name; } set { _first_name = value; } }
        public string last_name { get { return _last_name; } set { _last_name = value; } }
        public decimal readerID { get { return _readerID; } set { _readerID = value; } }
    }
}
