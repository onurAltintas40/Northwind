using Northwind.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IGenericService<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        IResponse<List<TDto>> GetAll();
        IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression);
        IResponse<TDto> Find(int id);
        IQueryable<T> GetIQueryable();
        IResponse<TDto> Add(TDto item);
        Task<TDto> AddAsync(TDto item);
        TDto Update(TDto item);
        Task<TDto> UpdateAsync(TDto item);
        bool Delete(int id);
        Task<bool> DeleteAsync(int id);
        bool Delete(TDto item);
        Task<bool> DeleteAsync(TDto item);
        void Save();

        //filtrelemeye göre silmek eklenebilir.
        //kayıt sayısı alınabilir.
        //harddelete fonksiyonu eklenebilir.
    }
}
