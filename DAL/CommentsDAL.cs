using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class CommentsDAL:BaseDAL<Comments>
    {
        TaskEntities DbContext = new TaskEntities();

        public override Expression<Func<Comments, bool>> GetByIdKey(int id)
        {
            return u => u.ComId == id;
        }

        public override Expression<Func<Comments, int>> GetKey()
        {
            return u => u.ComId;
        }
    }
}
