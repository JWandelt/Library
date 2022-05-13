using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class Client : IUser
    {
        private string firstName;
        private string lastName;
        private int age;
        private string id;
        private string email;
        private string city;
        private string country;
        private string street;

        public Client(string firstName, string lastName, int age, string id, string email, string city, string country, string street)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            ID = id;
            Email = email;
            City = city;
            Country = country;
            Street = street;
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string ID { get { return id; } set { id = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Country { get { return country; } set { country = value; } }
        public string Street { get { return street; } set { street = value; } }

    }
}
