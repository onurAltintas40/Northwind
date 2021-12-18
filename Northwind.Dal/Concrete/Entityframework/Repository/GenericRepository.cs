using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
    {
        #region Variables
        DbContext context;
        protected DbSet<T> dbset;
        #endregion

        #region Constructer
        public GenericRepository(DbContext context)
        {
            this.context = context;
            dbset = this.context.Set<T>();
            this.context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        #endregion

        #region Methods
        
        public T Add(T entity)
        {
            context.Entry(entity).State = EntityState.Added;
            dbset.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            return Delete(Find(id));
        }

        public bool Delete(T entity)
        {
            if(context.Entry(entity).State == EntityState.Detached)
            {
                context.Attach(entity);
            }
            return dbset.Remove(entity) != null;            
        }

        public T Find(int id)
        {
            return dbset.Find(id);
        }
      
        public List<T> GetAll()
        {
            return dbset.ToList();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return dbset.Where(expression); // kontrol et...
        }

        public T Update(T entity)
        {
            dbset.Update(entity);
            return entity;
        }

        #endregion
    }
}
