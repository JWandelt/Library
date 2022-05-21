using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using Service.IData;

namespace MVVM.Model
{
    internal class ReaderModel
    {
        private AbstractService service;
        public ReaderModel(AbstractService service)
        {
            this.service = service;
        }
        public AbstractService Service { get { return service; } }
        public List<IReader> Readers { get { return service.getAllReader(); } }
    }
}
