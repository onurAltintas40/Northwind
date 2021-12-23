using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(DbContext contex): base(contex)
        {

        }
        public IQueryable RegionReport(int orderId)
        {
            return dbset.AsQueryable();
        }
    }
}
