using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ISupplierRepository
    {
        IQueryable SupplierReport(int orderId);
    }
}
