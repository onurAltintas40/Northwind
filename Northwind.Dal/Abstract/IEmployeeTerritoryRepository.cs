using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IEmployeeTerritoryRepository
    {
        IQueryable EmployeeTerritoryReport(int orderId);
    }
}
