using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(DbContext context) : base(context)
        {

        }

        public IQueryable SupplierReport(int orderId)
        {
            return dbset.AsQueryable();
        }
    }
}
