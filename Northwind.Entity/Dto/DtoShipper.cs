using Northwind.Entity.Base;

namespace Northwind.Entity.Dto
{
    public class DtoShipper : DtoBase
    {
        public DtoShipper()
        {
            
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }


    }
}
