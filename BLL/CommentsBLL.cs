using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public partial class CommentsBLL:BaseBLL<Comments>
    {
        TaskEntities DbContext = new TaskEntities();
        public override BaseDAL<Comments> GetDAL()
        {
            return new CommentsDAL();
        }
    }
}
