using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public partial class PostBLL : BaseBLL<Post>
    {
        TaskEntities DbContext = new TaskEntities();

        public override BaseDAL<Post> GetDAL()
        {
            return new PostDAL();
        }
    }
}
