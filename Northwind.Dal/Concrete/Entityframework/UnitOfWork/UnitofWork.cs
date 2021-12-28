using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Northwind.Dal.Abstract;
using Northwind.Dal.Concrete.Entityframework.Repository;
using Northwind.Entity.Base;
using System;

namespace Northwind.Dal.Concrete.Entityframework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Variables
        DbContext context;
        IDbContextTransaction transaction;
        bool _dispose;
        #endregion

        public UnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public bool BeginTransaction()
        {
            try
            {
                transaction = context.Database.BeginTransaction();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._dispose)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            this._dispose = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IGenericRepository<T> GetRepository<T>() where T : EntityBase
        {
            return new GenericRepository<T>(context);
        }

        public bool RollBackTransaction()
        {
            try
            {
                transaction.Rollback();
                transaction = null;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int SaveChanges()
        {
            var _transaction = transaction != null ? transaction : context.Database.BeginTransaction();
            using (_transaction)
            {
                try
                {
                    if (context == null)
                    {
                        throw new ArgumentException("Context is null");
                    }

                    int result = context.SaveChanges();

                    //işlemleri onaylar
                    _transaction.Commit();

                    return result;
                }
                catch (Exception ex)
                {
                    //hata olduğunda işleri geri alır
                    transaction.Rollback();

                    throw new Exception("Error on save changes", ex);
                }
            }
        }
    }
}
