using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class CustomerDemographicRepository : GenericRepository<CustomerDemographic>, ICustomerDemographicRepository
    {
        public CustomerDemographicRepository(DbContext context) : base(context)
        {

        }

        public IQueryable CustomerDemograohicReport(int orderId)
        {
            return dbset.AsQueryable();
        }      
    }
}
