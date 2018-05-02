using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
   public partial class ImagesDAL:BaseDAL<Images>

    {
        TaskEntities DbContext = new TaskEntities();

        public override Expression<Func<Images, bool>> GetByIdKey(int id)
        {
            return u => u.ImageId == id;
        }

        public override Expression<Func<Images, int>> GetKey()
        {
            return u => u.ImageId;
        }
    }
}
