
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMDAuto.DataAccess.Base
{
    public class BaseRepository<TEntity> : IRepository<TEntity>
            where TEntity : class, IEntity, new()
    {
        protected AmdautoContext Context { get; }

        public BaseRepository(AmdautoContext context, bool isView = false)
        {
            Context = context;
            if(!isView)
            {
                Query = context.Set<TEntity>();
            }
            else
            {
                View = context.Query<TEntity>();
            }
            
        }

        public IQueryable<TEntity> Query { get; }
        public IQueryable<TEntity> View { get; }

        public virtual void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public virtual void Update(TEntity entity)
        {

        }

        public virtual void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
