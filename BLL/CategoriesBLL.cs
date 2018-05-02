using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
   public partial class CategoriesBLL:BaseBLL<Categories>
    {
        TaskEntities DbContext = new TaskEntities();
        public override BaseDAL<Categories> GetDAL()
        {
            return  new CategoriesDAL();
        }

     
    }
}
