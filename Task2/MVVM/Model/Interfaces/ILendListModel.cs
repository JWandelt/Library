using Service;
using Service.IData;
using System.Collections.Generic;

namespace MVVM.Model
{
    public interface ILendListModel
    {
        List<ILendList> LendLists { get; }
        AbstractService Service { get; }
    }
}