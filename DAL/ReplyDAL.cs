using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class ReplyDAL:BaseDAL<Reply>
    {        
        TaskEntities DBContext = new TaskEntities();

        public override Expression<Func<Reply, bool>> GetByIdKey(int id)
        {
            return u => u.ReplyId == id;
        }

        public override Expression<Func<Reply, int>> GetKey()
        {
            return u => u.ReplyId;
        }
    }
}
