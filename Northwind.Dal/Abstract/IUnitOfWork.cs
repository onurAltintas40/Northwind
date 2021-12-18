using System;

namespace Northwind.Dal.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        //---- Respository Pattern eklenecek
        bool BeginTransaction();
        bool RollBackTransaction();
        int SaveChanges();
    }
}
