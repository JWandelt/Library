using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace UnitTests
{
    public class DataLayerAPI
    {
        private List<Book> book = new List<Book>();
        private List<Reader> reader = new List<Reader>();
        private List<LendList> lendList = new List<LendList>();

        public List<Book> Book { get { return book; } }      
        public List<Reader> Reader { get { return reader; } }      
        public List<LendList> LendList { get { return lendList; } }

    }
}

