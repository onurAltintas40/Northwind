using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IOrderRepository
    {
        IQueryable OrderReport(int orderId);
    }
}
