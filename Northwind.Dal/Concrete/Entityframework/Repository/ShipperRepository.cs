using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class ShipperRepository : GenericRepository<Shipper>, IShipperRepository
    {
        public ShipperRepository(DbContext context) : base(context)
        {

        }

        public IQueryable ShipperReport(int orderId)
        {
            return dbset.AsQueryable();
        }
    }
}
