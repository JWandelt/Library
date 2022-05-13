using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IEvent
    {
        IUser Sender { get; set; }
        IUser Receiver { get; set; }
        float Price { get; set; }
        string InvoiceNumber { get; set; }
        int Day { get; set; }
        int Month { get; set; }
        int Year { get; set; }
        List<IState> Products { get; set; }
    }
}
