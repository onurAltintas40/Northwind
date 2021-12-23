using Microsoft.EntityFrameworkCore;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class CustomerCustomerDemoRepository : GenericRepository<CustomerCustomerDemo>, ICustomerCustomerDemo
    {
        public CustomerCustomerDemoRepository(DbContext context) : base(context)
        {

        }

        public IQueryable OrderReport(int orderId)
        {
            return dbset.AsQueryable();
        }
    }
}
