using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Interface
{
    public interface ICustomerService : IGenericService<Customer, DtoCustomer>
    {
        IQueryable CustomerReport();
    }
}
