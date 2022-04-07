using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    internal abstract class LogicLayerAbstractAPI
    {
        public static LogicLayerAbstractAPI CreateLayer(List<IUser> clients, List<IUser> workers, List<IUser> suppliers, List<InvoiceIn> invoiceIns, List<InvoiceOut> invoiceOuts, List<Product> products) 
        {
            return new Logic(DataLayerAbstractAPI.CreateLinq2SQL(clients, workers, suppliers, invoiceIns, invoiceOuts, products));
        }

        //public abstract void addClient(IUser client);
        //public abstract void addWorker(IUser worker);
        //public abstract void addSupplier(IUser supplier);
        //public abstract void addInvoiceIn(InvoiceIn invoice);
        //public abstract void addInvoiceOut(InvoiceOut invoice);
        //public abstract void addProduct(Product product);
        //public abstract void removeClient(int index);
        //public abstract void removeWorker(int index);
        //public abstract void removeSupplier(int index);
        //public abstract void removeInvoiceIn(int index);
        //public abstract void removeInvoiceOut(int index);
        //public abstract void removeProduct(int index);
        public abstract void sellProduct(IUser client, IUser worker, List<Product> products, string invoiceNumber, int day, int month, int year);
     


        private class Logic : LogicLayerAbstractAPI
        {
            private DataLayerAbstractAPI data;
            public Logic(DataLayerAbstractAPI dataLayer)
            {
                data = dataLayer;
            }

            public override void sellProduct(IUser client, IUser worker, List<Product> products, string invoiceNumber, int day, int month, int year)
            {
                float price = 0;
                foreach(Product product in products)
                {
                    price += product.PricePerUnit * product.Quantity;
                    data.removeProduct(product, product.Quantity);
                }
                InvoiceOut invoice = new InvoiceOut(worker, client, price, invoiceNumber, day, month, year, products);
                data.addInvoiceOut(invoice);
            }
        }
    }
}
