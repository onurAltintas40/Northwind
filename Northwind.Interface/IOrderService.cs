using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Interface
{
    public interface IOrderService : IGenericService<Order, DtoOrder>
    {
        IQueryable OrderReport(int orderId);
    }
}
