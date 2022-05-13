using DataLayer;
using LogicLayer;
using System.Collections.Generic;

namespace Tests
{
    internal class TestLogicAPI : LogicLayerAbstractAPI
    {
        public static TestLogicAPI CreateLayer(TestDataGenerator generatedData)
        {
            return new TestLogicAPI(LogicTestDataAPI.bindData(generatedData));
        }
        public LogicTestDataAPI data;
        public TestLogicAPI(LogicTestDataAPI dataLayer)
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
            data.addInvoiceOut(worker, client, price, invoiceNumber, day, month, year, products);
        }

        public override void buyProduct(IUser supplier, IUser worker, List<IState> products, string invoiceNumber, int day, int month, int year)
        {
            float price = 0;
            foreach (IState product in products)
            {
                price += product.PricePerUnit * product.Quantity;
                data.addProductQuantity(product, product.Quantity);
            }

            data.addInvoiceIn(supplier, worker, price, invoiceNumber, day, month, year, products);
        }
        public override LogicTestDataAPI getData()
        {
            return data;
        }
    }
}

