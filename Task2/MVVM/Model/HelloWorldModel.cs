using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class HelloWorldModel
    {
        AbstractService db = AbstractService.CreateLINQ2SQL();

    }
}