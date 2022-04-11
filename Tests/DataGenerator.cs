using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using LogicLayer;

namespace Tests
{
    public class DataGenerator
    {
        public DataLayerAbstractAPI GenerateForDataAPI()
        {
            DataLayerAbstractAPI data = DataLayerAbstractAPI.CreateLinq2SQL();

            List<Product> orderedProducts = new List<Product>();

            IUser c1 = new Client("Jakub", "Wandelt", 20, "c01", "jakub.wandelt@gmail.com", "Łódź", "Poland", "Smutna");
            IUser c2 = new Client("Mateusz", "Idec", 42, "c02", "mateusz.idec@gmail.com", "Łódź", "Poland", "Smutna");
            IUser c3 = new Client("John", "Smith", 33, "c03", "john.smith@gmail.com", "Łódź", "Poland", "Smutna");

            IUser s1 = new Supplier("Wakub", "Jandelt", 20, "s01", "wakub.jandelt@gmail.com", "Herbs");
            IUser s2 = new Supplier("Iateusz", "Mdec", 42, "s042", "iateusz.mdec@gmail.com", "Poppy");
            IUser s3 = new Supplier("Sohn", "Jmith", 33, "c03", "sohn.jmith@gmail.com", "Tables");

            IUser w1 = new WarehouseWorker("Akub", "Andelt", 20, "w01", "Delieveries");
            IUser w2 = new WarehouseWorker("Ateusz", "Dec", 42, "w042", "Testing");
            IUser w3 = new WarehouseWorker("Ohn", "Mith", 33, "w03", "Customer Support");

            Catalog ca1 = new Catalog(1, "Lemon balm", "Calming herb");
            Catalog ca2 = new Catalog(2, "Poppy", "Pretty flower");
            Catalog ca3 = new Catalog(3, "Jajowar", "Useful");

            Product p1 = new Product(1, 21, 150.0f, ca1);
            Product p2 = new Product(2, 21, 250.0f, ca2);
            Product p3 = new Product(3, 21, 150.0f, ca3);

            orderedProducts.Add(p1);
            orderedProducts.Add(p2);

            InvoiceIn invoiceIn = new InvoiceIn(s1, w1, 1000.0f, "IN/00052/2002", 31, 12, 2022, orderedProducts);
            InvoiceOut invoiceOut = new InvoiceOut(w1, c1, 750.0f, "OUT/10052/2002", 30, 12, 2022, orderedProducts);

            data.addClient(c1);
            data.addClient(c2);
            data.addClient(c3);

            data.addSupplier(s1);
            data.addSupplier(s2);
            data.addSupplier(s3);

            data.addWorker(w1);
            data.addWorker(w2);
            data.addWorker(w3);

            data.addProduct(p1);
            data.addProduct(p2);
            data.addProduct(p3);

            data.addInvoiceIn(invoiceIn);
            data.addInvoiceOut(invoiceOut);

            return data;
        }

        public LogicLayerAbstractAPI GenerateForLogicAPI()
        {
            LogicLayerAbstractAPI.Logic logic = new LogicLayerAbstractAPI.Logic(GenerateForDataAPI());
            return logic;
        }
    }
}
