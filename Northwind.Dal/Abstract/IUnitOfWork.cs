using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Northwind.Entity.Base;
using System;

namespace Northwind.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {       
        IGenericRepository<T> GetRepository<T>() where T : EntityBase;
        bool BeginTransaction();
        bool RollBackTransaction();
        int SaveChanges();
    }
}
