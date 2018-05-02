using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
   public partial class DynamicsBLL:BaseBLL<Dynamics>
    {
        TaskEntities DbContext = new TaskEntities();
        public override BaseDAL<Dynamics> GetDAL()
        {
            return new DynamicsDAL();
        }

       
    }
}
