using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


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

        public List<IUser> Clients { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IUser> Workers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IUser> Suppliers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IEvent> EventsIn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IEvent> EventsOut { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IState> State { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
            throw new NotImplementedException();
        }
    }
}
