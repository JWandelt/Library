using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace UnitTests
{
    public class DataLayerAPI: AbstractDataAPI
    {
        private List<Book> book = new List<Book>();
        private List<Reader> reader = new List<Reader>();

        public List<Book> Book { get { return book; } }      
        public List<Reader> Reader { get { return reader; } }      
    }
}
