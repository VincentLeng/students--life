using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public partial class UsersDAL:BaseDAL<Users>
    {
        TaskEntities DbContext = new TaskEntities();

        public override Expression<Func<Users, bool>> GetByIdKey(int id)
        {
            return u => u.UserId == id;
        }

        public override Expression<Func<Users, int>> GetKey()
        {
            return u => u.UserId;
        }
        
    }
}
