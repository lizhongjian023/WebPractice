using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDal
{
    public class BaseDal<T> where T : class, new()
    {
        //  获取  上下文    对实体操作类型   保存实体的操作
        HT_NewsEntities dBContext = new HT_NewsEntities();
        /// <summary>
        /// 增加信息
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Add(T t)
        {
            dBContext.Set<T>().Add(t);
            return dBContext.SaveChanges();
        }

        /// <summary>
        /// 删除 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int Update(T t)
        {
            dBContext.Entry(t).State = EntityState.Modified;
            return dBContext.SaveChanges();
        }

       /// <summary>
       /// 删除
       /// </summary>
       /// <param name="t"></param>
       /// <returns></returns>
        public int Delete(T t)
        {
            dBContext.Entry(t).State = EntityState.Deleted;
            return dBContext.SaveChanges();
        }

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<T> GetEntites(Expression<Func<T, bool>> whereLambda)
        {
            return dBContext.Set<T>().Where(whereLambda).AsQueryable();
           
        }

    }
}
