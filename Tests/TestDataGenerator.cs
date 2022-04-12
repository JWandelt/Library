using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using LogicLayer;

namespace Tests
{
    public class TestDataGenerator : IDataGenerator
    {
        List<IUser> clients = new List<IUser>();
        List<IUser> workers = new List<IUser>();
        List<IUser> suppliers = new List<IUser>();
        List<IEvent> events = new List<IEvent>();
        List<IState> states = new List<IState>();

        //List<Product> orderedProducts = new List<Product>();

        internal IUser c1 = new Client("Jakub", "Wandelt", 20, "c01", "jakub.wandelt@gmail.com", "Łódź", "Poland", "Smutna");
        IUser c2 = new Client("Mateusz", "Idec", 42, "c02", "mateusz.idec@gmail.com", "Łódź", "Poland", "Smutna");
        IUser c3 = new Client("John", "Smith", 33, "c03", "john.smith@gmail.com", "Łódź", "Poland", "Smutna");

        IUser s1 = new Supplier("Wakub", "Jandelt", 20, "s01", "wakub.jandelt@gmail.com", "Herbs");
        IUser s2 = new Supplier("Iateusz", "Mdec", 42, "s042", "iateusz.mdec@gmail.com", "Poppy");
        IUser s3 = new Supplier("Sohn", "Jmith", 33, "c03", "sohn.jmith@gmail.com", "Tables");

        IUser w1 = new WarehouseWorker("Akub", "Andelt", 20, "w01", "Delieveries");
        IUser w2 = new WarehouseWorker("Ateusz", "Dec", 42, "w042", "Testing");
        IUser w3 = new WarehouseWorker("Ohn", "Mith", 33, "w03", "Customer Support");

        //Catalog ca1 = new Catalog(1, "Lemon balm", "Calming herb");
        //Catalog ca2 = new Catalog(2, "Poppy", "Pretty flower");
        //Catalog ca3 = new Catalog(3, "Jajowar", "Useful");

        //Product p1 = new Product(1, 21, 150.0f, ca1);
        //Product p2 = new Product(2, 21, 250.0f, ca2);
        //Product p3 = new Product(3, 21, 150.0f, ca3);

        //orderedProducts.Add(p1);
        //orderedProducts.Add(p2);

        //InvoiceIn invoiceIn = new InvoiceIn(s1, w1, 1000.0f, "IN/00052/2002", 31, 12, 2022, orderedProducts);
        //InvoiceOut invoiceOut = new InvoiceOut(w1, c1, 750.0f, "OUT/10052/2002", 30, 12, 2022, orderedProducts);
        public List<IUser> Clients { get { return clients; } set { Clients = value; } }
        public List<IUser> Workers { get { return workers; } set { workers = value; } }
        public List<IUser> Suppliers { get { return suppliers; } set { suppliers = value; } }
        public List<IEvent> Events { get { return events; } set { events = value; } }
        public List<IState> State { get { return states; } set { states = value; } }

        public void initializeData()
        {
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