using System.Linq;

namespace Northwind.Dal.Abstract
{
    public interface IShipperRepository
    {
        IQueryable ShipperReport(int orderId);
    }
}
