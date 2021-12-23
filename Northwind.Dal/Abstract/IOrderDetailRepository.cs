using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IOrderDetailRepository
    {
        IQueryable OrderDetailReport(int orderId);
    }
}
