using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class InvoiceIn : IEvent
    {
        IUser delieveredBy;
        IUser receivedBy;
        private string invoiceNumber;
        private int day;
        private int month;
        private int year;
        private float price;
        private List<Product> orderedProducts;


        public InvoiceIn(IUser sender, IUser receiver, float price, string invoiceNumber, int day, int month, int year, List<Product> orderedProducts)
        {
            Sender = sender;
            Receiver = receiver;
            InvoiceNumber = invoiceNumber;
            Day = day;
            Month = month;
            Year = year;
            Price = price;
            Products = orderedProducts;
        }

        public IUser Sender { get { return delieveredBy; } set { delieveredBy = value; } }
        public IUser Receiver { get { return receivedBy; } set { receivedBy = value; } }
        public string InvoiceNumber { get { return invoiceNumber; } set { invoiceNumber = value; } }
        public int Day { get { return day; } set { day = value; } }
        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }
        public float Price { get { return price; } set { price = value; } }
        public List<Product> Products { get { return orderedProducts; } set { orderedProducts = value; } }

        public string getDate()
        {
            return String.Join("-",day.ToString(),month.ToString(),year.ToString());
        }
    }
}
