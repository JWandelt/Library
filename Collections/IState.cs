using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IState
    {
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public float PricePerUnit { get; set; }
        public ICatalog Catalog { get; set; }
    }
}
