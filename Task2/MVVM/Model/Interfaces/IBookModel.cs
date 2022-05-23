using Service;
using Service.IData;
using System.Collections.Generic;

namespace MVVM.Model
{
    public interface IBookModel
    {
        List<IBook> Books { get; }
        AbstractService Service { get; }
    }
}