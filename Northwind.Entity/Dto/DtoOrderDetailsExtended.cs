using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class DtoOrderDetailsExtended : DtoBase
    {
        public DtoOrderDetailsExtended()
        {

        }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public decimal? ExtendedPrice { get; set; }
    }
}
