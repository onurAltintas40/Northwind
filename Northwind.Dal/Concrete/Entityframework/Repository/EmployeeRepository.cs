using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;
using System.Linq;

namespace Northwind.Dal.Concrete.Entityframework.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {

        }

        public IQueryable EmployeeReport(int orderId)
        {
            return dbset.AsQueryable();
        }
    }
}
