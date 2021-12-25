using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class DtoCustomerAndSuppliersByCity : DtoBase
    {
        public DtoCustomerAndSuppliersByCity()
        {

        }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Relationship { get; set; }
    }
}
