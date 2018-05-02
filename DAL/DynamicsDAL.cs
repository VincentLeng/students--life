using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class DynamicsDAL:BaseDAL<Dynamics>
    {
        TaskEntities DbContext = new TaskEntities();

        public override Expression<Func<Dynamics, bool>> GetByIdKey(int id)
        {
            return u => u.DynId == id;
        }

        public override Expression<Func<Dynamics, int>> GetKey()
        {
            return u => u.DynId;
        }
    }
}
