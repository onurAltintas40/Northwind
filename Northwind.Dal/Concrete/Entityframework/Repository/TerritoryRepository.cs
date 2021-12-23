using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class TerritoryRepository : GenericRepository<Territory>, ITerritoryRepository
    {
        public TerritoryRepository(DbContext context) : base(context)
        {

        }

        public IQueryable TerritoryReport(int orderId)
        {
            return dbset.AsQueryable();
        }
    }
    }
}
