using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Tests.TestData;

namespace Tests
{
    internal class RandomTestDataGenerator : IDataGenerator
    {

        private static Random rng = new Random();

        public void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        List<IUser> clients = new List<IUser>();
        List<IUser> workers = new List<IUser>();
        List<IUser> suppliers = new List<IUser>();
        List<IEvent> eventsIn = new List<IEvent>();
        List<IEvent> eventsOut = new List<IEvent>();
        List<IState> states = new List<IState>();

        List<String> name = new List<String> { "Jack","John","James","Saul"};
        List<String> surname = new List<String> { "Ripper","Smith","Johnson","Goodman"};
        List<String> email = new List<String> { "example@gmail.com","example2@gmail.com"};
        List<String> city = new List<String> { "Łódź","Warsaw"};
        List<String> product = new List<String> { "Almonds","Walnuts","Coffee","Macadamia nuts"};
        List<String> productDescription = new List<String> { "100g","200g","Tasty arabica","Heavy on your wallet"};

        public List<IUser> Clients { get { return clients; } set { Clients = value; } }
        public List<IUser> Workers { get { return workers; } set { workers = value; } }
        public List<IUser> Suppliers { get { return suppliers; } set { suppliers = value; } }
        public List<IEvent> EventsIn { get { return eventsIn; } set { eventsIn = value; } }
        public List<IEvent> EventsOut { get { return eventsOut; } set { eventsOut = value; } }
        public List<IState> State { get { return states; } set { states = value; } }

        public void randomizeData()
        {
            Shuffle(name);
            Shuffle(surname);
            Shuffle(email);
            Shuffle(city);
            Shuffle(product);
            Shuffle(productDescription);
        }

        public void initializeData()
        {
            Clients.Add(new TClient(name[0], surname[0], 12, "C01", email[0], city[0], "Poland", "Grocka"));
            Clients.Add(new TClient(name[1], surname[1], 12, "C02", email[1], city[1], "Poland", "Piotrkowska"));
            Clients.Add(new TClient(name[2], surname[2], 12, "C02", email[2], city[2], "Poland", "Zielona"));
        }
    }
}
