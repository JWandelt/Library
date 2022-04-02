using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class InvoiceOut
    {
        IUser sentBy;
        IUser receivedBy;
        private string invoiceNumber;
        private int day;
        private int month;
        private int year;
        private float price;
        //product list to be added to constructor
        InvoiceOut(WarehouseWorker worker, Client receiver, float price, string invoiceNumber, int day, int month, int year)
        {
            this.sentBy = worker;
            this.receivedBy = receiver;
            Price = price;
            Day = day;
            Month = month;
            Year = year;
        }

        public string InvoiceNumber { get { return invoiceNumber; } set { invoiceNumber = value; } }
        public int Day { get { return day; } set { day = value; } }
        public int Month { get { return month; } set { month = value; } }
        public int Year { get { return year; } set { year = value; } }
        public float Price { get { return price; } set { price = value; } }

        public string getDate()
        {
            return String.Join(day.ToString(), "-", month.ToString(), "-", year.ToString());
        }

    }
}
