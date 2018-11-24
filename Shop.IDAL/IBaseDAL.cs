﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.IDAL
{
    public interface IBaseDAL<T> where T : class, new()
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        T GetModel(Expression<Func<T, bool>> WhereLambda);
        IQueryable<T> GetModels(Expression<Func<T, bool>> whereLamda);
        IQueryable<T> GetModelsByPage<type>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, type>> OrderByLambda, Expression<Func<T, bool>> WhereLambda);

        /// <summary>
        /// 一个业务中有可能涉及到对多张表的操作,那么可以将操作的数据,打上相应的标记,最后调用该方法,将数据一次性提交到数据库中,避免了多次链接数据库。
        /// </summary>
        bool SaveChanges();
    }
}
