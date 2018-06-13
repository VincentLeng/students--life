using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public partial class ReceiveBLL : BaseBLL<Receive>
    {
        TaskEntities DbContext = new TaskEntities();

        public override BaseDAL<Receive> GetDAL()
        {
            return new ReceiveDAL();
        }
    }
}
