using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.IBLL
{
    public interface IBaseService<T> where T : class, new()
    {
        bool Add(T t);
        bool Delete(T t);
        bool Update(T t);
        T GetModel(Expression<Func<T, bool>> WhereLambda);
        IQueryable<T> GetModels(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> GetModelsByPage<type>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, type>> OrderByLambda, Expression<Func<T, bool>> WhereLambda);
    }
}
