﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
   public partial class ReplyBLL:BaseBLL<Reply>
    {
        TaskEntities DbContext = new TaskEntities();
        public override BaseDAL<Reply> GetDAL()
        {
            return new DAL.ReplyDAL();
        }
    }
}
