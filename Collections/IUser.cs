using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; } 
        string ID { get; set; }

    }
}
