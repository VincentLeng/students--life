using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class ManagersDAL:BaseDAL<Managers>
    {
        TaskEntities DbContext = new TaskEntities();

        public override Expression<Func<Managers, bool>> GetByIdKey(int id)
        {
            return u => u.ManagerId == id;
        }

        public override Expression<Func<Managers, int>> GetKey()
        {
            return u => u.ManagerId;
        }
    }
}
