using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ServiceData
{
    public class Book : Ibook
    {
        private decimal _bookID;
        private string _title;
        private string _authorFirstName;
        private string _authorLastName;
        private string _description;
        private bool _lent;

        public Book(decimal bookID, string title, string author_first_name, string author_last_name, string description, bool lent)
        {
            this.bookID = bookID;
            this.title = title;
            this.author_first_name = author_first_name;
            this.author_last_name = author_last_name;
            this.description = description;
            this.lent = lent;
        }

        public decimal bookID { get { return _bookID; } set { _bookID = value; } }
        public string title { get { return _title; } set { _title = value; } }
        public string author_first_name { get { return _authorFirstName; } set { _authorFirstName = value;} }
        public string author_last_name { get { return _authorLastName; } set { _authorLastName = value;} }
        public string description { get { return _description; } set { _description = value; } }
        public bool lent { get { return _lent; } set { _lent = value; } }

    }
}
