using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IProductRepository
    {
        IQueryable ProductReport(int orderId);
    }
}
