using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hotel_Booking.Core.Core.Entities;

namespace Hotel_Booking.Core.IRepositories.Base
{
    public interface IRepository<TEntity, in TEntityIdentity>
        where TEntity : class, IEntityIdentity<TEntityIdentity>
    {
        long GetCount();

        long GetCount(Expression<Func<TEntity, bool>> expression);

        IQueryable<TEntity> GetAll();

        TEntity Get(TEntityIdentity id);

        TEntity Add(TEntity entity);

        IEnumerable<TEntity> Add(IEnumerable<TEntity> entityCollection);

        TEntity Update(TEntity entity);

        IEnumerable<TEntity> Update(IEnumerable<TEntity> entityCollection);

        void Delete(TEntity entity);

        void Delete(TEntityIdentity id);

        void Delete(IEnumerable<TEntity> entityCollection);

        void Delete(IEnumerable<TEntityIdentity> idCollection);
    }
}