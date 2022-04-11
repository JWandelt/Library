using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class InvoiceOut
    {
        IUser sentBy;
        IUser receivedBy;
        private string invoiceNumber;
        private int day;
        private int month;
        private int year;
        private float price;
        private List<Product> sentProducts;

        public InvoiceOut(IUser worker, IUser receiver, float price, string invoiceNumber, int day, int month, int year, List<Product> products)
        {
            this.sentBy = worker;
            this.receivedBy = receiver;
            Price = price;
            InvoiceNumber = invoiceNumber;
            Day = day;
            Month = month;
            Year = year;
            SentProducts = products;

        }

        public IUser SentBy { get { return sentBy; } set { sentBy = value; } }
        public IUser ReceivedBy { get { return receivedBy; } set { receivedBy = value; } }
        public string InvoiceNumber { get { return invoiceNumber; } set { invoiceNumber = value; } }
        public int Day { get { return day; } set { day = value; } }
        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }
        public float Price { get { return price; } set { price = value; } }
        public List<Product> SentProducts { get { return sentProducts; } set { sentProducts = value;} }

        public string getDate()
        {
            return String.Join("-", day.ToString(), month.ToString(), year.ToString());
        }

    }
}
