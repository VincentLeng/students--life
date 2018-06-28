using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Model;

namespace DAL
{
    public partial class PostDAL : BaseDAL<Post>
    {
        TaskEntities DbContext = new TaskEntities();

       
        public override Expression<Func<Post, int>> GetKey()
        {
            return u => u.UserId;
        }

        public override Expression<Func<Post, bool>> GetByIdKey(int id)
        {
            return u => u.UserId == id;
        }
    }

       
 
}
