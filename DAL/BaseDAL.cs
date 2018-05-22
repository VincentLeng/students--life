using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Linq.Expressions;
using System.Data.Entity;

namespace DAL
{
    public abstract partial class BaseDAL<T> //加了abstract定义成抽象类
         where T : class//定义T是一个可引用的方法
    {
    TaskEntities DbContext = new TaskEntities();
    public IQueryable<T> GetList(int pageSize, int pageIndex)
    {
        return DbContext.Set<T>()
               .OrderByDescending(GetKey())
               .Skip((pageIndex - 1) * pageSize)
               .Take(pageSize);
    }
    //兼职信息页的分页效果，直接return结果，查询多条兼职信息
    public T GetById(int id)
    {
        return DbContext.Set<T>()
               .Where(GetByIdKey(id))//鼠标放在where上面可以知道这个是返回bool类型的值
               .FirstOrDefault();
    }
    //通过id查询单条的兼职信息    
    public int Add(T t)
    {
        DbContext.Set<T>().Add(t);
        return DbContext.SaveChanges();
    }
    //增
    public int Update(T t)
    {
        DbContext.Set<T>().Attach(t);
        DbContext.Entry(t).State = EntityState.Modified;//设置状态为修改
        return DbContext.SaveChanges();
    }
    //改
    public int Remove(int id)
    {
        var t = GetById(id);
        DbContext.Set<T>().Remove(t);
        return DbContext.SaveChanges();
    }
        public IQueryable<T> GetALL()
        {                  
            return DbContext.Set<T>(); 
        }
        //删
        public abstract Expression<Func<T, int>> GetKey();
        public abstract Expression<Func<T, bool>> GetByIdKey(int id);
    }

}
