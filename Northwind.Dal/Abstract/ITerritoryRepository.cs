using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface  ITerritoryRepository
    {
        IQueryable TerritoryReport(int orderId);
    }
}
