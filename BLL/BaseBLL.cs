using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
   public abstract partial  class BaseBLL<T>
          where T:class//表示T是一个可引用类型
    {
        TaskEntities DbContext = new TaskEntities();
        private BaseDAL<T> dal;
        public abstract BaseDAL<T> GetDAL();//抽象方法
        public BaseBLL()
        {
            dal = GetDAL();
        }
        public IQueryable<T> GetList(int pageSize,int pageIndex)
        {
            return dal.GetList(pageSize, pageIndex);
        }
        //分页方法
        public T GetById(int id)
        {
            return dal.GetById(id);
        }
        //查询
        public bool Add(T t)
        {
            return dal.Add(t) > 0;
        }
        //增加，大于0就表示成功
        public bool Update(T t)
        {
            return dal.Update(t) > 0;
        }
        //改
        public bool Remove(int id)
        {
            return dal.Remove(id) > 0;
        }
        //删
     }
}
