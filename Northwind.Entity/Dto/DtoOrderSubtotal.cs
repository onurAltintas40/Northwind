using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class DtoOrderSubtotal : DtoBase
    {
        public DtoOrderSubtotal()
        {

        }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
