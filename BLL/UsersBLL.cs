﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
   public partial class UsersBLL:BaseBLL<Users>
    {
        TaskEntities DbContext = new TaskEntities();
        public override BaseDAL<Users> GetDAL()
        {
            return new UsersDAL();
        }
    }
}
