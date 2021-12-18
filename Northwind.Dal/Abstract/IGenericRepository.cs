using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Northwind.Dal.Abstract
{
    public interface IGenericRepository<T> where T : IEntityBase
    {
        T Add(T entity);
        T Update(T entity);       
        T Find(int id);       
        List<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression); // Veritabanı ile çalılırken Queryable kullanılır. Bellek ile çalışılırken Enurable kullanılır.
        bool Delete(int id);
        bool Delete(T entity);

        //include dahil edilri getall metod yapısı gösterecek.

    }
}
