﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TinDo.Data.Infrastructure
{
    public interface IQueryFluent<TEntity> where TEntity : IObjectState
    {
        IQueryFluent<TEntity> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
        IQueryFluent<TEntity> Include(Expression<Func<TEntity, object>> expression);
        IEnumerable<TEntity> SelectPage(int page, int pageSize, out int totalCount);
        IEnumerable<TEntity> Select();
        IEnumerable<TResult> Select<TResult>(Expression<Func<TEntity, TResult>> selector);
        Task<IEnumerable<TEntity>> SelectAsync();
        IQueryable<TEntity> SqlQuery(string query, params object[] parameters);
    }
}