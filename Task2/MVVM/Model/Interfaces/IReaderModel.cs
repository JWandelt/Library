using Service;
using Service.IData;
using System.Collections.Generic;

namespace MVVM.Model
{
    public interface IReaderModel
    {
        List<IReader> Readers { get; }
        AbstractService Service { get; }
    }
}