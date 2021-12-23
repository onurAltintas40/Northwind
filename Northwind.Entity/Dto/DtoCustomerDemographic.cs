using Northwind.Entity.Base;
namespace Northwind.Entity.Dto
{
    public class DtoCustomerDemographic : DtoBase 
    {
        public DtoCustomerDemographic()
        {
            
        }

        public string CustomerTypeId { get; set; }
        public string CustomerDesc { get; set; }
    }
}
