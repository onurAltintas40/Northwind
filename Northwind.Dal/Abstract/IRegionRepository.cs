using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface  IRegionRepository
    {
        IQueryable RegionReport(int orderId);
    }
}
