using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.TestData;

namespace Tests
{
    internal class DataTestDataAPI : DataLayerAbstractAPI
    {
        private List<IUser> clients = new List<IUser>();
        private List<IUser> workers = new List<IUser>();
        private List<IUser> suppliers = new List<IUser>();
        private List<IEvent> invoiceIns = new List<IEvent>();
        private List<IEvent> invoiceOuts = new List<IEvent>();
        private List<IState> products = new List<IState>();
        public DataTestDataAPI(IDataGenerator testData)
        {
            testData.initializeData();

            clients = testData.Clients;
            workers = testData.Workers;
            suppliers = testData.Suppliers;
            invoiceIns = testData.EventsIn;
            invoiceOuts = testData.EventsOut;
            products = testData.State;
        }
        public override List<IState> Product { get { return products; } }

        public override List<IUser> Client { get { return clients; } }

        public override List<IUser> Worker { get { return workers; } }

        public override List<IUser> Supplier { get { return suppliers; } }

        public override List<IEvent> InvoiceIn { get { return invoiceIns; } }

        public override List<IEvent> InvoiceOut { get { return invoiceOuts; } }

        public override void addClient(IUser client)
        {
            clients.Add(client);
        }

        public override void addInvoiceIn(IUser supplier, IUser worker, float price, string invoiceNumber, int day, int month, int year, List<IState> products)
        {
            invoiceIns.Add(new TInvoiceIn(supplier, worker, price, invoiceNumber, day, month, year, products));
        }

        public override void addInvoiceOut(IUser worker, IUser client, float price, string invoiceNumber, int day, int month, int year, List<IState> products)
        {
            invoiceIns.Add(new TInvoiceOut(worker, client, price, invoiceNumber, day, month, year, products));
        }

        public override void addProduct(IState product)
        {
            products.Add(product);
        }

        public override void addProductQuantity(IState product, int amount)
        {
            foreach (IState p in products)
            {
                if (p == product)
                    p.Quantity += amount;
            }
        }

        public override void addSupplier(IUser supplier)
        {
            suppliers.Add(supplier);
        }

        public override void addWorker(IUser worker)
        {
            workers.Add(worker);
        }

        public override IUser getClient(int index)
        {
            return clients[index];
        }

        public override IEvent getInvoiceIn(int index)
        {
            return invoiceIns[index];
        }

        public override IEvent getInvoiceOut(int index)
        {
            return invoiceOuts[index];
        }

        public override IState getProduct(int index)
        {
            return products[index];
        }

        public override IUser getSupplier(int index)
        {
            return suppliers[index];
        }

        public override IUser getWorker(int index)
        {
            return workers[index];
        }

        public override void removeClient(int index)
        {
            clients.RemoveAt(index);
        }

        public override void removeInvoiceIn(int index)
        {
            invoiceIns.RemoveAt(index);
        }

        public override void removeInvoiceOut(int index)
        {
            invoiceOuts.RemoveAt(index);
        }

        public override void removeProduct(IState product, int amount)
        {
            foreach (IState p in products)
            {
                if (p.ItemID == product.ItemID)
                    p.Quantity -= amount;
            }
        }

        public override void removeSupplier(int index)
        {
            suppliers.RemoveAt(index);
        }

        public override void removeWorker(int index)
        {
            workers.RemoveAt(index);
        }

        public static DataTestDataAPI bindData(IDataGenerator testData)
        {
            return new DataTestDataAPI(testData);
        }
    }
}
