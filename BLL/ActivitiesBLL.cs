﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public partial class ActivitiesBLL : BaseBLL<Activities>
    {
        TaskEntities DbContext = new TaskEntities();
        public override BaseDAL<Activities> GetDAL()
        {
            return new ActivitiesDAL();
        }
    }
}
