using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class OrderSubtotal : EntityBase
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
