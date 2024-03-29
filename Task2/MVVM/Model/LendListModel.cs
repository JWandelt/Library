﻿using Service;
using Service.IData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class LendListModel : ILendListModel
    {
        public AbstractService service;
        public LendListModel(AbstractService service)
        {
            this.service = service;
        }
        public AbstractService Service { get { return service; } }
        public List<ILendList> LendLists { get { return service.getAllLendList(); } }
    }
}
