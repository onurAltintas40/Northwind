using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerRepository 
    {
        IQueryable CustomerReport();
    }
}
