using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerDemographicRepository
    {
        IQueryable CustomerDemograohicReport(int orderId);
    }
}
