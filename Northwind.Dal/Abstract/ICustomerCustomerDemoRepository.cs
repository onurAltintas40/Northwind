using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerCustomerDemoRepository
    {
        IQueryable CustomerCustomerDemoReport(int orderId);
    }
}
