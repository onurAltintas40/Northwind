using Northwind.Dal.Abstract;
using Northwind.Entity.Base;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Northwind.Entity.IBase;

namespace Northwind.Bll.Base
{
    public class BllBase<T, TDto> : IGenericService<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        #region Variables

        readonly IUnitOfWork unitOfWork;
        readonly IServiceProvider service;
        readonly IGenericRepository<T> repository;
        Mapper mapper;
        #endregion

        public BllBase(IServiceProvider service)
        {
            unitOfWork = service.GetService<IUnitOfWork>();
            repository = unitOfWork.GetRepository<T>();
            this.service = service;
            mapper = new Mapper((IConfigurationProvider)service);
        }



        public IResponse<TDto> Add(TDto item)
        {
            try
            {
                var resolvedResult = "";
                var TResult = repository.Add(mapper.Map<T>(item));
                resolvedResult = String.Join(',', TResult.GetType().GetProperties().Select(x => $" - {x.Name} ; {x.GetValue(TResult) ?? ""}"));
                Save();


                return new Response<TDto>
                {
                    StatusCode = 100,
                    Message = "Success",
                    Data = mapper.Map<T, TDto>(TResult)
                };
            }
            catch (Exception ex)
            {

                return new Response<TDto>
                {
                    StatusCode = 200,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public Task<TDto> AddAsync(TDto item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TDto item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(TDto item)
        {
            throw new NotImplementedException();
        }

        public IResponse<TDto> Find(int id)
        {
            try
            {
                return new Response<TDto>
                {
                    StatusCode = 88,
                    Message = "Success",
                    Data = mapper.Map<T, TDto>(repository.Find(id))
                };
            }
            catch (Exception ex)
            {

                return new Response<TDto>
                {
                    StatusCode = 999,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public IResponse<List<TDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResponse<List<TDto>> GetAll(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetIQueryable()
        {
            throw new NotImplementedException();
        }
                
        public TDto Update(TDto item)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> UpdateAsync(TDto item)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            unitOfWork.SaveChanges();
        }

    }
}
