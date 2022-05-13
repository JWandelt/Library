using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestData
{
    internal class TWarehouseWorker : IUser
    {
        private string firstName;
        private string lastName;
        private int age;
        private string id;
        private string responsibility;

        public TWarehouseWorker(string firstName, string lastName, int age, string id, string responsibility)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ID = id;
            Responsibility = responsibility;
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string ID { get { return id; } set { id = value; } }
        public string Responsibility { get { return responsibility; } set { responsibility = value; } }
    }
}

