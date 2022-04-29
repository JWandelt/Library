using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestData
{
    public class TSupplier : IUser
    {
        private string firstName;
        private string lastName;
        private int age;
        private string id;
        private string email;
        private string product;

        public TSupplier(string firstName, string lastName, int age, string id, string email, string product)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ID = id;
            Email = email;
            Product = product;

        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string ID { get { return id; } set { id = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Product { get { return product; } set { product = value; } }
    }
}
