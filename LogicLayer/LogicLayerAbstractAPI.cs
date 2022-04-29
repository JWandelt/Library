using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public abstract class LogicLayerAbstractAPI
    {
        public static LogicLayerAbstractAPI CreateLayer(IDataGenerator generatedData) 
        {
            return new Logic(DataLayerAbstractAPI.CreateLinq2SQL(generatedData));
        }

        public abstract void sellProduct(IUser client, IUser worker, List<IState> products, string invoiceNumber, int day, int month, int year);
        public abstract void buyProduct(IUser supplier, IUser worker, List<IState> products, string invoiceNumber, int day, int month, int year);
        public abstract DataLayerAbstractAPI getData();

        public class Logic : LogicLayerAbstractAPI
        {
            public DataLayerAbstractAPI data;
            public Logic(DataLayerAbstractAPI dataLayer)
            {
                data = dataLayer;
            }

            public override void sellProduct(IUser client, IUser worker, List<IState> products, string invoiceNumber, int day, int month, int year)
            {
                float price = 0;
                foreach (IState product in products)
                {
                    price += product.PricePerUnit * product.Quantity;
                    data.removeProduct(product, product.Quantity);
                }
                IEvent invoice = new InvoiceOut(worker, client, price, invoiceNumber, day, month, year, products);
                data.addInvoiceOut(invoice);
            }

            public override void buyProduct(IUser supplier, IUser worker, List<IState> products, string invoiceNumber, int day, int month, int year)
            {
                float price = 0;
                foreach (IState product in products)
                {
                    price += product.PricePerUnit * product.Quantity;
                    data.addProductQuantity(product, product.Quantity);
                }
                IEvent invoice = new InvoiceIn(supplier, worker, price, invoiceNumber, day, month, year, products);
                data.addInvoiceIn(invoice);
            }
            public override DataLayerAbstractAPI getData()
            {
                return data;
            }
        }
        
    }
}
