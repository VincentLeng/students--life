using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class ReplyCommentsDAL:BaseDAL<ReplyComments>
    {
        TaskEntities DbContext = new TaskEntities();

        public override Expression<Func<ReplyComments, bool>> GetByIdKey(int id)
        {
            return u => u.ReplyId == id;
        }

        public override Expression<Func<ReplyComments, int>> GetKey()
        {
            return u => u.ReplyId;
        }
    }
}
