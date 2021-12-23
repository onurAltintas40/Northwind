using Microsoft.EntityFrameworkCore;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class CustomerDemographicRepository : GenericRepository<CustomerDemographic>, ICustomerDemographic
    {
        public CustomerDemographicRepository(DbContext context) : base(context)
        {

        }

        public IQueryable CustomerDemographicReport(int orderId)
        {
            return dbset.AsQueryable();
        }
    }
}
