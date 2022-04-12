using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IDataGenerator
    {
        List<IUser> Clients { get; set; }
        List<IUser> Workers { get; set; }
        List<IUser> Suppliers { get; set; }
        List<IEvent> Events { get; set; }
        List<IState> State { get; set; }

        public void initializeData(); 
    }
}
