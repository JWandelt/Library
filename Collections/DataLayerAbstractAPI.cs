using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class DataLayerAbstractAPI
    {
        public abstract IUser getClient(int index);
        public abstract void addClient(IUser client);
        public abstract void removeClient(int index);
        public abstract IUser getWorker(int index);
        public abstract void addWorker(IUser worker);
        public abstract void removeWorker(int index);
        public abstract IUser getSupplier(int index);
        public abstract void addSupplier(IUser supplier);
        public abstract void removeSupplier(int index);
        public abstract IEvent getInvoiceIn(int index);
        public abstract void addInvoiceIn(IEvent invoice);
        public abstract void removeInvoiceIn(int index);
        public abstract IEvent getInvoiceOut(int index);
        public abstract void addInvoiceOut(IEvent invoice);
        public abstract void removeInvoiceOut(int index);
        public abstract IState getProduct(int index);
        public abstract void addProduct(IState product);
        public abstract void removeProduct(IState product, int amount);
        public abstract void addProductQuantity(IState product, int amount);
        public abstract List<IState> Product { get; }
        public abstract List<IUser> Client { get; }
        public abstract List<IUser> Worker { get; }
        public abstract List<IUser> Supplier { get; }
        public abstract List<IEvent> InvoiceIn { get; }
        public abstract List<IEvent> InvoiceOut { get; }

        public static DataLayerAbstractAPI CreateLinq2SQL(IDataGenerator data)
        {
            return new Linq2SQL(data);
        }

        public class CatalogDictionary : Dictionary<string, Catalog>
        {
            private readonly Dictionary<string, Catalog> products = new Dictionary<string, Catalog>();
            private void AddDictionary(string id,Catalog c)
            {
                products.Add(id, c);
            }
            private void RemoveDictionary(string id) 
            { 
                products.Remove(id); 
            }
        }

        public class Linq2SQL : DataLayerAbstractAPI
        {
            private List<IUser> clients = new List<IUser>();
            private List<IUser> workers = new List<IUser>();
            private List<IUser> suppliers = new List<IUser>();
            private List<IEvent> invoiceIns = new List<IEvent>();
            private List<IEvent> invoiceOuts = new List<IEvent>();
            private List<IState> products = new List<IState>();
            private CatalogDictionary WarehouseCatalog = new CatalogDictionary();
            public Linq2SQL(IDataGenerator data)
            {
                throw new NotImplementedException();
            }

            public override void addClient(IUser client)
            {
                clients.Add(client);
            }

            public override void addInvoiceIn(IEvent invoice)
            {
                invoiceIns.Add(invoice);
            }

            public override void addInvoiceOut(IEvent invoice)
            {
                invoiceOuts.Add(invoice);
            }

            public override void addProduct(IState product)
            {
                products.Add(product);
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
                foreach(Product p in products)
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

            public override void addProductQuantity(IState product, int amount)
            {
                foreach (Product p in products)
                {
                    if (p == product)
                        p.Quantity += amount;
                }
            }

            public override List<IEvent> InvoiceIn
            {
                get { return invoiceIns; }
            }

            public override List<IEvent> InvoiceOut
            {
                get { return invoiceOuts; }
            }

            public override List<IUser> Client
            {
                get { return clients; }
            }

            public override List<IUser> Worker
            {
                get { return workers; }
            }

            public override List<IUser> Supplier
            {
                get { return suppliers; }
            }

            public override List<IState> Product
            {
                get { return products; }
            }
        }
    }
}