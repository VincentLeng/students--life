using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.Entity;
using System.Linq.Expressions;

namespace DAL
{
    public partial class ActivitiesDAL : BaseDAL<Activities>
    {
        TaskEntities DbContext = new TaskEntities();
        public override Expression<Func<Activities, bool>> GetByIdKey(int id)
        {
            return u => u.ActId == id;
        }

        //    TaskEntities DbContext = new TaskEntities();
        //    public IQueryable<Activities> GetList(int pageSize, int pageIndex)
        //    {
        //        return DbContext.Set<Activities>().
        //               OrderByDescending(u => u.ActId)
        //               .Skip((pageIndex - 1)*pageSize)
        //               .Take(pageSize);
        //    }
        //    //兼职信息页的分页效果，直接return结果，查询多条兼职信息
        //    public Activities GetById(int id)
        //    {
        //        return DbContext.Set<Activities>()
        //            .Where(u => u.ActId == id)
        //            .FirstOrDefault();
        //    }
        //    //通过id查询单条的兼职信息    
        //    public int Add(Activities activities)
        //    {
        //        DbContext.Set<Activities>().Add(activities);
        //        return DbContext.SaveChanges();
        //    }
        //    //增
        //    public int Update(Activities activities)
        //    {
        //        DbContext.Set<Activities>().Attach(activities);
        //        DbContext.Entry(activities).State = EntityState.Modified;//设置状态为修改
        //        return DbContext.SaveChanges();
        //    }
        //    //改
        //    public int Remove(int id)
        //    {
        //        var activities = GetById(id);
        //        DbContext.Set<Activities>().Remove(activities);
        //        return DbContext.SaveChanges();
        //    }
        //    //删    
        public override Expression<Func<Activities, int>> GetKey()
        {
            return u => u.ActId;
        }
    }
}
