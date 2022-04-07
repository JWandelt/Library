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
        public abstract void removeProduct(int index);

        public abstract void Connect();

        public static DataLayerAbstractAPI CreateLinq2SQL(List<IUser> clients, List<IUser> workers, List<IUser> suppliers, List<InvoiceIn> invoiceIns, List<InvoiceOut> invoiceOuts, List<Product> products)
        {
            return new Linq2SQL(clients, workers, suppliers, invoiceIns, invoiceOuts, products);
        }

        private class CatalogDictionary : Dictionary<string, Catalog>
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

        private class Linq2SQL : DataLayerAbstractAPI
        {
            private List<IUser> clients;
            private List<IUser> workers;
            private List<IUser> suppliers;
            private List<InvoiceIn> invoiceIns;
            private List<InvoiceOut> invoiceOuts;
            private List<Product> products;
            private CatalogDictionary WarehouseCatalog = new CatalogDictionary();
            public Linq2SQL(List<IUser> clients, List<IUser> workers, List<IUser> suppliers, List<InvoiceIn> invoiceIns, List<InvoiceOut> invoiceOuts, List<Product> products)
            {
                this.clients = clients;
                this.workers = workers;
                this.suppliers = suppliers;
                this.invoiceIns = invoiceIns;
                this.invoiceOuts = invoiceOuts;
                this.products = products;
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

            public override void Connect()
            {
                throw new System.NotImplementedException();
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

            public override void removeProduct(int index)
            {
                products.RemoveAt(index);
            }

            public override void removeSupplier(int index)
            {
                suppliers.RemoveAt(index);
            }

            public override void removeWorker(int index)
            {
                workers.RemoveAt(index);
            }
        }
    }
}