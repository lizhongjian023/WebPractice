using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IEFBll
{
    public interface IBaseService<T> where T : class, new()
    {
        bool Update(T t);

        bool Add(T t);

        bool Delete(T t);

        IQueryable<T> GetEntities(Expression<Func<T, bool>> whereLambda);
    }
}
