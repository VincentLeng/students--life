using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
   public partial class CategoriesDAL:BaseDAL<Categories>
    {
        TaskEntities DbContext = new TaskEntities();

        public override Expression<Func<Categories, bool>> GetByIdKey(int id)
        {
            return u => u.CategoryId == id;
        }

        public override Expression<Func<Categories, int>> GetKey()
        {
            return u => u.CategoryId;
        }
    }
}
