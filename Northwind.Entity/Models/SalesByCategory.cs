using Northwind.Entity.Base;

#nullable disable

namespace Northwind.Entity.Models
{
    public partial class SalesByCategory : EntityBase
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
