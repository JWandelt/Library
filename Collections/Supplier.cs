using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Supplier : IUser
    {
        private string firstName;
        private string lastName;
        private int age;
        private string id;
        private int capacity;
        private string email;
        private string product;

        public Supplier(string firstName, string lastName, int age, string id, int capacity, string email, string product)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ID = id;          
            Capacity = capacity;
            Email = email;
            Product = product;

        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string ID { get { return id; } set { id = value; } }      
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Product { get { return product; } set { product = value; } }
    }
}
