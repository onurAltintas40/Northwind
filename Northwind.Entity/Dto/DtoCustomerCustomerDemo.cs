using Northwind.Entity.Base;
namespace Northwind.Entity.Dto
{
    public class DtoCustomerCustomerDemo : DtoBase
    {
        public DtoCustomerCustomerDemo()
        {

        }
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }
    }
}
