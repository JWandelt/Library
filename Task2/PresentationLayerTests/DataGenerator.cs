using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayerTests
{
    public class DataGenerator : IDataGenerator
    {
        string _Title = "TestTitle";
        string _FirstName = "TestFirstName";
        string _LastName = "TestLastName";
        string _Description = "TestDescription";
        decimal _BookId = 1;
        decimal _ReaderId = 2;
        decimal _LendListId = 3;

        public string Title { get { return _Title; } set { _Title = value; } }
        public string Firstname { get { return _FirstName; } set { _FirstName = value; } }
        public string Lastname { get { return _LastName; } set { _LastName = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public decimal BookId { get { return _BookId; } set { _BookId = value; } }
        public decimal ReaderId { get { return _ReaderId; } set { _ReaderId = value; } }
        public decimal LendListId { get { return _LendListId; } set { _LendListId = value; } }

    }
}
