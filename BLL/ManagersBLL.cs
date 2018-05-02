using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Linq.Expressions;


namespace BLL
{
   public partial class ManagersBLL:BaseBLL<Managers>
    {
        TaskEntities DbContext = new TaskEntities();
        public override BaseDAL<Managers> GetDAL()
        {
            return new ManagersDAL();
        }
    }
}
