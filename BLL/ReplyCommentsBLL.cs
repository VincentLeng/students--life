using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
   public partial class ReplyCommentsBLL:BaseBLL<ReplyComments>
    {
        TaskEntities DbContext = new TaskEntities();
        public override BaseDAL<ReplyComments> GetDAL()
        {
            return new ReplyCommentsDAL();
        }
    }
}
