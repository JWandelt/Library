using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class BookModel
    {
        private readonly AbstractService service;
        public BookModel(AbstractService service)
        {
            this.service = service;
        }
        public AbstractService Service { get { return service; } } 
        public List<IBook> Books { get { return service.getAllBooks(); } }

    }
}
