using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    internal class LogicLayerAbstractAPI
    {
        public static LogicLayerAbstractAPI CreateLayer() { }

        private class Logic : LogicLayerAbstractAPI
        {
            public Logic(DataLayerAbstractAPI dataLayer)
            {
                DataLayerAbstractAPI data = dataLayer;
            }
        }
    }
}
