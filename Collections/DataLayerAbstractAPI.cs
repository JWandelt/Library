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
        public abstract InvoiceIn getInvoiceIn(int index);
        public abstract void addInvoiceIn(InvoiceIn invoice);
        public abstract void removeInvoiceIn(int index);
        public abstract InvoiceOut getInvoiceOut(int index);
        public abstract void addInvoiceOut(InvoiceOut invoice);
        public abstract void removeInvoiceOut(int index);
        public abstract Product getProduct(int index);
        public abstract void addProduct(Product product);
        public abstract void removeProduct(Product product, int amount);
        public abstract void addProductQuantity(Product product, int amount);
        public abstract List<Product> Product { get; }
        public abstract List<IUser> Client { get; }
        public abstract List<IUser> Worker { get; }
        public abstract List<IUser> Supplier { get; }
        public abstract List<InvoiceIn> InvoiceIn { get; }
        public abstract List<InvoiceOut> InvoiceOut { get; }

        public static DataLayerAbstractAPI CreateLinq2SQL()
        {
            return new Linq2SQL();
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
            private List<InvoiceIn> invoiceIns = new List<InvoiceIn>();
            private List<InvoiceOut> invoiceOuts = new List<InvoiceOut>();
            private List<Product> products = new List<Product>();
            private CatalogDictionary WarehouseCatalog = new CatalogDictionary();
            public Linq2SQL()
            {
            }

            public override void addClient(IUser client)
            {
                clients.Add(client);
            }

            public override void addInvoiceIn(InvoiceIn invoice)
            {
                invoiceIns.Add(invoice);
            }

            public override void addInvoiceOut(InvoiceOut invoice)
            {
                invoiceOuts.Add(invoice);
            }

            public override void addProduct(Product product)
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

            public override InvoiceIn getInvoiceIn(int index)
            {
                return invoiceIns[index];
            }

            public override InvoiceOut getInvoiceOut(int index)
            {
                return invoiceOuts[index];
            }

            public override Product getProduct(int index)
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

            public override void removeProduct(Product product, int amount)
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

            public override void addProductQuantity(Product product, int amount)
            {
                foreach (Product p in products)
                {
                    if (p == product)
                        p.Quantity += amount;
                }
            }

            public override List<InvoiceIn> InvoiceIn
            {
                get { return invoiceIns; }
            }

            public override List<InvoiceOut> InvoiceOut
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

            public override List<Product> Product
            {
                get { return products; }
            }
        }
    }
}