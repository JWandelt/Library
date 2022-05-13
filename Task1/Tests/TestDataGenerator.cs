using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using LogicLayer;
using Tests.TestData;

namespace Tests
{
    public class TestDataGenerator : IDataGenerator
    {
        List<IUser> clients = new List<IUser>();
        List<IUser> workers = new List<IUser>();
        List<IUser> suppliers = new List<IUser>();
        List<IEvent> eventsIn = new List<IEvent>();
        List<IEvent> eventsOut = new List<IEvent>();
        List<IState> states = new List<IState>();

        IUser c1 = new TClient("Jakub", "Wandelt", 20, "c01", "jakub.wandelt@gmail.com", "Łódź", "Poland", "Smutna");
        IUser c2 = new TClient("Mateusz", "Idec", 42, "c02", "mateusz.idec@gmail.com", "Łódź", "Poland", "Smutna");
        IUser c3 = new TClient("John", "Smith", 33, "c03", "john.smith@gmail.com", "Łódź", "Poland", "Smutna");

        IUser s1 = new TSupplier("Wakub", "Jandelt", 20, "s01", "wakub.jandelt@gmail.com", "Herbs");
        IUser s2 = new TSupplier("Iateusz", "Mdec", 42, "s042", "iateusz.mdec@gmail.com", "Poppy");
        IUser s3 = new TSupplier("Sohn", "Jmith", 33, "c03", "sohn.jmith@gmail.com", "Tables");

        IUser w1 = new TWarehouseWorker("Akub", "Andelt", 20, "w01", "Delieveries");
        IUser w2 = new TWarehouseWorker("Ateusz", "Dec", 42, "w042", "Testing");
        IUser w3 = new TWarehouseWorker("Ohn", "Mith", 33, "w03", "Customer Support");

        ICatalog ca1 = new TCatalog(1, "Lemon balm", "Calming herb");
        ICatalog ca2 = new TCatalog(2, "Poppy", "Pretty flower");
        ICatalog ca3 = new TCatalog(3, "Jajowar", "Useful");

        public List<IUser> Clients { get { return clients; } set { Clients = value; } }
        public List<IUser> Workers { get { return workers; } set { workers = value; } }
        public List<IUser> Suppliers { get { return suppliers; } set { suppliers = value; } }
        public List<IEvent> EventsIn { get { return eventsIn; } set { eventsIn = value; } }
        public List<IEvent> EventsOut { get { return eventsOut; } set { eventsOut = value; } }
        public List<IState> State { get { return states; } set { states = value; } }

        public void initializeData()
        {
            IState p1 = new TProduct(1, 21, 150.0f, ca1);
            IState p2 = new TProduct(2, 21, 250.0f, ca2);
            IState p3 = new TProduct(3, 21, 150.0f, ca3);

            states.Add(p1);
            states.Add(p2);
            states.Add(p3);

            IEvent invoiceIn = new TInvoiceIn(s1, w1, 1000.0f, "IN/00052/2002", 31, 12, 2022, states);
            IEvent invoiceOut = new TInvoiceOut(w1, c1, 750.0f, "OUT/10052/2002", 30, 12, 2022, states);

            eventsOut.Add(invoiceOut);
            eventsIn.Add(invoiceIn);

            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c3);

            workers.Add(w1);
            workers.Add(w2);
            workers.Add(w3);

            suppliers.Add(s1);
            suppliers.Add(s2);
            suppliers.Add(s3);
        }
    }
}