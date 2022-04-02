using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class InvoiceIn
    {
        IUser delieveredBy;
        IUser receivedBy;
        private string invoiceNumber;
        private int day;
        private int month;
        private int year;
        //product list<-----\\\


        public InvoiceIn(Supplier sender, WarehouseWorker receiver)
        {
            this.delieveredBy = sender;
            this.receivedBy = receiver;
        }

        public string getDate()
        {
            return String.Join(day.ToString(), "-", month.ToString(), "-", year.ToString());
        }
    }
}
