using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class OrderDetailRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderDetailRepository(DbContext context) :base(context)
        {

        }
        public IQueryable OrderReport(int orderId)
        {
            return dbset.AsQueryable();
        }
    }
}
