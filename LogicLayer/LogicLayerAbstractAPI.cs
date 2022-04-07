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

        public abstract void sellProduct(IUser client, IUser worker, List<Product> products, string invoiceNumber, int day, int month, int year);
        public abstract void buyProduct(IUser supplier, IUser worker, List<Product> products, string invoiceNumber, int day, int month, int year);


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

            public override void buyProduct(IUser supplier, IUser worker, List<Product> products, string invoiceNumber, int day, int month, int year)
            {
                float price = 0;
                foreach (Product product in products)
                {
                    price += product.PricePerUnit * product.Quantity;
                    data.addProductQuantity(product, product.Quantity);
                }
                InvoiceIn invoice = new InvoiceIn(supplier, worker, price, invoiceNumber, day, month, year, products);
                data.addInvoiceIn(invoice);
            }
        }
    }
}
