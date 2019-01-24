using EFDal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EFBLL
{
    public abstract class BaseService<T> where T : class, new()
    {

        ////  如何获取当前实体  的  Dal   


        ///// <summary>
        ///// 构造函数，默认必须添加当前的Dal
        ///// </summary>
        //public BaseService()
        //{
        //    SetCurrentDal();
        //}

        //public BaseDal<T> CurrentDal { get; set; }

        ///// <summary>
        ///// 抽象函数，子类继承时必须实现该方法
        ///// </summary>
        //public abstract void SetCurrentDal();


        //public IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda)
        //{

        //    //  return db
        //    return null;
        //}



        BaseDal<T> baseDal = new BaseDal<T>();

        public bool Update(T t)
        {
            return baseDal.Update(t) > 0 ? true : false;
        }

        public bool Add(T t)
        {
            return baseDal.Add(t) > 0 ? true : false;
        }

        public bool Delete(T t)
        {
            return baseDal.Delete(t) > 0 ? true : false;
        }

        public IQueryable<T> GetEntities( Expression<Func< T, bool>> whereLambda)
        {
            return baseDal.GetEntites(whereLambda);
        }
    }
}
