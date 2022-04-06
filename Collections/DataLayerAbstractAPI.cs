using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public abstract class DataLayerAbstractAPI
    {
        public abstract void Connect();

        public static DataLayerAbstractAPI CreateLinq2SQL(List<IUser> clients, List<IUser> workers, List<IUser> suppliers, List<InvoiceIn> invoiceIns, List<InvoiceOut> invoiceOuts, List<Product> products)
        {
            return new Linq2SQL(clients, workers, suppliers, invoiceIns, invoiceOuts, products);
        }

        private class CatalogDictionary : Dictionary<string, Catalog>
        {

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
            public override void Connect()
            {
                throw new System.NotImplementedException();
            }

        }
    }
}