using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hotel_Booking.Core.Core.Entities;
using Hotel_Booking.Core.IRepositories.Base;

namespace Hotel_Booking.Repositories.Base
{
    public class BaseRepository<TEntity, TEntityIdentity> : IRepository<TEntity, TEntityIdentity>
        where TEntity : class, IEntityIdentity<TEntityIdentity>
    {
        public long GetCount()
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity Get(TEntityIdentity id)
        {
            throw new NotImplementedException();
        }

        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntityIdentity id)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity, TEntityIdentity>.Delete(IEnumerable<TEntityIdentity> idCollection)
        {
            throw new NotImplementedException();
        }

        void IRepository<TEntity, TEntityIdentity>.Delete(IEnumerable<TEntity> entityCollection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Update(IEnumerable<TEntity> entityCollection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Add(IEnumerable<TEntity> entityCollection)
        {
            throw new NotImplementedException();
        }

        public long GetCount(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}