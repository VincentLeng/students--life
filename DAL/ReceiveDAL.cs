using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class ReceiveDAL:BaseDAL<Receive>
    {
        TaskEntities DbContext = new TaskEntities();

        public override Expression<Func<Receive, bool>> GetByIdKey(int id)
        {
            return u => u.ReceiveId == id;
        }

        public override Expression<Func<Receive, int>> GetKey()
        {
            return u => u.ReceiveId;
        }

    }
}
