using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ICategoryRepository
    {
        IQueryable CategoryReport(int orderId);
    }
}
