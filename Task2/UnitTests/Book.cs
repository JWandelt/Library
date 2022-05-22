
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace UnitTests
{
    public class Book : Ibook
    {
        private decimal _bookID;
        private string _title;
        private string _description;
        private string _author_first_name;
        private string _author_last_name;
        private bool _lent;

        public Book(decimal bookID, string title, string description, string author_last_name, string author_first_name, bool lent)
        {
            this.bookID = bookID;
            this.title = title;
            this.description = description;
            this.author_last_name = author_last_name;
            this.author_first_name = author_first_name;
            this.lent = lent;
        }

        public decimal bookID { get { return _bookID; } set { _bookID = value; } }
        public string title { get { return _title; } set { _title = value; } }
        public string description { get { return _description; } set { _description = value; } }
        public string author_last_name { get { return _author_last_name; } set { _author_last_name = value;} }
        public string author_first_name { get { return _author_first_name; } set { _author_first_name = value; } }
        public bool lent { get { return _lent; } set { _lent = value; } }

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
    }
}
