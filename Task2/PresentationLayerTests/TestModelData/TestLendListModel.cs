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
    public class TestLendListModel : ILendListModel
    {
        public AbstractService service;
        public TestLendListModel(AbstractService service)
        {
            this.service = service;
        }
        public AbstractService Service { get { return service; } }
        public List<ILendList> LendLists { get { return service.getAllLendList(); } }
    }
}
