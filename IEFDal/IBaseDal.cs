using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IEFDal
{
    public interface IBaseDal<T> where T : class, new()
    {
        int Add(T t);

        /// <summary>
        /// 删除 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Update(T t);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int Delete(T t);

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        IQueryable<T> GetEntites(Expression<Func<T, bool>> whereLambda);
    }
}
