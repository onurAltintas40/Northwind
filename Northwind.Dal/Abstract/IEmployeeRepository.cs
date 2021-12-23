using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IEmployeeRepository
    {
        IQueryable EmployeeReport(int orderId);
    }
}
