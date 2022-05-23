using MVVM.Model;
using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayerTests.TestModelData
{
    public class TestReaderModel : IReaderModel
    {
        private AbstractService service;
        public TestReaderModel(AbstractService service)
        {
            this.service = service;
        }
        public AbstractService Service { get { return service; } }
        public List<IReader> Readers { get { return service.getAllReader(); } }
    }
}
